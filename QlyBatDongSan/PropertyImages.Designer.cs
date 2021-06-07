
namespace QlyBatDongSan
{
    partial class PropertyImages
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
            this.btnAddPropertyImages = new System.Windows.Forms.Button();
            this.btnRemovePropertyImages = new System.Windows.Forms.Button();
            this.btnShowThisPropertyImages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectAType = new System.Windows.Forms.ComboBox();
            this.lvLeftPropertyImages = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMiddlePropertyImages = new System.Windows.Forms.ListView();
            this.pcPropertyImages = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowsePropertyImages = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPropertyImages)).BeginInit();
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
            this.label11.Location = new System.Drawing.Point(349, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(281, 39);
            this.label11.TabIndex = 1;
            this.label11.Text = "Property Images";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddPropertyImages);
            this.panel2.Controls.Add(this.btnRemovePropertyImages);
            this.panel2.Controls.Add(this.btnShowThisPropertyImages);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 532);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 110);
            this.panel2.TabIndex = 1;
            // 
            // btnAddPropertyImages
            // 
            this.btnAddPropertyImages.Location = new System.Drawing.Point(635, 31);
            this.btnAddPropertyImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPropertyImages.Name = "btnAddPropertyImages";
            this.btnAddPropertyImages.Size = new System.Drawing.Size(301, 55);
            this.btnAddPropertyImages.TabIndex = 0;
            this.btnAddPropertyImages.Text = "Add";
            this.btnAddPropertyImages.UseVisualStyleBackColor = true;
            this.btnAddPropertyImages.Click += new System.EventHandler(this.btnAddPropertyImages_Click);
            // 
            // btnRemovePropertyImages
            // 
            this.btnRemovePropertyImages.Location = new System.Drawing.Point(325, 31);
            this.btnRemovePropertyImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemovePropertyImages.Name = "btnRemovePropertyImages";
            this.btnRemovePropertyImages.Size = new System.Drawing.Size(285, 55);
            this.btnRemovePropertyImages.TabIndex = 0;
            this.btnRemovePropertyImages.Text = "Remove";
            this.btnRemovePropertyImages.UseVisualStyleBackColor = true;
            this.btnRemovePropertyImages.Click += new System.EventHandler(this.btnRemovePropertyImages_Click);
            // 
            // btnShowThisPropertyImages
            // 
            this.btnShowThisPropertyImages.Location = new System.Drawing.Point(15, 31);
            this.btnShowThisPropertyImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowThisPropertyImages.Name = "btnShowThisPropertyImages";
            this.btnShowThisPropertyImages.Size = new System.Drawing.Size(285, 55);
            this.btnShowThisPropertyImages.TabIndex = 0;
            this.btnShowThisPropertyImages.Text = "Show This Property Images";
            this.btnShowThisPropertyImages.UseVisualStyleBackColor = true;
            this.btnShowThisPropertyImages.Click += new System.EventHandler(this.btnShowThisPropertyImages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select A Type:";
            // 
            // cbSelectAType
            // 
            this.cbSelectAType.FormattingEnabled = true;
            this.cbSelectAType.Location = new System.Drawing.Point(117, 90);
            this.cbSelectAType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSelectAType.Name = "cbSelectAType";
            this.cbSelectAType.Size = new System.Drawing.Size(183, 24);
            this.cbSelectAType.TabIndex = 3;
            this.cbSelectAType.SelectedIndexChanged += new System.EventHandler(this.cbSelectAType_SelectedIndexChanged);
            // 
            // lvLeftPropertyImages
            // 
            this.lvLeftPropertyImages.AllowColumnReorder = true;
            this.lvLeftPropertyImages.AllowDrop = true;
            this.lvLeftPropertyImages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.address});
            this.lvLeftPropertyImages.FullRowSelect = true;
            this.lvLeftPropertyImages.HideSelection = false;
            this.lvLeftPropertyImages.Location = new System.Drawing.Point(15, 134);
            this.lvLeftPropertyImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvLeftPropertyImages.Name = "lvLeftPropertyImages";
            this.lvLeftPropertyImages.Size = new System.Drawing.Size(285, 354);
            this.lvLeftPropertyImages.TabIndex = 4;
            this.lvLeftPropertyImages.UseCompatibleStateImageBehavior = false;
            this.lvLeftPropertyImages.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 150;
            // 
            // lvMiddlePropertyImages
            // 
            this.lvMiddlePropertyImages.FullRowSelect = true;
            this.lvMiddlePropertyImages.HideSelection = false;
            this.lvMiddlePropertyImages.Location = new System.Drawing.Point(325, 134);
            this.lvMiddlePropertyImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvMiddlePropertyImages.MultiSelect = false;
            this.lvMiddlePropertyImages.Name = "lvMiddlePropertyImages";
            this.lvMiddlePropertyImages.Size = new System.Drawing.Size(285, 354);
            this.lvMiddlePropertyImages.TabIndex = 4;
            this.lvMiddlePropertyImages.UseCompatibleStateImageBehavior = false;
            this.lvMiddlePropertyImages.DoubleClick += new System.EventHandler(this.lvMiddlePropertyImages_DoubleClick);
            // 
            // pcPropertyImages
            // 
            this.pcPropertyImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcPropertyImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcPropertyImages.Location = new System.Drawing.Point(635, 134);
            this.pcPropertyImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcPropertyImages.Name = "pcPropertyImages";
            this.pcPropertyImages.Size = new System.Drawing.Size(301, 353);
            this.pcPropertyImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcPropertyImages.TabIndex = 5;
            this.pcPropertyImages.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Image:";
            // 
            // btnBrowsePropertyImages
            // 
            this.btnBrowsePropertyImages.Location = new System.Drawing.Point(731, 82);
            this.btnBrowsePropertyImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowsePropertyImages.Name = "btnBrowsePropertyImages";
            this.btnBrowsePropertyImages.Size = new System.Drawing.Size(83, 32);
            this.btnBrowsePropertyImages.TabIndex = 6;
            this.btnBrowsePropertyImages.Text = "Browse";
            this.btnBrowsePropertyImages.UseVisualStyleBackColor = true;
            this.btnBrowsePropertyImages.Click += new System.EventHandler(this.btnBrowsePropertyImages_Click);
            // 
            // PropertyImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(949, 642);
            this.Controls.Add(this.btnBrowsePropertyImages);
            this.Controls.Add(this.pcPropertyImages);
            this.Controls.Add(this.lvMiddlePropertyImages);
            this.Controls.Add(this.lvLeftPropertyImages);
            this.Controls.Add(this.cbSelectAType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PropertyImages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Property Images";
            this.Load += new System.EventHandler(this.PropertyImages_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcPropertyImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddPropertyImages;
        private System.Windows.Forms.Button btnRemovePropertyImages;
        private System.Windows.Forms.Button btnShowThisPropertyImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectAType;
        private System.Windows.Forms.ListView lvLeftPropertyImages;
        private System.Windows.Forms.ListView lvMiddlePropertyImages;
        private System.Windows.Forms.PictureBox pcPropertyImages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowsePropertyImages;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader address;
    }
}