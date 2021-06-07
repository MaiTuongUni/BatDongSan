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
    public partial class Owners : Form
    {
        DataBase dataBase;
        DataTable owners;
        public Owners()
        {
            InitializeComponent();
            dataBase = new DataBase();
            owners = new DataTable();
            loadDataPropotypeToView();
        }

        private void loadDataPropotypeToView()
        {
            lvOwners.Items.Clear();
            owners = dataBase.ExecuteQueryDataSet("select * from owner", CommandType.Text).Tables[0];
            lvOwners.Scrollable = true;
            lvOwners.View = View.Details;

            foreach (DataRow row in owners.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["firstname"].ToString());
                item.SubItems.Add(row["lastname"].ToString());
                item.SubItems.Add(row["phone"].ToString());
                item.SubItems.Add(row["email"].ToString());
                item.SubItems.Add(row["address"].ToString());
                lvOwners.Items.Add(item);
            }
        }

        private void lvOwners_Click(object sender, EventArgs e)
        {
            if (lvOwners.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = lvOwners.SelectedItems[0];
                foreach (DataRow row in owners.Rows)
                {
                    if (row["id"].ToString().Equals(itemSelected.Text))
                    {
                        txtIDOwners.Text = row["id"].ToString();
                        txtFirstNameOwners.Text = row["firstname"].ToString();
                        txtLastNameOwners.Text = row["lastname"].ToString();
                        txtPhoneOwners.Text = row["phone"].ToString();
                        txtEmailOwners.Text = row["email"].ToString();
                        txtAddressOwners.Text = row["address"].ToString();
                        return;
                    }
                }
            }
        }

        private void btnAddOwners_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstNameOwners.Text == "")
                {
                    MessageBox.Show("FirstName is required");
                    return;
                }
                if (txtPhoneOwners.Text == "")
                {
                    MessageBox.Show("Phone number is required");
                    return;
                }

                string sql = "insert into owner(firstname,lastname,phone,email,address) values " +
                    "(N'" + txtFirstNameOwners.Text + "',N'" + txtLastNameOwners.Text + "',N'"
                    + txtPhoneOwners.Text + "',N'" + txtEmailOwners.Text + "',N'" + txtAddressOwners.Text + "')";
                dataBase.MyExecuteNonQuery(sql, CommandType.Text);
                MessageBox.Show("inserted");
                loadDataPropotypeToView();
            }
            catch
            {
                MessageBox.Show("The data is not validated");
            }
        }

        private void btnEditOwners_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(DataRow row in owners.Rows)
                {
                    if (row["id"].ToString().Equals(txtIDOwners.Text))
                    {
                        if (txtFirstNameOwners.Text == "")
                        {
                            MessageBox.Show("FirstName is required");
                            return;
                        }
                        if (txtPhoneOwners.Text == "")
                        {
                            MessageBox.Show("Phone number is required");
                            return;
                        }

                        string sql = "update owner set firstname=N'" + txtFirstNameOwners.Text + "',lastname=N'" + txtLastNameOwners.Text + "'," +
                            "phone='" + txtPhoneOwners.Text + "',email='" + txtEmailOwners.Text + "',address=N'" + txtAddressOwners.Text + "' where id ="+txtIDOwners.Text;
                        dataBase.MyExecuteNonQuery(sql, CommandType.Text);
                        loadDataPropotypeToView();
                        return;
                    }
                }
                MessageBox.Show("Id is not correctly");
            }
            catch
            {
                MessageBox.Show("The data is not validated");
            }
        }

        private void btnRemoveOwners_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable property = dataBase.ExecuteQueryDataSet("select * from property where ownerId =" + txtIDOwners.Text, CommandType.Text).Tables[0];
                if (property.Rows.Count > 0)
                {
                    MessageBox.Show("Data is used by another place, can not removed");
                    return;
                }
                dataBase.MyExecuteNonQuery("delete owner where id =" + txtIDOwners.Text, CommandType.Text);
                MessageBox.Show("removed");
                loadDataPropotypeToView();
                return;
            }
            catch
            {
                MessageBox.Show("Data is used by another place, can not removed"); 
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDataPropotypeToView();
        }

        private void btnOwnerProperty_Click(object sender, EventArgs e)
        {

        }
    }
}
