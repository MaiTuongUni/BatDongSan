using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyBatDongSan
{
    public partial class PropertyType : Form
    {
        DataBase dataBase;
        DataTable propotyTypes;
        public PropertyType()
        {
            InitializeComponent();
            dataBase = new DataBase();
            propotyTypes = new DataTable();
        }

        private void PropertyType_Load(object sender, EventArgs e)
        {
            loadDataPropotypeToView();
        }

        private void loadDataPropotypeToView()
        {
            lvPropertyType.Clear();
            propotyTypes = dataBase.ExecuteQueryDataSet("select * from property_type",CommandType.Text).Tables[0];
            lvPropertyType.Scrollable = true;
            lvPropertyType.View = View.Details;
            lvPropertyType.HeaderStyle = ColumnHeaderStyle.None;
            lvPropertyType.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ColumnHeader header = new ColumnHeader();
            header.Text = "MyHeader";
            header.Name = "MyColumn1";
            header.Width = lvPropertyType.Width;
            lvPropertyType.Columns.Add(header);
            foreach (DataRow row in propotyTypes.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row["name"].ToString();
                lvPropertyType.Items.Add(item);
            }
        }

        private void lvPropertyType_Click(object sender, EventArgs e)
        {
            if (lvPropertyType.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = lvPropertyType.SelectedItems[0];
                foreach(DataRow row in propotyTypes.Rows)
                {
                    if (row["name"].ToString().Equals(itemSelected.Text))
                    {
                        txtIdPropertyType.Text = row["id"].ToString();
                        txtNamePropertyType.Text = itemSelected.Text;
                        txtDescriptionPropertyType.Text = row["description"].ToString();
                        return;
                    }
                }
            }
        }

        private void btnAddPropertyType_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNamePropertyType.Text == "")
                {
                    MessageBox.Show("Name is required");
                }
                foreach (DataRow row in propotyTypes.Rows)
                {
                    if (row["name"].ToString().Equals(txtNamePropertyType.Text.Trim()))
                    {
                        MessageBox.Show("Name is dupicated");
                        return;
                    }
                }

                string sql = "insert into property_type(name,description) values( N'" + txtNamePropertyType.Text.Trim()
                    + "',N'" + txtDescriptionPropertyType.Text.Trim() + "')";

                dataBase.MyExecuteNonQuery(sql, CommandType.Text);
                MessageBox.Show("Inserted");
                loadDataPropotypeToView();
            }
            catch
            {
                MessageBox.Show("The data is not validated");
            }
        }

        private void btnEditPropertyType_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNamePropertyType.Text == "")
                {
                    MessageBox.Show("Name is required");
                }
                foreach (DataRow row in propotyTypes.Rows)
                {
                    if (row["name"].ToString().Equals(txtNamePropertyType.Text.Trim()) && !row["id"].ToString().Equals(txtIdPropertyType.Text))
                    {
                        MessageBox.Show("Name is dupicated");
                        return;
                    }
                }

                string sql = "update property_type set name = N'" + txtNamePropertyType.Text.Trim()
                    + "', description =N'" + txtDescriptionPropertyType.Text.Trim() + "' where id =" + txtIdPropertyType.Text;

                dataBase.MyExecuteNonQuery(sql, CommandType.Text);
                MessageBox.Show("edited");
                loadDataPropotypeToView();
            }
            catch
            {
                MessageBox.Show("The data is not validated");
            }
        }

        private void btnRemovePropertyType_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtIdPropertyType.Text == "")
                {
                    MessageBox.Show("Data is not selected before remove");
                    return;
                }
                DataTable property = dataBase.ExecuteQueryDataSet("select * from property where type=" + txtIdPropertyType.Text,CommandType.Text).Tables[0];
                if (property.Rows.Count > 0)
                {
                    MessageBox.Show("Data is ready use in Property, can not removed");
                    return;
                }
                dataBase.MyExecuteNonQuery("delete property_type where id =" + txtIdPropertyType.Text.Trim(), CommandType.Text);
                MessageBox.Show("removed");
                loadDataPropotypeToView();

                txtIdPropertyType.Clear();
                txtNamePropertyType.Clear();
                txtDescriptionPropertyType.Clear();
            }
            catch
            {
                MessageBox.Show("id is not correctly");
            }
        }
    }
}
