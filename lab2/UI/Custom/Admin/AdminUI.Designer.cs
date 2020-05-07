namespace netFrameworkProject.UI.Custom.Admin
{
    partial class AdminUI
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.carList = new System.Windows.Forms.TabPage();
            this.addToListButton = new MaterialSkin.Controls.MaterialButton();
            this.ItemView = new MaterialSkin.Controls.MaterialCard();
            this.priceTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.modelTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.brandTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.deleteButton = new MaterialSkin.Controls.MaterialButton();
            this.addButton = new MaterialSkin.Controls.MaterialButton();
            this.commentTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.ItemList = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.orderList = new System.Windows.Forms.FlowLayoutPanel();
            this.image = new System.Windows.Forms.PictureBox();
            this.materialTabControl1.SuspendLayout();
            this.carList.SuspendLayout();
            this.ItemView.SuspendLayout();
            this.ItemList.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1100, 48);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.carList);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 46);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1100, 614);
            this.materialTabControl1.TabIndex = 2;
            // 
            // carList
            // 
            this.carList.BackColor = System.Drawing.SystemColors.Control;
            this.carList.Controls.Add(this.addToListButton);
            this.carList.Controls.Add(this.ItemView);
            this.carList.Controls.Add(this.ItemList);
            this.carList.Location = new System.Drawing.Point(4, 22);
            this.carList.Name = "carList";
            this.carList.Padding = new System.Windows.Forms.Padding(3);
            this.carList.Size = new System.Drawing.Size(1092, 588);
            this.carList.TabIndex = 0;
            this.carList.Text = "CarSharing";
            this.carList.Click += new System.EventHandler(this.carList_Click);
            // 
            // addToListButton
            // 
            this.addToListButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addToListButton.Depth = 0;
            this.addToListButton.DrawShadows = true;
            this.addToListButton.HighEmphasis = true;
            this.addToListButton.Icon = null;
            this.addToListButton.Location = new System.Drawing.Point(922, 546);
            this.addToListButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addToListButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(139, 36);
            this.addToListButton.TabIndex = 4;
            this.addToListButton.Text = "add car to list";
            this.addToListButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.addToListButton.UseAccentColor = false;
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // ItemView
            // 
            this.ItemView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ItemView.Controls.Add(this.priceTextBox);
            this.ItemView.Controls.Add(this.modelTextBox);
            this.ItemView.Controls.Add(this.brandTextBox);
            this.ItemView.Controls.Add(this.deleteButton);
            this.ItemView.Controls.Add(this.addButton);
            this.ItemView.Controls.Add(this.commentTextBox);
            this.ItemView.Controls.Add(this.image);
            this.ItemView.Controls.Add(this.materialLabel2);
            this.ItemView.Controls.Add(this.materialLabel4);
            this.ItemView.Controls.Add(this.materialLabel3);
            this.ItemView.Controls.Add(this.materialLabel6);
            this.ItemView.Depth = 0;
            this.ItemView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ItemView.Location = new System.Drawing.Point(746, 17);
            this.ItemView.Margin = new System.Windows.Forms.Padding(14);
            this.ItemView.MouseState = MaterialSkin.MouseState.HOVER;
            this.ItemView.Name = "ItemView";
            this.ItemView.Padding = new System.Windows.Forms.Padding(14);
            this.ItemView.Size = new System.Drawing.Size(295, 518);
            this.ItemView.TabIndex = 3;
            this.ItemView.Visible = false;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTextBox.Depth = 0;
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.priceTextBox.Hint = "Price";
            this.priceTextBox.Location = new System.Drawing.Point(46, 403);
            this.priceTextBox.MaxLength = 50;
            this.priceTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.priceTextBox.Multiline = false;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(207, 50);
            this.priceTextBox.TabIndex = 7;
            this.priceTextBox.Text = "";
            // 
            // modelTextBox
            // 
            this.modelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelTextBox.Depth = 0;
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modelTextBox.Hint = "Model";
            this.modelTextBox.Location = new System.Drawing.Point(43, 268);
            this.modelTextBox.MaxLength = 50;
            this.modelTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.modelTextBox.Multiline = false;
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(210, 50);
            this.modelTextBox.TabIndex = 6;
            this.modelTextBox.Text = "";
            // 
            // brandTextBox
            // 
            this.brandTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.brandTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.brandTextBox.Depth = 0;
            this.brandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.brandTextBox.Hint = "Brand";
            this.brandTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.brandTextBox.Location = new System.Drawing.Point(43, 212);
            this.brandTextBox.MaxLength = 50;
            this.brandTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.brandTextBox.Multiline = false;
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(212, 50);
            this.brandTextBox.TabIndex = 5;
            this.brandTextBox.Text = "";
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Depth = 0;
            this.deleteButton.DrawShadows = true;
            this.deleteButton.HighEmphasis = true;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(174, 471);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(73, 36);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "delete";
            this.deleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.deleteButton.UseAccentColor = false;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // addButton
            // 
            this.addButton.AutoSize = false;
            this.addButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addButton.Depth = 0;
            this.addButton.DrawShadows = true;
            this.addButton.HighEmphasis = true;
            this.addButton.Icon = null;
            this.addButton.Location = new System.Drawing.Point(43, 470);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(123, 38);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "add / edit";
            this.addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addButton.UseAccentColor = false;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // commentTextBox
            // 
            this.commentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.commentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentTextBox.Depth = 0;
            this.commentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.commentTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.commentTextBox.Hint = "comment";
            this.commentTextBox.Location = new System.Drawing.Point(43, 343);
            this.commentTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(212, 49);
            this.commentTextBox.TabIndex = 3;
            this.commentTextBox.Text = "";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(47, 227);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Brand :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(47, 321);
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
            this.materialLabel3.Location = new System.Drawing.Point(47, 281);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(53, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Model :";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel6.Location = new System.Drawing.Point(45, 408);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(68, 29);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "Price :";
            // 
            // ItemList
            // 
            this.ItemList.AutoScroll = true;
            this.ItemList.BackColor = System.Drawing.Color.Transparent;
            this.ItemList.Controls.Add(this.materialLabel1);
            this.ItemList.Location = new System.Drawing.Point(14, 11);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(1046, 527);
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
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.orderList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1092, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            // 
            // orderList
            // 
            this.orderList.AutoScroll = true;
            this.orderList.Location = new System.Drawing.Point(8, 6);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(1078, 576);
            this.orderList.TabIndex = 0;
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Image = global::netFrameworkProject.Properties.Resources.f1_3;
            this.image.Location = new System.Drawing.Point(48, 12);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(200, 180);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "AdminUI";
            this.Size = new System.Drawing.Size(1100, 660);
            this.materialTabControl1.ResumeLayout(false);
            this.carList.ResumeLayout(false);
            this.carList.PerformLayout();
            this.ItemView.ResumeLayout(false);
            this.ItemView.PerformLayout();
            this.ItemList.ResumeLayout(false);
            this.ItemList.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage carList;
        private MaterialSkin.Controls.MaterialCard ItemView;
        private MaterialSkin.Controls.MaterialButton addButton;
        private System.Windows.Forms.PictureBox image;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.FlowLayoutPanel ItemList;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTextBox priceTextBox;
        private MaterialSkin.Controls.MaterialTextBox modelTextBox;
        private MaterialSkin.Controls.MaterialTextBox brandTextBox;
        private MaterialSkin.Controls.MaterialButton deleteButton;
        private MaterialSkin.Controls.MaterialMultiLineTextBox commentTextBox;
        private MaterialSkin.Controls.MaterialButton addToListButton;
        private System.Windows.Forms.FlowLayoutPanel orderList;
    }
}
