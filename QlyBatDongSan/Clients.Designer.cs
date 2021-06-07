
namespace QlyBatDongSan
{
    partial class Clients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefreshClients = new System.Windows.Forms.Button();
            this.btnRemoveClients = new System.Windows.Forms.Button();
            this.btnEditClients = new System.Windows.Forms.Button();
            this.btnAddClients = new System.Windows.Forms.Button();
            this.txtAddressClients = new System.Windows.Forms.TextBox();
            this.txtEmailClients = new System.Windows.Forms.TextBox();
            this.txtPhoneClients = new System.Windows.Forms.TextBox();
            this.txtLastNameClients = new System.Windows.Forms.TextBox();
            this.txtFirstNameClients = new System.Windows.Forms.TextBox();
            this.txtIDClients = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvClient = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Magenta;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 63);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(296, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 31);
            this.label11.TabIndex = 2;
            this.label11.Text = "Clients";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefreshClients);
            this.panel2.Controls.Add(this.btnRemoveClients);
            this.panel2.Controls.Add(this.btnEditClients);
            this.panel2.Controls.Add(this.btnAddClients);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 433);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 89);
            this.panel2.TabIndex = 1;
            // 
            // btnRefreshClients
            // 
            this.btnRefreshClients.Location = new System.Drawing.Point(772, 19);
            this.btnRefreshClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefreshClients.Name = "btnRefreshClients";
            this.btnRefreshClients.Size = new System.Drawing.Size(293, 47);
            this.btnRefreshClients.TabIndex = 1;
            this.btnRefreshClients.Text = "Refresh";
            this.btnRefreshClients.UseVisualStyleBackColor = true;
            this.btnRefreshClients.Click += new System.EventHandler(this.btnRefreshClients_Click);
            // 
            // btnRemoveClients
            // 
            this.btnRemoveClients.Location = new System.Drawing.Point(385, 19);
            this.btnRemoveClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveClients.Name = "btnRemoveClients";
            this.btnRemoveClients.Size = new System.Drawing.Size(239, 47);
            this.btnRemoveClients.TabIndex = 1;
            this.btnRemoveClients.Text = "Remove";
            this.btnRemoveClients.UseVisualStyleBackColor = true;
            this.btnRemoveClients.Click += new System.EventHandler(this.btnRemoveClients_Click);
            // 
            // btnEditClients
            // 
            this.btnEditClients.Location = new System.Drawing.Point(161, 19);
            this.btnEditClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditClients.Name = "btnEditClients";
            this.btnEditClients.Size = new System.Drawing.Size(118, 47);
            this.btnEditClients.TabIndex = 1;
            this.btnEditClients.Text = "Edit";
            this.btnEditClients.UseVisualStyleBackColor = true;
            this.btnEditClients.Click += new System.EventHandler(this.btnEditClients_Click);
            // 
            // btnAddClients
            // 
            this.btnAddClients.Location = new System.Drawing.Point(15, 19);
            this.btnAddClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddClients.Name = "btnAddClients";
            this.btnAddClients.Size = new System.Drawing.Size(118, 47);
            this.btnAddClients.TabIndex = 1;
            this.btnAddClients.Text = "Add";
            this.btnAddClients.UseVisualStyleBackColor = true;
            this.btnAddClients.Click += new System.EventHandler(this.btnAddClients_Click);
            // 
            // txtAddressClients
            // 
            this.txtAddressClients.Location = new System.Drawing.Point(84, 302);
            this.txtAddressClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddressClients.Multiline = true;
            this.txtAddressClients.Name = "txtAddressClients";
            this.txtAddressClients.Size = new System.Drawing.Size(196, 107);
            this.txtAddressClients.TabIndex = 10;
            // 
            // txtEmailClients
            // 
            this.txtEmailClients.Location = new System.Drawing.Point(84, 261);
            this.txtEmailClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmailClients.Name = "txtEmailClients";
            this.txtEmailClients.Size = new System.Drawing.Size(196, 20);
            this.txtEmailClients.TabIndex = 11;
            // 
            // txtPhoneClients
            // 
            this.txtPhoneClients.Location = new System.Drawing.Point(84, 212);
            this.txtPhoneClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneClients.Name = "txtPhoneClients";
            this.txtPhoneClients.Size = new System.Drawing.Size(196, 20);
            this.txtPhoneClients.TabIndex = 12;
            // 
            // txtLastNameClients
            // 
            this.txtLastNameClients.Location = new System.Drawing.Point(84, 170);
            this.txtLastNameClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastNameClients.Name = "txtLastNameClients";
            this.txtLastNameClients.Size = new System.Drawing.Size(196, 20);
            this.txtLastNameClients.TabIndex = 13;
            // 
            // txtFirstNameClients
            // 
            this.txtFirstNameClients.Location = new System.Drawing.Point(84, 128);
            this.txtFirstNameClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstNameClients.Name = "txtFirstNameClients";
            this.txtFirstNameClients.Size = new System.Drawing.Size(196, 20);
            this.txtFirstNameClients.TabIndex = 14;
            // 
            // txtIDClients
            // 
            this.txtIDClients.Location = new System.Drawing.Point(84, 81);
            this.txtIDClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDClients.Name = "txtIDClients";
            this.txtIDClients.ReadOnly = true;
            this.txtIDClients.Size = new System.Drawing.Size(196, 20);
            this.txtIDClients.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "LastName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "FirstName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID:";
            // 
            // lvClient
            // 
            this.lvClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.firstName,
            this.lastName,
            this.phoneNumber,
            this.email,
            this.address});
            this.lvClient.FullRowSelect = true;
            this.lvClient.HideSelection = false;
            this.lvClient.Location = new System.Drawing.Point(385, 85);
            this.lvClient.Margin = new System.Windows.Forms.Padding(2);
            this.lvClient.MultiSelect = false;
            this.lvClient.Name = "lvClient";
            this.lvClient.Size = new System.Drawing.Size(680, 308);
            this.lvClient.TabIndex = 16;
            this.lvClient.UseCompatibleStateImageBehavior = false;
            this.lvClient.View = System.Windows.Forms.View.Details;
            this.lvClient.Click += new System.EventHandler(this.lvClient_Click);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // firstName
            // 
            this.firstName.Text = "FirstName";
            this.firstName.Width = 120;
            // 
            // lastName
            // 
            this.lastName.Text = "LastName";
            this.lastName.Width = 120;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Text = "Phone";
            this.phoneNumber.Width = 100;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 100;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 170;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(1095, 522);
            this.Controls.Add(this.lvClient);
            this.Controls.Add(this.txtAddressClients);
            this.Controls.Add(this.txtEmailClients);
            this.Controls.Add(this.txtPhoneClients);
            this.Controls.Add(this.txtLastNameClients);
            this.Controls.Add(this.txtFirstNameClients);
            this.Controls.Add(this.txtIDClients);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Clients";
            this.Text = "Clients";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAddressClients;
        private System.Windows.Forms.TextBox txtEmailClients;
        private System.Windows.Forms.TextBox txtPhoneClients;
        private System.Windows.Forms.TextBox txtLastNameClients;
        private System.Windows.Forms.TextBox txtFirstNameClients;
        private System.Windows.Forms.TextBox txtIDClients;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefreshClients;
        private System.Windows.Forms.Button btnRemoveClients;
        private System.Windows.Forms.Button btnEditClients;
        private System.Windows.Forms.Button btnAddClients;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lvClient;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader phoneNumber;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader address;
    }
}