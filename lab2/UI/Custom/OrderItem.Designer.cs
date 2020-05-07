namespace netFrameworkProject.UI.Custom
{
    partial class OrderItem
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.orderImage = new System.Windows.Forms.PictureBox();
            this.orderBrandLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.orderModelLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.orderPriceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.applyButton = new MaterialSkin.Controls.MaterialButton();
            this.declineButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.orderUserName = new MaterialSkin.Controls.MaterialLabel();
            this.OrderUserId = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)(this.orderImage)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(229, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 29);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Brand :";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // orderImage
            // 
            this.orderImage.Location = new System.Drawing.Point(17, 21);
            this.orderImage.Name = "orderImage";
            this.orderImage.Size = new System.Drawing.Size(190, 190);
            this.orderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orderImage.TabIndex = 0;
            this.orderImage.TabStop = false;
            // 
            // orderBrandLabel
            // 
            this.orderBrandLabel.AutoSize = true;
            this.orderBrandLabel.Depth = 0;
            this.orderBrandLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.orderBrandLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.orderBrandLabel.Location = new System.Drawing.Point(323, 31);
            this.orderBrandLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.orderBrandLabel.Name = "orderBrandLabel";
            this.orderBrandLabel.Size = new System.Drawing.Size(160, 29);
            this.orderBrandLabel.TabIndex = 1;
            this.orderBrandLabel.Text = "materialLabel1";
            this.orderBrandLabel.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(229, 79);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(81, 29);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Model :";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // orderModelLabel
            // 
            this.orderModelLabel.AutoSize = true;
            this.orderModelLabel.Depth = 0;
            this.orderModelLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.orderModelLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.orderModelLabel.Location = new System.Drawing.Point(323, 79);
            this.orderModelLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.orderModelLabel.Name = "orderModelLabel";
            this.orderModelLabel.Size = new System.Drawing.Size(160, 29);
            this.orderModelLabel.TabIndex = 1;
            this.orderModelLabel.Text = "materialLabel1";
            this.orderModelLabel.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel5.Location = new System.Drawing.Point(228, 157);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(94, 41);
            this.materialLabel5.TabIndex = 1;
            this.materialLabel5.Text = "Price :";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // orderPriceLabel
            // 
            this.orderPriceLabel.AutoSize = true;
            this.orderPriceLabel.Depth = 0;
            this.orderPriceLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.orderPriceLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.orderPriceLabel.Location = new System.Drawing.Point(339, 157);
            this.orderPriceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.orderPriceLabel.Name = "orderPriceLabel";
            this.orderPriceLabel.Size = new System.Drawing.Size(227, 41);
            this.orderPriceLabel.TabIndex = 1;
            this.orderPriceLabel.Text = "materialLabel1";
            this.orderPriceLabel.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel7.Location = new System.Drawing.Point(668, 14);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(56, 29);
            this.materialLabel7.TabIndex = 1;
            this.materialLabel7.Text = "User ";
            this.materialLabel7.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel8.Location = new System.Drawing.Point(671, 60);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialLabel8.Size = new System.Drawing.Size(59, 24);
            this.materialLabel8.TabIndex = 1;
            this.materialLabel8.Text = "Name:";
            this.materialLabel8.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // applyButton
            // 
            this.applyButton.AutoSize = false;
            this.applyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applyButton.Depth = 0;
            this.applyButton.DrawShadows = true;
            this.applyButton.HighEmphasis = true;
            this.applyButton.Icon = null;
            this.applyButton.Location = new System.Drawing.Point(809, 169);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.applyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(173, 42);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "apply";
            this.applyButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.applyButton.UseAccentColor = false;
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // declineButton
            // 
            this.declineButton.AutoSize = false;
            this.declineButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.declineButton.Depth = 0;
            this.declineButton.DrawShadows = true;
            this.declineButton.HighEmphasis = true;
            this.declineButton.Icon = null;
            this.declineButton.Location = new System.Drawing.Point(615, 169);
            this.declineButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.declineButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(186, 42);
            this.declineButton.TabIndex = 2;
            this.declineButton.Text = "decline";
            this.declineButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.declineButton.UseAccentColor = false;
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel9.Location = new System.Drawing.Point(671, 91);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialLabel9.Size = new System.Drawing.Size(80, 24);
            this.materialLabel9.TabIndex = 1;
            this.materialLabel9.Text = "Bank ID :";
            this.materialLabel9.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // orderUserName
            // 
            this.orderUserName.AutoSize = true;
            this.orderUserName.Depth = 0;
            this.orderUserName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.orderUserName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.orderUserName.Location = new System.Drawing.Point(775, 60);
            this.orderUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.orderUserName.Name = "orderUserName";
            this.orderUserName.Size = new System.Drawing.Size(135, 24);
            this.orderUserName.TabIndex = 1;
            this.orderUserName.Text = "materialLabel1";
            this.orderUserName.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // OrderUserId
            // 
            this.OrderUserId.AutoSize = true;
            this.OrderUserId.Depth = 0;
            this.OrderUserId.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.OrderUserId.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.OrderUserId.Location = new System.Drawing.Point(775, 91);
            this.OrderUserId.MouseState = MaterialSkin.MouseState.HOVER;
            this.OrderUserId.Name = "OrderUserId";
            this.OrderUserId.Size = new System.Drawing.Size(135, 24);
            this.OrderUserId.TabIndex = 1;
            this.OrderUserId.Text = "materialLabel1";
            this.OrderUserId.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.declineButton);
            this.materialCard1.Controls.Add(this.applyButton);
            this.materialCard1.Controls.Add(this.orderPriceLabel);
            this.materialCard1.Controls.Add(this.orderModelLabel);
            this.materialCard1.Controls.Add(this.materialLabel9);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Controls.Add(this.OrderUserId);
            this.materialCard1.Controls.Add(this.orderUserName);
            this.materialCard1.Controls.Add(this.orderBrandLabel);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.materialLabel7);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.orderImage);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1060, 231);
            this.materialCard1.TabIndex = 3;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Name = "OrderItem";
            this.Size = new System.Drawing.Size(1060, 231);
            this.Load += new System.EventHandler(this.OrderItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderImage)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox orderImage;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel orderBrandLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel orderModelLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel orderPriceLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialButton applyButton;
        private MaterialSkin.Controls.MaterialButton declineButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel orderUserName;
        private MaterialSkin.Controls.MaterialLabel OrderUserId;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}
