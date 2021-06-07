
namespace QlyBatDongSan
{
    partial class Owners
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemoveOwners = new System.Windows.Forms.Button();
            this.btnEditOwners = new System.Windows.Forms.Button();
            this.btnOwnerProperty = new System.Windows.Forms.Button();
            this.btnAddOwners = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDOwners = new System.Windows.Forms.TextBox();
            this.txtFirstNameOwners = new System.Windows.Forms.TextBox();
            this.txtLastNameOwners = new System.Windows.Forms.TextBox();
            this.txtPhoneOwners = new System.Windows.Forms.TextBox();
            this.txtEmailOwners = new System.Windows.Forms.TextBox();
            this.txtAddressOwners = new System.Windows.Forms.TextBox();
            this.lvOwners = new System.Windows.Forms.ListView();
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
            this.panel1.Size = new System.Drawing.Size(1074, 63);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(298, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 31);
            this.label11.TabIndex = 1;
            this.label11.Text = "Owners";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnRemoveOwners);
            this.panel2.Controls.Add(this.btnEditOwners);
            this.panel2.Controls.Add(this.btnOwnerProperty);
            this.panel2.Controls.Add(this.btnAddOwners);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 398);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 124);
            this.panel2.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(704, 11);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(346, 47);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRemoveOwners
            // 
            this.btnRemoveOwners.Location = new System.Drawing.Point(370, 11);
            this.btnRemoveOwners.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveOwners.Name = "btnRemoveOwners";
            this.btnRemoveOwners.Size = new System.Drawing.Size(215, 47);
            this.btnRemoveOwners.TabIndex = 0;
            this.btnRemoveOwners.Text = "Remove";
            this.btnRemoveOwners.UseVisualStyleBackColor = true;
            this.btnRemoveOwners.Click += new System.EventHandler(this.btnRemoveOwners_Click);
            // 
            // btnEditOwners
            // 
            this.btnEditOwners.Location = new System.Drawing.Point(143, 11);
            this.btnEditOwners.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditOwners.Name = "btnEditOwners";
            this.btnEditOwners.Size = new System.Drawing.Size(132, 47);
            this.btnEditOwners.TabIndex = 0;
            this.btnEditOwners.Text = "Edit";
            this.btnEditOwners.UseVisualStyleBackColor = true;
            this.btnEditOwners.Click += new System.EventHandler(this.btnEditOwners_Click);
            // 
            // btnOwnerProperty
            // 
            this.btnOwnerProperty.Location = new System.Drawing.Point(21, 69);
            this.btnOwnerProperty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOwnerProperty.Name = "btnOwnerProperty";
            this.btnOwnerProperty.Size = new System.Drawing.Size(254, 47);
            this.btnOwnerProperty.TabIndex = 0;
            this.btnOwnerProperty.Text = "Owner Property";
            this.btnOwnerProperty.UseVisualStyleBackColor = true;
            this.btnOwnerProperty.Click += new System.EventHandler(this.btnOwnerProperty_Click);
            // 
            // btnAddOwners
            // 
            this.btnAddOwners.Location = new System.Drawing.Point(21, 11);
            this.btnAddOwners.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddOwners.Name = "btnAddOwners";
            this.btnAddOwners.Size = new System.Drawing.Size(118, 47);
            this.btnAddOwners.TabIndex = 0;
            this.btnAddOwners.Text = "Add";
            this.btnAddOwners.UseVisualStyleBackColor = true;
            this.btnAddOwners.Click += new System.EventHandler(this.btnAddOwners_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FirstName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LastName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 297);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Address:";
            // 
            // txtIDOwners
            // 
            this.txtIDOwners.Location = new System.Drawing.Point(80, 72);
            this.txtIDOwners.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDOwners.Name = "txtIDOwners";
            this.txtIDOwners.ReadOnly = true;
            this.txtIDOwners.Size = new System.Drawing.Size(196, 20);
            this.txtIDOwners.TabIndex = 3;
            // 
            // txtFirstNameOwners
            // 
            this.txtFirstNameOwners.Location = new System.Drawing.Point(80, 119);
            this.txtFirstNameOwners.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstNameOwners.Name = "txtFirstNameOwners";
            this.txtFirstNameOwners.Size = new System.Drawing.Size(196, 20);
            this.txtFirstNameOwners.TabIndex = 3;
            // 
            // txtLastNameOwners
            // 
            this.txtLastNameOwners.Location = new System.Drawing.Point(80, 161);
            this.txtLastNameOwners.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastNameOwners.Name = "txtLastNameOwners";
            this.txtLastNameOwners.Size = new System.Drawing.Size(196, 20);
            this.txtLastNameOwners.TabIndex = 3;
            // 
            // txtPhoneOwners
            // 
            this.txtPhoneOwners.Location = new System.Drawing.Point(80, 203);
            this.txtPhoneOwners.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneOwners.Name = "txtPhoneOwners";
            this.txtPhoneOwners.Size = new System.Drawing.Size(196, 20);
            this.txtPhoneOwners.TabIndex = 3;
            // 
            // txtEmailOwners
            // 
            this.txtEmailOwners.Location = new System.Drawing.Point(80, 252);
            this.txtEmailOwners.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmailOwners.Name = "txtEmailOwners";
            this.txtEmailOwners.Size = new System.Drawing.Size(196, 20);
            this.txtEmailOwners.TabIndex = 3;
            // 
            // txtAddressOwners
            // 
            this.txtAddressOwners.Location = new System.Drawing.Point(80, 293);
            this.txtAddressOwners.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddressOwners.Multiline = true;
            this.txtAddressOwners.Name = "txtAddressOwners";
            this.txtAddressOwners.Size = new System.Drawing.Size(196, 91);
            this.txtAddressOwners.TabIndex = 3;
            // 
            // lvOwners
            // 
            this.lvOwners.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.firstName,
            this.lastName,
            this.phoneNumber,
            this.email,
            this.address});
            this.lvOwners.FullRowSelect = true;
            this.lvOwners.HideSelection = false;
            this.lvOwners.Location = new System.Drawing.Point(370, 76);
            this.lvOwners.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvOwners.MultiSelect = false;
            this.lvOwners.Name = "lvOwners";
            this.lvOwners.Size = new System.Drawing.Size(680, 308);
            this.lvOwners.TabIndex = 4;
            this.lvOwners.UseCompatibleStateImageBehavior = false;
            this.lvOwners.View = System.Windows.Forms.View.Details;
            this.lvOwners.Click += new System.EventHandler(this.lvOwners_Click);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // firstName
            // 
            this.firstName.Text = "FirstName";
            this.firstName.Width = 150;
            // 
            // lastName
            // 
            this.lastName.Text = "LastName";
            this.lastName.Width = 150;
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
            this.address.Width = 120;
            // 
            // Owners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(1074, 522);
            this.Controls.Add(this.lvOwners);
            this.Controls.Add(this.txtAddressOwners);
            this.Controls.Add(this.txtEmailOwners);
            this.Controls.Add(this.txtPhoneOwners);
            this.Controls.Add(this.txtLastNameOwners);
            this.Controls.Add(this.txtFirstNameOwners);
            this.Controls.Add(this.txtIDOwners);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Owners";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owners";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddOwners;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDOwners;
        private System.Windows.Forms.TextBox txtFirstNameOwners;
        private System.Windows.Forms.TextBox txtLastNameOwners;
        private System.Windows.Forms.TextBox txtPhoneOwners;
        private System.Windows.Forms.TextBox txtEmailOwners;
        private System.Windows.Forms.TextBox txtAddressOwners;
        private System.Windows.Forms.ListView lvOwners;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemoveOwners;
        private System.Windows.Forms.Button btnEditOwners;
        private System.Windows.Forms.Button btnOwnerProperty;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader phoneNumber;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader address;
    }
}