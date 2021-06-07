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
    public partial class Sale : Form
    {
        DataBase dataBase;
        DataTable clients;
        DataTable properties;
        DataTable sales;
        UtilsFunction utils = new UtilsFunction();

        public Sale()
        {
            InitializeComponent();
            dataBase = new DataBase();
            clients = new DataTable();
            sales = new DataTable();
            loadDataPropotypeToView();
        }

        private void loadDataPropotypeToView()
        {
            loadDataClient();
            loadDataProperty();
            loadDataSale();
        }
        private void loadDataClient()
        {
            lvClientListSale.Items.Clear();
            clients = dataBase.ExecuteQueryDataSet("select * from clients", CommandType.Text).Tables[0];
            lvClientListSale.Scrollable = true;
            lvClientListSale.View = View.Details;

            foreach (DataRow row in clients.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["firstname"].ToString());
                item.SubItems.Add(row["lastname"].ToString());
                lvClientListSale.Items.Add(item);
            }
        }

        private void loadDataProperty()
        {
            lvPropertiesListSale.Items.Clear();
            properties = dataBase.ExecuteQueryDataSet("select * from property", CommandType.Text).Tables[0];
            lvClientListSale.Scrollable = true;
            lvClientListSale.View = View.Details;

            foreach (DataRow row in properties.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["ownerId"].ToString());
                item.SubItems.Add(row["price"].ToString());
                lvPropertiesListSale.Items.Add(item);
            }
        }

        private void loadDataSale()
        {
            lvSalesList.Items.Clear();
            sales = dataBase.ExecuteQueryDataSet("select * from sale", CommandType.Text).Tables[0];
            lvSalesList.Scrollable = true;
            lvSalesList.View = View.Details;

            foreach (DataRow row in sales.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["propertyId"].ToString());
                item.SubItems.Add(row["clientId"].ToString());
                item.SubItems.Add(row["finalprice"].ToString());
                item.SubItems.Add(row["saledate"].ToString());
                lvSalesList.Items.Add(item);
            }
        }

        private void lvClientListSale_Click(object sender, EventArgs e)
        {
            if (lvClientListSale.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = lvClientListSale.SelectedItems[0];
                foreach (DataRow row in clients.Rows)
                {
                    if (row["id"].ToString().Equals(itemSelected.Text))
                    {
                        txtClientIdSale.Text = row["id"].ToString();
                        return;
                    }
                }
            }
        }

        private void lvPropertiesListSale_Click(object sender, EventArgs e)
        {
            if (lvPropertiesListSale.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = lvPropertiesListSale.SelectedItems[0];
                foreach (DataRow row in properties.Rows)
                {
                    if (row["id"].ToString().Equals(itemSelected.Text))
                    {
                        txtPropertyIdSale.Text = row["id"].ToString();
                        return;
                    }
                }
            }
        }

        bool saleClick = false;
        private void lvSalesList_Click(object sender, EventArgs e)
        {
            if (lvSalesList.SelectedItems.Count > 0)
            {
                saleClick = true;
                ListViewItem itemSelected = lvSalesList.SelectedItems[0];
                foreach (DataRow row in sales.Rows)
                {
                    if (row["id"].ToString().Equals(itemSelected.Text))
                    {
                        txtClientIdSale.Text = row["clientId"].ToString();
                        txtPropertyIdSale.Text = row["propertyId"].ToString();
                        txtIDSale.Text = row["id"].ToString();
                        txtFinalPriceSale.Text = row["finalprice"].ToString();
                        dtpkSellDateSale.Text = row["saledate"].ToString();
                        return;
                    }
                }
            }
        }

        private void txtFinalPriceSale_TextChanged(object sender, EventArgs e)
        {
            if(saleClick == false)
            {
                if (txtFinalPriceSale.Text != "")
                {
                    utils.ConvertCurrency(txtFinalPriceSale);
                }
                else
                {
                    txtFinalPriceSale.Text = "0";
                }
            }
            else
            {
                saleClick = false;
            }
          
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClientIdSale.Text == "")
                {
                    MessageBox.Show("Client ID is required");
                    return;
                }

                if(txtPropertyIdSale.Text == "")
                {
                    MessageBox.Show("Property ID is required");
                    return;
                }

                if(txtFinalPriceSale.Text == "" || txtFinalPriceSale.Text == "0")
                {
                    MessageBox.Show("Pinal price is required");
                    return;
                }

                DataTable case1 = dataBase.ExecuteQueryDataSet("select * from property where id=" + txtPropertyIdSale.Text, CommandType.Text).Tables[0];
                if (case1.Rows.Count == 0)
                {
                    MessageBox.Show("Id Property is not correctly");
                    return;
                }

                DataTable case2 = dataBase.ExecuteQueryDataSet("select * from clients where id=" + txtClientIdSale.Text, CommandType.Text).Tables[0];
                if (case1.Rows.Count == 0)
                {
                    MessageBox.Show("Id Property is not correctly");
                    return;
                }

                dataBase.MyExecuteNonQuery("insert into sale(propertyId,clientId,finalprice,saledate) values" +
                    "('" + txtPropertyIdSale.Text + "','" + txtClientIdSale.Text + "','" + txtFinalPriceSale.Text + "','" + dtpkSellDateSale.Text + "')", CommandType.Text);
                MessageBox.Show("Inserted");
                loadDataPropotypeToView();
                return;
            }
            catch
            {
                MessageBox.Show("Faild to add new data");
            }
        }

        private void btnEditSale_Click(object sender, EventArgs e)
        {
            try
            {

                if(txtIDSale.Text == "")
                {
                    MessageBox.Show("ID update is required");
                    return;
                }
                if (txtClientIdSale.Text == "")
                {
                    MessageBox.Show("Client ID is required");
                    return;
                }

                if (txtPropertyIdSale.Text == "")
                {
                    MessageBox.Show("Property ID is required");
                    return;
                }

                if (txtFinalPriceSale.Text == "" || txtFinalPriceSale.Text == "0")
                {
                    MessageBox.Show("Pinal price is required");
                    return;
                }

                DataTable case1 = dataBase.ExecuteQueryDataSet("select * from property where id=" + txtPropertyIdSale.Text, CommandType.Text).Tables[0];
                if (case1.Rows.Count == 0)
                {
                    MessageBox.Show("Id Property is not correctly");
                    return;
                }

                DataTable case2 = dataBase.ExecuteQueryDataSet("select * from clients where id=" + txtClientIdSale.Text, CommandType.Text).Tables[0];
                if (case1.Rows.Count == 0)
                {
                    MessageBox.Show("Id Property is not correctly");
                    return;
                }
                string sql = "update sale set propertyId='" + txtPropertyIdSale.Text + "'," +
                    "clientId='" + txtClientIdSale.Text + "',finalprice='" + txtFinalPriceSale.Text + "',saledate='" + dtpkSellDateSale.Text + "' where id =" + txtIDSale.Text;
                dataBase.MyExecuteNonQuery(sql, CommandType.Text);
                MessageBox.Show("updated");
                loadDataPropotypeToView();
                return;
            }
            catch
            {
                MessageBox.Show("Faild to update data");
            }
        }

        private void btnRemoveSale_Click(object sender, EventArgs e)
        {
            if(txtIDSale.Text != "")
            {
                dataBase.MyExecuteNonQuery("delete sale where id =" + txtIDSale.Text, CommandType.Text);
                MessageBox.Show("removed");
            }
        }

        private void btnRefreshSale_Click(object sender, EventArgs e)
        {
            loadDataPropotypeToView();
        }

        private void btnAddNewClientSale_Click(object sender, EventArgs e)
        {
            Form client = new Clients();
            client.ShowDialog();
            loadDataPropotypeToView();
        }

        private void btnAddNewPropertySale_Click(object sender, EventArgs e)
        {
            Form property = new Property();
            property.ShowDialog();
        }
    }
}
