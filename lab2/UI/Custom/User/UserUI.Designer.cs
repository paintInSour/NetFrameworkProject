namespace lab2.UI.Custom.User
{
    partial class UserUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.carList = new System.Windows.Forms.TabPage();
            this.ItemView = new MaterialSkin.Controls.MaterialCard();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.image = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.commentLabel = new MaterialSkin.Controls.MaterialLabel();
            this.brandLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.pricaLabel = new MaterialSkin.Controls.MaterialLabel();
            this.modelLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.ItemList = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.carList.SuspendLayout();
            this.ItemView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.ItemList.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.carList);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 90);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1100, 609);
            this.materialTabControl1.TabIndex = 0;
            // 
            // carList
            // 
            this.carList.BackColor = System.Drawing.SystemColors.Control;
            this.carList.Controls.Add(this.ItemView);
            this.carList.Controls.Add(this.ItemList);
            this.carList.Location = new System.Drawing.Point(4, 22);
            this.carList.Name = "carList";
            this.carList.Padding = new System.Windows.Forms.Padding(3);
            this.carList.Size = new System.Drawing.Size(1092, 583);
            this.carList.TabIndex = 0;
            this.carList.Text = "CarSharing";
            this.carList.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ItemView
            // 
            this.ItemView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ItemView.Controls.Add(this.materialButton1);
            this.ItemView.Controls.Add(this.image);
            this.ItemView.Controls.Add(this.materialLabel2);
            this.ItemView.Controls.Add(this.commentLabel);
            this.ItemView.Controls.Add(this.brandLabel);
            this.ItemView.Controls.Add(this.materialLabel4);
            this.ItemView.Controls.Add(this.materialLabel3);
            this.ItemView.Controls.Add(this.pricaLabel);
            this.ItemView.Controls.Add(this.modelLabel);
            this.ItemView.Controls.Add(this.materialLabel6);
            this.ItemView.Depth = 0;
            this.ItemView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ItemView.Location = new System.Drawing.Point(780, 11);
            this.ItemView.Margin = new System.Windows.Forms.Padding(14);
            this.ItemView.MouseState = MaterialSkin.MouseState.HOVER;
            this.ItemView.Name = "ItemView";
            this.ItemView.Padding = new System.Windows.Forms.Padding(14);
            this.ItemView.Size = new System.Drawing.Size(295, 518);
            this.ItemView.TabIndex = 3;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(43, 454);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(194, 38);
            this.materialButton1.TabIndex = 3;
            this.materialButton1.Text = "Rent";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(36, 17);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(219, 186);
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(47, 220);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Brand :";
            // 
            // commentLabel
            // 
            this.commentLabel.AllowDrop = true;
            this.commentLabel.Depth = 0;
            this.commentLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.commentLabel.Location = new System.Drawing.Point(48, 330);
            this.commentLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(189, 77);
            this.commentLabel.TabIndex = 2;
            this.commentLabel.Text = "Comment :";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Depth = 0;
            this.brandLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.brandLabel.Location = new System.Drawing.Point(104, 220);
            this.brandLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(51, 19);
            this.brandLabel.TabIndex = 2;
            this.brandLabel.Text = "Brand :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(47, 302);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(78, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Comment :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(49, 262);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(53, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Model :";
            // 
            // pricaLabel
            // 
            this.pricaLabel.AllowDrop = true;
            this.pricaLabel.AutoSize = true;
            this.pricaLabel.Depth = 0;
            this.pricaLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.pricaLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.pricaLabel.Location = new System.Drawing.Point(118, 419);
            this.pricaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pricaLabel.Name = "pricaLabel";
            this.pricaLabel.Size = new System.Drawing.Size(53, 29);
            this.pricaLabel.TabIndex = 2;
            this.pricaLabel.Text = "1000";
            // 
            // modelLabel
            // 
            this.modelLabel.AllowDrop = true;
            this.modelLabel.AutoSize = true;
            this.modelLabel.Depth = 0;
            this.modelLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.modelLabel.Location = new System.Drawing.Point(104, 262);
            this.modelLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(45, 19);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "model";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel6.Location = new System.Drawing.Point(45, 419);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(68, 29);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "Price :";
            // 
            // ItemList
            // 
            this.ItemList.Controls.Add(this.materialLabel1);
            this.ItemList.Location = new System.Drawing.Point(22, 11);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(725, 527);
            this.ItemList.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(1, 0);
            this.materialLabel1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1092, 583);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1100, 67);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // UserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "UserUI";
            this.Size = new System.Drawing.Size(1100, 699);
            this.materialTabControl1.ResumeLayout(false);
            this.carList.ResumeLayout(false);
            this.ItemView.ResumeLayout(false);
            this.ItemView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ItemList.ResumeLayout(false);
            this.ItemList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage carList;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.FlowLayoutPanel ItemList;
        private MaterialSkin.Controls.MaterialCard ItemView;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel commentLabel;
        private MaterialSkin.Controls.MaterialLabel brandLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel pricaLabel;
        private MaterialSkin.Controls.MaterialLabel modelLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}
