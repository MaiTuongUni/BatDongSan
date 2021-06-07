
namespace QlyBatDongSan
{
    partial class PropertyType
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdPropertyType = new System.Windows.Forms.TextBox();
            this.txtNamePropertyType = new System.Windows.Forms.TextBox();
            this.txtDescriptionPropertyType = new System.Windows.Forms.TextBox();
            this.lvPropertyType = new System.Windows.Forms.ListView();
            this.btnAddPropertyType = new System.Windows.Forms.Button();
            this.btnEditPropertyType = new System.Windows.Forms.Button();
            this.btnRemovePropertyType = new System.Windows.Forms.Button();
            this.btnRefreshPropertyType = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(949, 78);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orchid;
            this.panel2.Controls.Add(this.btnRefreshPropertyType);
            this.panel2.Controls.Add(this.btnRemovePropertyType);
            this.panel2.Controls.Add(this.btnEditPropertyType);
            this.panel2.Controls.Add(this.btnAddPropertyType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 110);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // txtIdPropertyType
            // 
            this.txtIdPropertyType.Location = new System.Drawing.Point(132, 101);
            this.txtIdPropertyType.Name = "txtIdPropertyType";
            this.txtIdPropertyType.Size = new System.Drawing.Size(336, 22);
            this.txtIdPropertyType.TabIndex = 3;
            // 
            // txtNamePropertyType
            // 
            this.txtNamePropertyType.Location = new System.Drawing.Point(132, 184);
            this.txtNamePropertyType.Name = "txtNamePropertyType";
            this.txtNamePropertyType.Size = new System.Drawing.Size(336, 22);
            this.txtNamePropertyType.TabIndex = 3;
            // 
            // txtDescriptionPropertyType
            // 
            this.txtDescriptionPropertyType.Location = new System.Drawing.Point(132, 258);
            this.txtDescriptionPropertyType.Multiline = true;
            this.txtDescriptionPropertyType.Name = "txtDescriptionPropertyType";
            this.txtDescriptionPropertyType.Size = new System.Drawing.Size(336, 231);
            this.txtDescriptionPropertyType.TabIndex = 3;
            // 
            // lvPropertyType
            // 
            this.lvPropertyType.HideSelection = false;
            this.lvPropertyType.Location = new System.Drawing.Point(538, 101);
            this.lvPropertyType.Name = "lvPropertyType";
            this.lvPropertyType.Size = new System.Drawing.Size(387, 388);
            this.lvPropertyType.TabIndex = 4;
            this.lvPropertyType.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddPropertyType
            // 
            this.btnAddPropertyType.Location = new System.Drawing.Point(35, 24);
            this.btnAddPropertyType.Name = "btnAddPropertyType";
            this.btnAddPropertyType.Size = new System.Drawing.Size(121, 58);
            this.btnAddPropertyType.TabIndex = 0;
            this.btnAddPropertyType.Text = "Add";
            this.btnAddPropertyType.UseVisualStyleBackColor = true;
            // 
            // btnEditPropertyType
            // 
            this.btnEditPropertyType.Location = new System.Drawing.Point(193, 24);
            this.btnEditPropertyType.Name = "btnEditPropertyType";
            this.btnEditPropertyType.Size = new System.Drawing.Size(121, 58);
            this.btnEditPropertyType.TabIndex = 0;
            this.btnEditPropertyType.Text = "Edit";
            this.btnEditPropertyType.UseVisualStyleBackColor = true;
            // 
            // btnRemovePropertyType
            // 
            this.btnRemovePropertyType.Location = new System.Drawing.Point(347, 24);
            this.btnRemovePropertyType.Name = "btnRemovePropertyType";
            this.btnRemovePropertyType.Size = new System.Drawing.Size(121, 58);
            this.btnRemovePropertyType.TabIndex = 0;
            this.btnRemovePropertyType.Text = "Remove";
            this.btnRemovePropertyType.UseVisualStyleBackColor = true;
            // 
            // btnRefreshPropertyType
            // 
            this.btnRefreshPropertyType.Location = new System.Drawing.Point(538, 24);
            this.btnRefreshPropertyType.Name = "btnRefreshPropertyType";
            this.btnRefreshPropertyType.Size = new System.Drawing.Size(387, 58);
            this.btnRefreshPropertyType.TabIndex = 0;
            this.btnRefreshPropertyType.Text = "Refresh";
            this.btnRefreshPropertyType.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(398, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 39);
            this.label11.TabIndex = 1;
            this.label11.Text = "Property Type";
            // 
            // PropertyType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(949, 642);
            this.Controls.Add(this.lvPropertyType);
            this.Controls.Add(this.txtDescriptionPropertyType);
            this.Controls.Add(this.txtNamePropertyType);
            this.Controls.Add(this.txtIdPropertyType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PropertyType";
            this.Text = "Property Type";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddPropertyType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdPropertyType;
        private System.Windows.Forms.TextBox txtNamePropertyType;
        private System.Windows.Forms.TextBox txtDescriptionPropertyType;
        private System.Windows.Forms.ListView lvPropertyType;
        private System.Windows.Forms.Button btnRefreshPropertyType;
        private System.Windows.Forms.Button btnRemovePropertyType;
        private System.Windows.Forms.Button btnEditPropertyType;
        private System.Windows.Forms.Label label11;
    }
}