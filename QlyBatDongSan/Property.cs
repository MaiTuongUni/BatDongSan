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
    public partial class Property : Form
    {
        DataBase dataBase;
        UtilsFunction utils = new UtilsFunction();

        public Property()
        {
            InitializeComponent();

            dataBase = new DataBase();
            dataBase.LoadCombobox(cbbType, "name", "id", "select * from property_type");
            txtPrice.Text = "0";
        }

        private void Property_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtId.Text != "")
            {
                string sql = "select * from property where id = " + txtId.Text;
                DataTable dataTable = dataBase.ExecuteQueryDataSet(sql, CommandType.Text).Tables[0];
                if (dataTable.Rows.Count > 0)
                {
                    displayData(dataTable.Rows[0]);
                    return;
                }
                else
                {
                    MessageBox.Show("The infomation user searching is not match");
                }
            }
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if(txtPrice.Text == "")
            {
                txtPrice.Text = "0";
            }
            else
            {
                utils.ConvertCurrency(txtPrice);
            }
        }

        private void clearData()
        {
            txtQuareFeet.Clear();

            txtId.Clear();
            txtQuareFeet.Clear();
            txtOwnerId.Clear();
            txtPrice.Clear();
            txtAddress.Clear();
            numBedroom.Value = 0;
            numBathroom.Value = 0;
            numAge.Value = 0;
            txtDescription.Clear();

            cbBackyard.Checked = false;
            cbBalcony.Checked = false;
            cbPool.Checked = false;
            cbGarage.Checked = false;
       
        }
        private void displayData(DataRow data)
        {
            txtQuareFeet.Clear();

            txtId.Text = data["id"].ToString();
            txtQuareFeet.Text = data["squarefeet"].ToString();
            txtOwnerId.Text = data["ownerId"].ToString();
            txtPrice.Text = data["price"].ToString();
            txtAddress.Text = data["address"].ToString();
            numBedroom.Value = decimal.Parse(data["bedroom"].ToString());
            numBathroom.Value = decimal.Parse(data["bathroom"].ToString());
            numAge.Value = decimal.Parse(data["age"].ToString());
            txtDescription.Text = data["description"].ToString();
            cbbType.SelectedValue = data["type"].ToString();
            int backyard = int.Parse(data["backyard"].ToString());
            if (backyard == 1)
            {
                cbBackyard.Checked = true;
            }
            else
            {
                cbBackyard.Checked = false;
            }

            int balcony = int.Parse(data["balcony"].ToString());
            if (balcony == 1)
            {
                cbBalcony.Checked = true;
            }
            else
            {
                cbBalcony.Checked = false;
            }

            int pool = int.Parse(data["pool"].ToString());
            if (pool == 1)
            {
                cbPool.Checked = true;
            }
            else
            {
                cbPool.Checked = false;
            }

            int garare = int.Parse(data["garage"].ToString());
            if (garare == 1)
            {
                cbGarage.Checked = true;
            }
            else
            {
                cbGarage.Checked = false;
            }
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQuareFeet.Text == "")
                {
                    MessageBox.Show("Square feet is required");
                    return;
                }

                if(txtOwnerId.Text == "")
                {
                    MessageBox.Show("Id Owner is required");
                    return;
                }

                string sql = "select * from owner where id = " + txtOwnerId.Text.Trim();
                DataTable owner = dataBase.ExecuteQueryDataSet(sql,CommandType.Text).Tables[0];

                if(owner.Rows.Count == 0)
                {
                    MessageBox.Show("owner ID is not exist");
                    return;
                }

                if(txtPrice.Text == "0") {
                    MessageBox.Show("Price is required");
                    return;
                }

                int balcony = (cbBalcony.Checked == true) ? 1 : 0;
                int pool = (cbPool.Checked == true) ? 1 : 0;
                int backyard = (cbBackyard.Checked == true) ? 1 : 0;
                int garage = (cbGarage.Checked == true) ? 1 : 0;

                string sqlStrAdd = "insert into property (type,squarefeet,ownerId,price,address,bedroom,bathroom,age,balcony,pool,backyard,garage,description) " +
                    "values('" + cbbType.SelectedValue.ToString() + "','" + txtQuareFeet.Text + "','" + txtOwnerId.Text + "','" + txtPrice.Text + "',N'" + txtAddress.Text + "'," +
                    "'" + numBedroom.Value + "','" + numBathroom.Value + "','" + numAge.Value + "','" + balcony + "'," +
                    "'" + pool + "','" + backyard + "','" + garage + "',N'" + txtDescription.Text + "')";

                dataBase.ExecuteQueryDataSet(sqlStrAdd, CommandType.Text);

                MessageBox.Show("Inserted");
            }
            catch
            {
                MessageBox.Show("The data is not validated");
            }
           
        }

        private void btnEditProperty_Click(object sender, EventArgs e)
        {
            if(txtId.Text =="")
            {
                MessageBox.Show("Id is required");
            }
            DataTable property = dataBase.ExecuteQueryDataSet("select * from property where id = " + txtId.Text.Trim(), CommandType.Text).Tables[0];
            if(property.Rows.Count == 0)
            {
                MessageBox.Show("Id update is not found");
                return;
            }

            if (txtQuareFeet.Text == "")
            {
                MessageBox.Show("Square feet is required");
                return;
            }

            if (txtOwnerId.Text == "")
            {
                MessageBox.Show("Id Owner is required");
                return;
            }

            string sql = "select * from owner where id = " + txtOwnerId.Text.Trim();
            DataTable owner = dataBase.ExecuteQueryDataSet(sql, CommandType.Text).Tables[0];

            if (owner.Rows.Count == 0)
            {
                MessageBox.Show("owner ID is not exist");
                return;
            }

            if (txtPrice.Text == "0")
            {
                MessageBox.Show("Price is required");
                return;
            }

            int balcony = (cbBalcony.Checked == true) ? 1 : 0;
            int pool = (cbPool.Checked == true) ? 1 : 0;
            int backyard = (cbBackyard.Checked == true) ? 1 : 0;
            int garage = (cbGarage.Checked == true) ? 1 : 0;

            string sqlStrUpdate = "update property set type = '" + cbbType.SelectedValue.ToString() + "',squarefeet='" + txtQuareFeet.Text + "'," +
                "ownerId= '" + txtOwnerId.Text + "', price='" + txtPrice.Text + "', address=N'" + txtAddress.Text + "',bedroom='" + numBedroom.Value + "'," +
                "bathroom='" + numBathroom.Value + "',age='" + numAge.Value + "', balcony='" + balcony + "',pool='" + pool + "',backyard='" + backyard + "'," +
                "garage='" + garage + "',description=N'" + txtDescription.Text + "' where  id = " + txtId.Text;

            dataBase.MyExecuteNonQuery(sqlStrUpdate, CommandType.Text);
            MessageBox.Show("Updated");
        }

        private void btnRemoveProperty_Click(object sender, EventArgs e)
        {
            DataTable sale = dataBase.ExecuteQueryDataSet("select * from sale where propertyId = " + txtId.Text,CommandType.Text).Tables[0];
            if (sale.Rows.Count > 0)
            {
                MessageBox.Show("Can not delete because data is used by Sales data");
                return;
            }

            string strRemoveImage = "delete from property_image where propertyId = " + txtId.Text;
            string strRemoveProperty = "delete from property where id =" + txtId.Text;

            try
            {
                dataBase.MyExecuteNonQuery(strRemoveImage, CommandType.Text);
                dataBase.MyExecuteNonQuery(strRemoveProperty, CommandType.Text);
                MessageBox.Show("deleted");
            }
            catch
            {
                MessageBox.Show("Something wrong!, Try again");
                return;
            }
            
            clearData();
        }
    }
}
