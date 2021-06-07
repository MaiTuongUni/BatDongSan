using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyBatDongSan
{
    public partial class PropertyImages : Form
    {
        DataBase dataBase;
        DataTable dataProperty;
        DataTable dataPropertyImage;
        String location;
        int propertyId = -1;
        public PropertyImages()
        {
            InitializeComponent();
            dataBase = new DataBase();
            dataProperty = new DataTable();
            dataPropertyImage = new DataTable();
            dataBase.LoadCombobox(cbSelectAType, "name", "id", "select * from property_type");

        }

        private void cbSelectAType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cbSelectAType.Text == "")
            {
                return;
            }
            lvLeftPropertyImages.Items.Clear();
            dataProperty = dataBase.ExecuteQueryDataSet("select * from property where type =" + cbSelectAType.SelectedValue.ToString(),CommandType.Text).Tables[0];
            if (dataProperty.Rows.Count > 0)
            {
                lvLeftPropertyImages.Scrollable = true;
                lvLeftPropertyImages.View = View.Details;
                foreach (DataRow row in dataProperty.Rows)
                {
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["address"].ToString());
                    lvLeftPropertyImages.Items.Add(item);
                }
            }
        }

        private void PropertyImages_Load(object sender, EventArgs e)
        {
            if (cbSelectAType.Text == "")
            {
                return;
            }

            dataProperty = dataBase.ExecuteQueryDataSet("select * from property where type =" + cbSelectAType.SelectedValue.ToString(), CommandType.Text).Tables[0];
            if (dataProperty.Rows.Count > 0)
            {
                lvLeftPropertyImages.Scrollable = true;
                lvLeftPropertyImages.View = View.Details;
                foreach (DataRow row in dataProperty.Rows)
                {
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["address"].ToString());
                    lvLeftPropertyImages.Items.Add(item);
                }
            }
        }

        private void btnShowThisPropertyImages_Click(object sender, EventArgs e)
        {
            lvMiddlePropertyImages.Items.Clear();
            if (lvLeftPropertyImages.SelectedItems.Count > 0)
            {
                propertyId = int.Parse(lvLeftPropertyImages.SelectedItems[0].Text);

                dataPropertyImage = dataBase.ExecuteQueryDataSet("select * from property_image where propertyId =" + lvLeftPropertyImages.SelectedItems[0].Text, CommandType.Text).Tables[0];
                if (dataPropertyImage.Rows.Count > 0)
                {
                    LoadTypeDetail();
                }
            }
        }

        private void btnBrowsePropertyImages_Click(object sender, EventArgs e)
        {
            location = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG file(*.png)|*.png| ALL files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    location = dialog.FileName;
                    if (string.IsNullOrEmpty(location))
                    {
                        return;
                    }
                    Image image = Image.FromFile(location);

                    pcPropertyImages.Image = image;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error to open the dialog");
            }
        }

        private void btnAddPropertyImages_Click(object sender, EventArgs e)
        {
            try
            {
                if (propertyId == -1)
                {
                    MessageBox.Show("Please choose property to add");
                    return;
                }
                Image image = Image.FromFile(location);
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    dataBase.MyExecuteNonQuery("insert into property_image(propertyId,image) values('"+propertyId+"','" + base64String + "')", CommandType.Text);
                    MessageBox.Show("Add successed");
                }
                
                LoadTypeDetail();
            }
            catch
            {
                MessageBox.Show("File is not formated");
            }
        }
        private void LoadTypeDetail()
        {
            lvMiddlePropertyImages.Items.Clear();
            dataPropertyImage = dataBase.ExecuteQueryDataSet("select * from property_image where propertyId =" + lvLeftPropertyImages.SelectedItems[0].Text, CommandType.Text).Tables[0];

            lvMiddlePropertyImages.Scrollable = true;
            lvMiddlePropertyImages.View = View.Details;
            lvMiddlePropertyImages.HeaderStyle = ColumnHeaderStyle.None;
            lvMiddlePropertyImages.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            ColumnHeader header = new ColumnHeader();
            header.Text = "id";
            header.Name = "id";
            header.Width = lvMiddlePropertyImages.Width;
            lvMiddlePropertyImages.Columns.Add(header);

            foreach (DataRow row in dataPropertyImage.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["id"].ToString();
                lvMiddlePropertyImages.Items.Add(item);
            }
        }

        private void lvMiddlePropertyImages_DoubleClick(object sender, EventArgs e)
        {
            if (lvMiddlePropertyImages.SelectedItems.Count > 0)
            {
                foreach(DataRow row in dataPropertyImage.Rows)
                {
                    if (row["id"].ToString().Equals(lvMiddlePropertyImages.SelectedItems[0].Text))
                    { 
                        //byte[] stringArray = (byte[])row["image"];
                        //MessageBox.Show(stringArray.ToString());
                        //if (stringArray == null)
                        //{
                        //    MessageBox.Show("null");
                        //}
                        string base64 = row["image"].ToString();
                        //MemoryStream stream = new MemoryStream(stringArray);

                        //Image image = Image.FromStream(stream);
                        //pcPropertyImages.Image = image;
                        byte[] imageBytes = Convert.FromBase64String(base64);
                        // Convert byte[] to Image
                        using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                        {
                            Image image = Image.FromStream(ms, true);
                            pcPropertyImages.Image = image;
                        }
                    }
                }
            }
        }

        private void btnRemovePropertyImages_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvMiddlePropertyImages.SelectedItems.Count > 0)
                {
                    string sql = "delete property_image where id =" + lvMiddlePropertyImages.SelectedItems[0].Text;
                    dataBase.MyExecuteNonQuery(sql, CommandType.Text);
                    MessageBox.Show("removed");
                    LoadTypeDetail();
                }
            }
            catch
            {
                MessageBox.Show("Choose the data remove before delete");
            }

        }
    }

}
