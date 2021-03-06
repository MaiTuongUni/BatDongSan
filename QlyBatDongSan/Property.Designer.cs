
namespace QlyBatDongSan
{
    partial class Property
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
            this.btnRemoveProperty = new System.Windows.Forms.Button();
            this.btnEditProperty = new System.Windows.Forms.Button();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtOwnerId = new System.Windows.Forms.TextBox();
            this.txtQuareFeet = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbGarage = new System.Windows.Forms.CheckBox();
            this.cbBackyard = new System.Windows.Forms.CheckBox();
            this.cbPool = new System.Windows.Forms.CheckBox();
            this.cbBalcony = new System.Windows.Forms.CheckBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.numBathroom = new System.Windows.Forms.NumericUpDown();
            this.numBedroom = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBathroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBedroom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Magenta;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 78);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(421, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 39);
            this.label11.TabIndex = 0;
            this.label11.Text = "Property";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orchid;
            this.panel2.Controls.Add(this.btnRemoveProperty);
            this.panel2.Controls.Add(this.btnEditProperty);
            this.panel2.Controls.Add(this.btnAddProperty);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 532);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 110);
            this.panel2.TabIndex = 1;
            // 
            // btnRemoveProperty
            // 
            this.btnRemoveProperty.Location = new System.Drawing.Point(508, 26);
            this.btnRemoveProperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveProperty.Name = "btnRemoveProperty";
            this.btnRemoveProperty.Size = new System.Drawing.Size(121, 58);
            this.btnRemoveProperty.TabIndex = 0;
            this.btnRemoveProperty.Text = "Remove";
            this.btnRemoveProperty.UseVisualStyleBackColor = true;
            this.btnRemoveProperty.Click += new System.EventHandler(this.btnRemoveProperty_Click);
            // 
            // btnEditProperty
            // 
            this.btnEditProperty.Location = new System.Drawing.Point(297, 26);
            this.btnEditProperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditProperty.Name = "btnEditProperty";
            this.btnEditProperty.Size = new System.Drawing.Size(121, 58);
            this.btnEditProperty.TabIndex = 0;
            this.btnEditProperty.Text = "Edit";
            this.btnEditProperty.UseVisualStyleBackColor = true;
            this.btnEditProperty.Click += new System.EventHandler(this.btnEditProperty_Click);
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(88, 26);
            this.btnAddProperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(121, 58);
            this.btnAddProperty.TabIndex = 0;
            this.btnAddProperty.Text = "Add";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orchid;
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.txtOwnerId);
            this.panel3.Controls.Add(this.txtQuareFeet);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.cbbType);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 78);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 454);
            this.panel3.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(121, 292);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(293, 116);
            this.txtAddress.TabIndex = 28;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(121, 242);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(293, 22);
            this.txtPrice.TabIndex = 26;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtOwnerId
            // 
            this.txtOwnerId.Location = new System.Drawing.Point(121, 190);
            this.txtOwnerId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOwnerId.Name = "txtOwnerId";
            this.txtOwnerId.Size = new System.Drawing.Size(293, 22);
            this.txtOwnerId.TabIndex = 27;
            // 
            // txtQuareFeet
            // 
            this.txtQuareFeet.Location = new System.Drawing.Point(121, 134);
            this.txtQuareFeet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuareFeet.Name = "txtQuareFeet";
            this.txtQuareFeet.Size = new System.Drawing.Size(293, 22);
            this.txtQuareFeet.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.OldLace;
            this.btnSearch.Location = new System.Drawing.Point(340, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 32);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(121, 75);
            this.cbbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(293, 24);
            this.cbbType.TabIndex = 23;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(121, 21);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(191, 22);
            this.txtId.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Price ($):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Owner ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Square feet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orchid;
            this.panel4.Controls.Add(this.txtDescription);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.cbGarage);
            this.panel4.Controls.Add(this.cbBackyard);
            this.panel4.Controls.Add(this.cbPool);
            this.panel4.Controls.Add(this.cbBalcony);
            this.panel4.Controls.Add(this.numAge);
            this.panel4.Controls.Add(this.numBathroom);
            this.panel4.Controls.Add(this.numBedroom);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(490, 78);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 454);
            this.panel4.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(21, 217);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 191);
            this.txtDescription.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Description/Comment:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Age of the house (*):";
            // 
            // cbGarage
            // 
            this.cbGarage.AutoSize = true;
            this.cbGarage.Location = new System.Drawing.Point(332, 170);
            this.cbGarage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGarage.Name = "cbGarage";
            this.cbGarage.Size = new System.Drawing.Size(78, 21);
            this.cbGarage.TabIndex = 2;
            this.cbGarage.Text = "Garage";
            this.cbGarage.UseVisualStyleBackColor = true;
            // 
            // cbBackyard
            // 
            this.cbBackyard.AutoSize = true;
            this.cbBackyard.Location = new System.Drawing.Point(332, 118);
            this.cbBackyard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBackyard.Name = "cbBackyard";
            this.cbBackyard.Size = new System.Drawing.Size(89, 21);
            this.cbBackyard.TabIndex = 2;
            this.cbBackyard.Text = "Backyard";
            this.cbBackyard.UseVisualStyleBackColor = true;
            // 
            // cbPool
            // 
            this.cbPool.AutoSize = true;
            this.cbPool.Location = new System.Drawing.Point(332, 71);
            this.cbPool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPool.Name = "cbPool";
            this.cbPool.Size = new System.Drawing.Size(58, 21);
            this.cbPool.TabIndex = 2;
            this.cbPool.Text = "Pool";
            this.cbPool.UseVisualStyleBackColor = true;
            // 
            // cbBalcony
            // 
            this.cbBalcony.AutoSize = true;
            this.cbBalcony.Location = new System.Drawing.Point(332, 20);
            this.cbBalcony.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBalcony.Name = "cbBalcony";
            this.cbBalcony.Size = new System.Drawing.Size(80, 21);
            this.cbBalcony.TabIndex = 2;
            this.cbBalcony.Text = "Balcony";
            this.cbBalcony.UseVisualStyleBackColor = true;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(163, 116);
            this.numAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(139, 22);
            this.numAge.TabIndex = 1;
            // 
            // numBathroom
            // 
            this.numBathroom.Location = new System.Drawing.Point(163, 70);
            this.numBathroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numBathroom.Name = "numBathroom";
            this.numBathroom.Size = new System.Drawing.Size(139, 22);
            this.numBathroom.TabIndex = 1;
            // 
            // numBedroom
            // 
            this.numBedroom.Location = new System.Drawing.Point(163, 18);
            this.numBedroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numBedroom.Name = "numBedroom";
            this.numBedroom.Size = new System.Drawing.Size(139, 22);
            this.numBedroom.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bathrooms:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bedrooms:";
            // 
            // Property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 642);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Property";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Property";
            this.Load += new System.EventHandler(this.Property_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBathroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBedroom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtOwnerId;
        private System.Windows.Forms.TextBox txtQuareFeet;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbBackyard;
        private System.Windows.Forms.CheckBox cbPool;
        private System.Windows.Forms.CheckBox cbBalcony;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.NumericUpDown numBathroom;
        private System.Windows.Forms.NumericUpDown numBedroom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbGarage;
        private System.Windows.Forms.Button btnRemoveProperty;
        private System.Windows.Forms.Button btnEditProperty;
        private System.Windows.Forms.Button btnAddProperty;
    }
}