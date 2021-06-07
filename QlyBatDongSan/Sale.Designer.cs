
namespace QlyBatDongSan
{
    partial class Sale
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
            this.btnAddNewPropertySale = new System.Windows.Forms.Button();
            this.btnAddNewClientSale = new System.Windows.Forms.Button();
            this.btnRefreshSale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDSale = new System.Windows.Forms.TextBox();
            this.txtPropertyIdSale = new System.Windows.Forms.TextBox();
            this.txtClientIdSale = new System.Windows.Forms.TextBox();
            this.txtFinalPriceSale = new System.Windows.Forms.TextBox();
            this.dtpkSellDateSale = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lvSalesList = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.lvClientListSale = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.lvPropertiesListSale = new System.Windows.Forms.ListView();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.btnEditSale = new System.Windows.Forms.Button();
            this.btnRemoveSale = new System.Windows.Forms.Button();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.property = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstnameClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idPro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ownerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pricePro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.panel1.Size = new System.Drawing.Size(983, 63);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(310, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 31);
            this.label11.TabIndex = 3;
            this.label11.Text = "Sale";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddNewPropertySale);
            this.panel2.Controls.Add(this.btnAddNewClientSale);
            this.panel2.Controls.Add(this.btnRefreshSale);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 441);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 81);
            this.panel2.TabIndex = 1;
            // 
            // btnAddNewPropertySale
            // 
            this.btnAddNewPropertySale.Location = new System.Drawing.Point(750, 18);
            this.btnAddNewPropertySale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNewPropertySale.Name = "btnAddNewPropertySale";
            this.btnAddNewPropertySale.Size = new System.Drawing.Size(210, 44);
            this.btnAddNewPropertySale.TabIndex = 1;
            this.btnAddNewPropertySale.Text = "Add New Property";
            this.btnAddNewPropertySale.UseVisualStyleBackColor = true;
            this.btnAddNewPropertySale.Click += new System.EventHandler(this.btnAddNewPropertySale_Click);
            // 
            // btnAddNewClientSale
            // 
            this.btnAddNewClientSale.Location = new System.Drawing.Point(474, 18);
            this.btnAddNewClientSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNewClientSale.Name = "btnAddNewClientSale";
            this.btnAddNewClientSale.Size = new System.Drawing.Size(226, 44);
            this.btnAddNewClientSale.TabIndex = 1;
            this.btnAddNewClientSale.Text = "Add New Client";
            this.btnAddNewClientSale.UseVisualStyleBackColor = true;
            this.btnAddNewClientSale.Click += new System.EventHandler(this.btnAddNewClientSale_Click);
            // 
            // btnRefreshSale
            // 
            this.btnRefreshSale.Location = new System.Drawing.Point(11, 18);
            this.btnRefreshSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefreshSale.Name = "btnRefreshSale";
            this.btnRefreshSale.Size = new System.Drawing.Size(424, 44);
            this.btnRefreshSale.TabIndex = 0;
            this.btnRefreshSale.Text = "Refresh";
            this.btnRefreshSale.UseVisualStyleBackColor = true;
            this.btnRefreshSale.Click += new System.EventHandler(this.btnRefreshSale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
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
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Property ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Final Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sell Date:";
            // 
            // txtIDSale
            // 
            this.txtIDSale.Location = new System.Drawing.Point(79, 71);
            this.txtIDSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDSale.Name = "txtIDSale";
            this.txtIDSale.ReadOnly = true;
            this.txtIDSale.Size = new System.Drawing.Size(90, 20);
            this.txtIDSale.TabIndex = 3;
            // 
            // txtPropertyIdSale
            // 
            this.txtPropertyIdSale.Location = new System.Drawing.Point(79, 118);
            this.txtPropertyIdSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPropertyIdSale.Name = "txtPropertyIdSale";
            this.txtPropertyIdSale.Size = new System.Drawing.Size(90, 20);
            this.txtPropertyIdSale.TabIndex = 3;
            // 
            // txtClientIdSale
            // 
            this.txtClientIdSale.Location = new System.Drawing.Point(79, 161);
            this.txtClientIdSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClientIdSale.Name = "txtClientIdSale";
            this.txtClientIdSale.Size = new System.Drawing.Size(90, 20);
            this.txtClientIdSale.TabIndex = 3;
            // 
            // txtFinalPriceSale
            // 
            this.txtFinalPriceSale.Location = new System.Drawing.Point(79, 204);
            this.txtFinalPriceSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFinalPriceSale.Name = "txtFinalPriceSale";
            this.txtFinalPriceSale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFinalPriceSale.Size = new System.Drawing.Size(90, 20);
            this.txtFinalPriceSale.TabIndex = 3;
            this.txtFinalPriceSale.TextChanged += new System.EventHandler(this.txtFinalPriceSale_TextChanged);
            // 
            // dtpkSellDateSale
            // 
            this.dtpkSellDateSale.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkSellDateSale.Location = new System.Drawing.Point(76, 249);
            this.dtpkSellDateSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpkSellDateSale.Name = "dtpkSellDateSale";
            this.dtpkSellDateSale.Size = new System.Drawing.Size(92, 20);
            this.dtpkSellDateSale.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sales List:";
            // 
            // lvSalesList
            // 
            this.lvSalesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.property,
            this.client,
            this.price,
            this.date});
            this.lvSalesList.FullRowSelect = true;
            this.lvSalesList.HideSelection = false;
            this.lvSalesList.Location = new System.Drawing.Point(185, 86);
            this.lvSalesList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvSalesList.MultiSelect = false;
            this.lvSalesList.Name = "lvSalesList";
            this.lvSalesList.Size = new System.Drawing.Size(250, 331);
            this.lvSalesList.TabIndex = 6;
            this.lvSalesList.UseCompatibleStateImageBehavior = false;
            this.lvSalesList.View = System.Windows.Forms.View.Details;
            this.lvSalesList.Click += new System.EventHandler(this.lvSalesList_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(542, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Clients Clist:";
            // 
            // lvClientListSale
            // 
            this.lvClientListSale.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idClient,
            this.firstnameClient,
            this.lastname});
            this.lvClientListSale.FullRowSelect = true;
            this.lvClientListSale.HideSelection = false;
            this.lvClientListSale.Location = new System.Drawing.Point(456, 87);
            this.lvClientListSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvClientListSale.MultiSelect = false;
            this.lvClientListSale.Name = "lvClientListSale";
            this.lvClientListSale.Size = new System.Drawing.Size(244, 331);
            this.lvClientListSale.TabIndex = 6;
            this.lvClientListSale.UseCompatibleStateImageBehavior = false;
            this.lvClientListSale.View = System.Windows.Forms.View.Details;
            this.lvClientListSale.Click += new System.EventHandler(this.lvClientListSale_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(793, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Properties List:";
            // 
            // lvPropertiesListSale
            // 
            this.lvPropertiesListSale.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idPro,
            this.ownerId,
            this.pricePro});
            this.lvPropertiesListSale.FullRowSelect = true;
            this.lvPropertiesListSale.HideSelection = false;
            this.lvPropertiesListSale.Location = new System.Drawing.Point(722, 86);
            this.lvPropertiesListSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvPropertiesListSale.MultiSelect = false;
            this.lvPropertiesListSale.Name = "lvPropertiesListSale";
            this.lvPropertiesListSale.Size = new System.Drawing.Size(238, 331);
            this.lvPropertiesListSale.TabIndex = 6;
            this.lvPropertiesListSale.UseCompatibleStateImageBehavior = false;
            this.lvPropertiesListSale.View = System.Windows.Forms.View.Details;
            this.lvPropertiesListSale.Click += new System.EventHandler(this.lvPropertiesListSale_Click);
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(11, 283);
            this.btnAddSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(157, 37);
            this.btnAddSale.TabIndex = 7;
            this.btnAddSale.Text = "Add";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // btnEditSale
            // 
            this.btnEditSale.Location = new System.Drawing.Point(11, 330);
            this.btnEditSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditSale.Name = "btnEditSale";
            this.btnEditSale.Size = new System.Drawing.Size(157, 37);
            this.btnEditSale.TabIndex = 7;
            this.btnEditSale.Text = "Edit";
            this.btnEditSale.UseVisualStyleBackColor = true;
            this.btnEditSale.Click += new System.EventHandler(this.btnEditSale_Click);
            // 
            // btnRemoveSale
            // 
            this.btnRemoveSale.Location = new System.Drawing.Point(11, 381);
            this.btnRemoveSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveSale.Name = "btnRemoveSale";
            this.btnRemoveSale.Size = new System.Drawing.Size(157, 37);
            this.btnRemoveSale.TabIndex = 7;
            this.btnRemoveSale.Text = "Remove";
            this.btnRemoveSale.UseVisualStyleBackColor = true;
            this.btnRemoveSale.Click += new System.EventHandler(this.btnRemoveSale_Click);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 30;
            // 
            // property
            // 
            this.property.Text = "Property";
            this.property.Width = 55;
            // 
            // client
            // 
            this.client.Text = "Client";
            this.client.Width = 40;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 65;
            // 
            // date
            // 
            this.date.Text = "Date";
            // 
            // idClient
            // 
            this.idClient.Text = "ID";
            this.idClient.Width = 50;
            // 
            // firstnameClient
            // 
            this.firstnameClient.Text = "FirstName";
            this.firstnameClient.Width = 100;
            // 
            // lastname
            // 
            this.lastname.Text = "LastName";
            this.lastname.Width = 100;
            // 
            // idPro
            // 
            this.idPro.Text = "ID";
            // 
            // ownerId
            // 
            this.ownerId.Text = "Owner ID";
            // 
            // pricePro
            // 
            this.pricePro.Text = "Price";
            this.pricePro.Width = 140;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(983, 522);
            this.Controls.Add(this.btnRemoveSale);
            this.Controls.Add(this.btnEditSale);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.lvPropertiesListSale);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvClientListSale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvSalesList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpkSellDateSale);
            this.Controls.Add(this.txtFinalPriceSale);
            this.Controls.Add(this.txtClientIdSale);
            this.Controls.Add(this.txtPropertyIdSale);
            this.Controls.Add(this.txtIDSale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
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
        private System.Windows.Forms.Button btnAddNewPropertySale;
        private System.Windows.Forms.Button btnAddNewClientSale;
        private System.Windows.Forms.Button btnRefreshSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDSale;
        private System.Windows.Forms.TextBox txtPropertyIdSale;
        private System.Windows.Forms.TextBox txtClientIdSale;
        private System.Windows.Forms.TextBox txtFinalPriceSale;
        private System.Windows.Forms.DateTimePicker dtpkSellDateSale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvSalesList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvClientListSale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvPropertiesListSale;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button btnEditSale;
        private System.Windows.Forms.Button btnRemoveSale;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader property;
        private System.Windows.Forms.ColumnHeader client;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader idClient;
        private System.Windows.Forms.ColumnHeader firstnameClient;
        private System.Windows.Forms.ColumnHeader lastname;
        private System.Windows.Forms.ColumnHeader idPro;
        private System.Windows.Forms.ColumnHeader ownerId;
        private System.Windows.Forms.ColumnHeader pricePro;
    }
}