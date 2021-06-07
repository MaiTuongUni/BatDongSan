
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
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.lvClients = new System.Windows.Forms.ListView();
            this.btnAddClients = new System.Windows.Forms.Button();
            this.btnEditClients = new System.Windows.Forms.Button();
            this.btnRemoveClients = new System.Windows.Forms.Button();
            this.btnRefreshClients = new System.Windows.Forms.Button();
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
            this.panel2.Controls.Add(this.btnRefreshClients);
            this.panel2.Controls.Add(this.btnRemoveClients);
            this.panel2.Controls.Add(this.btnEditClients);
            this.panel2.Controls.Add(this.btnAddClients);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 110);
            this.panel2.TabIndex = 1;
            // 
            // txtAddressClients
            // 
            this.txtAddressClients.Location = new System.Drawing.Point(112, 372);
            this.txtAddressClients.Multiline = true;
            this.txtAddressClients.Name = "txtAddressClients";
            this.txtAddressClients.Size = new System.Drawing.Size(260, 131);
            this.txtAddressClients.TabIndex = 10;
            // 
            // txtEmailClients
            // 
            this.txtEmailClients.Location = new System.Drawing.Point(112, 321);
            this.txtEmailClients.Name = "txtEmailClients";
            this.txtEmailClients.Size = new System.Drawing.Size(260, 22);
            this.txtEmailClients.TabIndex = 11;
            // 
            // txtPhoneClients
            // 
            this.txtPhoneClients.Location = new System.Drawing.Point(112, 261);
            this.txtPhoneClients.Name = "txtPhoneClients";
            this.txtPhoneClients.Size = new System.Drawing.Size(260, 22);
            this.txtPhoneClients.TabIndex = 12;
            // 
            // txtLastNameClients
            // 
            this.txtLastNameClients.Location = new System.Drawing.Point(112, 209);
            this.txtLastNameClients.Name = "txtLastNameClients";
            this.txtLastNameClients.Size = new System.Drawing.Size(260, 22);
            this.txtLastNameClients.TabIndex = 13;
            // 
            // txtFirstNameClients
            // 
            this.txtFirstNameClients.Location = new System.Drawing.Point(112, 157);
            this.txtFirstNameClients.Name = "txtFirstNameClients";
            this.txtFirstNameClients.Size = new System.Drawing.Size(260, 22);
            this.txtFirstNameClients.TabIndex = 14;
            // 
            // txtIDClients
            // 
            this.txtIDClients.Location = new System.Drawing.Point(112, 100);
            this.txtIDClients.Name = "txtIDClients";
            this.txtIDClients.Size = new System.Drawing.Size(260, 22);
            this.txtIDClients.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "LastName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "FirstName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID:";
            // 
            // lvClients
            // 
            this.lvClients.HideSelection = false;
            this.lvClients.Location = new System.Drawing.Point(456, 100);
            this.lvClients.Name = "lvClients";
            this.lvClients.Size = new System.Drawing.Size(469, 403);
            this.lvClients.TabIndex = 16;
            this.lvClients.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddClients
            // 
            this.btnAddClients.Location = new System.Drawing.Point(20, 23);
            this.btnAddClients.Name = "btnAddClients";
            this.btnAddClients.Size = new System.Drawing.Size(157, 58);
            this.btnAddClients.TabIndex = 1;
            this.btnAddClients.Text = "Add";
            this.btnAddClients.UseVisualStyleBackColor = true;
            // 
            // btnEditClients
            // 
            this.btnEditClients.Location = new System.Drawing.Point(215, 23);
            this.btnEditClients.Name = "btnEditClients";
            this.btnEditClients.Size = new System.Drawing.Size(157, 58);
            this.btnEditClients.TabIndex = 1;
            this.btnEditClients.Text = "Edit";
            this.btnEditClients.UseVisualStyleBackColor = true;
            // 
            // btnRemoveClients
            // 
            this.btnRemoveClients.Location = new System.Drawing.Point(456, 23);
            this.btnRemoveClients.Name = "btnRemoveClients";
            this.btnRemoveClients.Size = new System.Drawing.Size(157, 58);
            this.btnRemoveClients.TabIndex = 1;
            this.btnRemoveClients.Text = "Remove";
            this.btnRemoveClients.UseVisualStyleBackColor = true;
            // 
            // btnRefreshClients
            // 
            this.btnRefreshClients.Location = new System.Drawing.Point(635, 23);
            this.btnRefreshClients.Name = "btnRefreshClients";
            this.btnRefreshClients.Size = new System.Drawing.Size(290, 58);
            this.btnRefreshClients.TabIndex = 1;
            this.btnRefreshClients.Text = "Refresh";
            this.btnRefreshClients.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(394, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 39);
            this.label11.TabIndex = 2;
            this.label11.Text = "Clients";
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(949, 642);
            this.Controls.Add(this.lvClients);
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
        private System.Windows.Forms.ListView lvClients;
        private System.Windows.Forms.Button btnRefreshClients;
        private System.Windows.Forms.Button btnRemoveClients;
        private System.Windows.Forms.Button btnEditClients;
        private System.Windows.Forms.Button btnAddClients;
        private System.Windows.Forms.Label label11;
    }
}