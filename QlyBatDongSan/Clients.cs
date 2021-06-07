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
    public partial class Clients : Form
    {
        DataBase dataBase;
        DataTable clients;
        public Clients()
        {
            InitializeComponent();
            dataBase = new DataBase();
            clients = new DataTable();
            loadDataPropotypeToView();
        }

        private void loadDataPropotypeToView()
        {
            lvClient.Items.Clear();
            clients = dataBase.ExecuteQueryDataSet("select * from clients", CommandType.Text).Tables[0];
            lvClient.Scrollable = true;
            lvClient.View = View.Details;

            foreach (DataRow row in clients.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["firstname"].ToString());
                item.SubItems.Add(row["lastname"].ToString());
                item.SubItems.Add(row["phonenumber"].ToString());
                item.SubItems.Add(row["email"].ToString());
                item.SubItems.Add(row["address"].ToString());
                lvClient.Items.Add(item);
            }
        }

        private void lvClient_Click(object sender, EventArgs e)
        {
            if (lvClient.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = lvClient.SelectedItems[0];
                foreach (DataRow row in clients.Rows)
                {
                    if (row["id"].ToString().Equals(itemSelected.Text))
                    {
                        txtIDClients.Text = row["id"].ToString();
                        txtFirstNameClients.Text = row["firstname"].ToString();
                        txtLastNameClients.Text = row["lastname"].ToString();
                        txtPhoneClients.Text = row["phonenumber"].ToString();
                        txtEmailClients.Text = row["email"].ToString();
                        txtAddressClients.Text = row["address"].ToString();
                        return;
                    }
                }
            }
        }

        private void btnAddClients_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstNameClients.Text == "")
                {
                    MessageBox.Show("FirstName is required");
                    return;
                }
                if (txtLastNameClients.Text == "")
                {
                    MessageBox.Show("Phone number is required");
                    return;
                }

                string sql = "insert into clients(firstname,lastname,phonenumber,email,address) values " +
                    "(N'" + txtFirstNameClients.Text + "',N'" + txtLastNameClients.Text + "',N'"
                    + txtPhoneClients.Text + "',N'" + txtEmailClients.Text + "',N'" + txtAddressClients.Text + "')";
                dataBase.MyExecuteNonQuery(sql, CommandType.Text);
                MessageBox.Show("inserted");
                loadDataPropotypeToView();
            }
            catch
            {
                MessageBox.Show("The data is not validated");
            }
        }

        private void btnEditClients_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in clients.Rows)
                {
                    if (row["id"].ToString().Equals(txtIDClients.Text))
                    {
                        if (txtFirstNameClients.Text == "")
                        {
                            MessageBox.Show("FirstName is required");
                            return;
                        }
                        if (txtLastNameClients.Text == "")
                        {
                            MessageBox.Show("Phone number is required");
                            return;
                        }

                        string sql = "update clients set firstname=N'" + txtFirstNameClients.Text + "',lastname=N'" + txtLastNameClients.Text + "'," +
                            "phonenumber='" + txtPhoneClients.Text + "',email='" + txtEmailClients.Text + "',address=N'" + txtAddressClients.Text + "' where id =" + txtIDClients.Text;
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

        private void btnRemoveClients_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable property = dataBase.ExecuteQueryDataSet("select * from sale where clientId =" + txtIDClients.Text, CommandType.Text).Tables[0];
                if (property.Rows.Count > 0)
                {
                    MessageBox.Show("Data is used by another place, can not removed");
                    return;
                }
                dataBase.MyExecuteNonQuery("delete clients where id =" + txtIDClients.Text, CommandType.Text);
                MessageBox.Show("removed");
                loadDataPropotypeToView();
                return;
            }
            catch
            {
                MessageBox.Show("Data is used by another place, can not removed");
            }
        }

        private void btnRefreshClients_Click(object sender, EventArgs e)
        {
            loadDataPropotypeToView();
        }
    }
}
