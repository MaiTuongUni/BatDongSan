
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
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
            this.btnRefreshSale = new System.Windows.Forms.Button();
            this.btnAddNewClientSale = new System.Windows.Forms.Button();
            this.btnAddNewPropertySale = new System.Windows.Forms.Button();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 77);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddNewPropertySale);
            this.panel2.Controls.Add(this.btnAddNewClientSale);
            this.panel2.Controls.Add(this.btnRefreshSale);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 542);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 100);
            this.panel2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(414, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 39);
            this.label11.TabIndex = 3;
            this.label11.Text = "Sale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Property ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Final Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sell Date:";
            // 
            // txtIDSale
            // 
            this.txtIDSale.Location = new System.Drawing.Point(105, 87);
            this.txtIDSale.Name = "txtIDSale";
            this.txtIDSale.Size = new System.Drawing.Size(119, 22);
            this.txtIDSale.TabIndex = 3;
            // 
            // txtPropertyIdSale
            // 
            this.txtPropertyIdSale.Location = new System.Drawing.Point(105, 145);
            this.txtPropertyIdSale.Name = "txtPropertyIdSale";
            this.txtPropertyIdSale.Size = new System.Drawing.Size(119, 22);
            this.txtPropertyIdSale.TabIndex = 3;
            // 
            // txtClientIdSale
            // 
            this.txtClientIdSale.Location = new System.Drawing.Point(105, 198);
            this.txtClientIdSale.Name = "txtClientIdSale";
            this.txtClientIdSale.Size = new System.Drawing.Size(119, 22);
            this.txtClientIdSale.TabIndex = 3;
            // 
            // txtFinalPriceSale
            // 
            this.txtFinalPriceSale.Location = new System.Drawing.Point(105, 251);
            this.txtFinalPriceSale.Name = "txtFinalPriceSale";
            this.txtFinalPriceSale.Size = new System.Drawing.Size(119, 22);
            this.txtFinalPriceSale.TabIndex = 3;
            // 
            // dtpkSellDateSale
            // 
            this.dtpkSellDateSale.Location = new System.Drawing.Point(102, 307);
            this.dtpkSellDateSale.Name = "dtpkSellDateSale";
            this.dtpkSellDateSale.Size = new System.Drawing.Size(122, 22);
            this.dtpkSellDateSale.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sales List:";
            // 
            // lvSalesList
            // 
            this.lvSalesList.HideSelection = false;
            this.lvSalesList.Location = new System.Drawing.Point(238, 109);
            this.lvSalesList.Name = "lvSalesList";
            this.lvSalesList.Size = new System.Drawing.Size(222, 406);
            this.lvSalesList.TabIndex = 6;
            this.lvSalesList.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(478, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Clients Clist:";
            // 
            // lvClientListSale
            // 
            this.lvClientListSale.HideSelection = false;
            this.lvClientListSale.Location = new System.Drawing.Point(474, 109);
            this.lvClientListSale.Name = "lvClientListSale";
            this.lvClientListSale.Size = new System.Drawing.Size(222, 406);
            this.lvClientListSale.TabIndex = 6;
            this.lvClientListSale.UseCompatibleStateImageBehavior = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(716, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Properties List:";
            // 
            // lvPropertiesListSale
            // 
            this.lvPropertiesListSale.HideSelection = false;
            this.lvPropertiesListSale.Location = new System.Drawing.Point(712, 108);
            this.lvPropertiesListSale.Name = "lvPropertiesListSale";
            this.lvPropertiesListSale.Size = new System.Drawing.Size(225, 406);
            this.lvPropertiesListSale.TabIndex = 6;
            this.lvPropertiesListSale.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(15, 348);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(209, 45);
            this.btnAddSale.TabIndex = 7;
            this.btnAddSale.Text = "Add";
            this.btnAddSale.UseVisualStyleBackColor = true;
            // 
            // btnEditSale
            // 
            this.btnEditSale.Location = new System.Drawing.Point(15, 406);
            this.btnEditSale.Name = "btnEditSale";
            this.btnEditSale.Size = new System.Drawing.Size(209, 45);
            this.btnEditSale.TabIndex = 7;
            this.btnEditSale.Text = "Edit";
            this.btnEditSale.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSale
            // 
            this.btnRemoveSale.Location = new System.Drawing.Point(15, 469);
            this.btnRemoveSale.Name = "btnRemoveSale";
            this.btnRemoveSale.Size = new System.Drawing.Size(209, 45);
            this.btnRemoveSale.TabIndex = 7;
            this.btnRemoveSale.Text = "Remove";
            this.btnRemoveSale.UseVisualStyleBackColor = true;
            // 
            // btnRefreshSale
            // 
            this.btnRefreshSale.Location = new System.Drawing.Point(15, 22);
            this.btnRefreshSale.Name = "btnRefreshSale";
            this.btnRefreshSale.Size = new System.Drawing.Size(445, 54);
            this.btnRefreshSale.TabIndex = 0;
            this.btnRefreshSale.Text = "Refresh";
            this.btnRefreshSale.UseVisualStyleBackColor = true;
            // 
            // btnAddNewClientSale
            // 
            this.btnAddNewClientSale.Location = new System.Drawing.Point(481, 22);
            this.btnAddNewClientSale.Name = "btnAddNewClientSale";
            this.btnAddNewClientSale.Size = new System.Drawing.Size(215, 54);
            this.btnAddNewClientSale.TabIndex = 1;
            this.btnAddNewClientSale.Text = "Add New Client";
            this.btnAddNewClientSale.UseVisualStyleBackColor = true;
            // 
            // btnAddNewPropertySale
            // 
            this.btnAddNewPropertySale.Location = new System.Drawing.Point(712, 22);
            this.btnAddNewPropertySale.Name = "btnAddNewPropertySale";
            this.btnAddNewPropertySale.Size = new System.Drawing.Size(222, 54);
            this.btnAddNewPropertySale.TabIndex = 1;
            this.btnAddNewPropertySale.Text = "Add New Property";
            this.btnAddNewPropertySale.UseVisualStyleBackColor = true;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(949, 642);
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
            this.Name = "Sale";
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
    }
}