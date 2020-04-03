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
            this.noOrderCard = new MaterialSkin.Controls.MaterialCard();
            this.noOrder = new MaterialSkin.Controls.MaterialLabel();
            this.orderCard = new MaterialSkin.Controls.MaterialCard();
            this.orderReturn = new MaterialSkin.Controls.MaterialButton();
            this.orderCommentLabel = new MaterialSkin.Controls.MaterialLabel();
            this.orderModelLabel = new MaterialSkin.Controls.MaterialLabel();
            this.orderBrandLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.orderImage = new System.Windows.Forms.PictureBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.startDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.endDateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.carList.SuspendLayout();
            this.ItemView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.ItemList.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.noOrderCard.SuspendLayout();
            this.orderCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderImage)).BeginInit();
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
            this.materialButton1.Location = new System.Drawing.Point(43, 462);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(212, 38);
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
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.noOrderCard);
            this.tabPage2.Controls.Add(this.orderCard);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1092, 583);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "my order";
            // 
            // noOrderCard
            // 
            this.noOrderCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.noOrderCard.Controls.Add(this.noOrder);
            this.noOrderCard.Depth = 0;
            this.noOrderCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.noOrderCard.Location = new System.Drawing.Point(46, 48);
            this.noOrderCard.Margin = new System.Windows.Forms.Padding(14);
            this.noOrderCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.noOrderCard.Name = "noOrderCard";
            this.noOrderCard.Padding = new System.Windows.Forms.Padding(14);
            this.noOrderCard.Size = new System.Drawing.Size(1003, 477);
            this.noOrderCard.TabIndex = 4;
            // 
            // noOrder
            // 
            this.noOrder.AutoSize = true;
            this.noOrder.Depth = 0;
            this.noOrder.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.noOrder.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.noOrder.Location = new System.Drawing.Point(228, 170);
            this.noOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.noOrder.Name = "noOrder";
            this.noOrder.Size = new System.Drawing.Size(509, 72);
            this.noOrder.TabIndex = 0;
            this.noOrder.Text = "You have no orders";
            // 
            // orderCard
            // 
            this.orderCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.orderCard.Controls.Add(this.materialLabel12);
            this.orderCard.Controls.Add(this.endDateLabel);
            this.orderCard.Controls.Add(this.startDateLabel);
            this.orderCard.Controls.Add(this.materialLabel7);
            this.orderCard.Controls.Add(this.orderReturn);
            this.orderCard.Controls.Add(this.orderCommentLabel);
            this.orderCard.Controls.Add(this.orderModelLabel);
            this.orderCard.Controls.Add(this.orderBrandLabel);
            this.orderCard.Controls.Add(this.materialLabel10);
            this.orderCard.Controls.Add(this.materialLabel8);
            this.orderCard.Controls.Add(this.materialLabel5);
            this.orderCard.Controls.Add(this.orderImage);
            this.orderCard.Depth = 0;
            this.orderCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.orderCard.Location = new System.Drawing.Point(69, 48);
            this.orderCard.Margin = new System.Windows.Forms.Padding(14);
            this.orderCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.orderCard.Name = "orderCard";
            this.orderCard.Padding = new System.Windows.Forms.Padding(14);
            this.orderCard.Size = new System.Drawing.Size(955, 477);
            this.orderCard.TabIndex = 3;
            this.orderCard.Visible = false;
            this.orderCard.Paint += new System.Windows.Forms.PaintEventHandler(this.orderCard_Paint);
            // 
            // orderReturn
            // 
            this.orderReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.orderReturn.Depth = 0;
            this.orderReturn.DrawShadows = true;
            this.orderReturn.HighEmphasis = true;
            this.orderReturn.Icon = null;
            this.orderReturn.Location = new System.Drawing.Point(24, 386);
            this.orderReturn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.orderReturn.MouseState = MaterialSkin.MouseState.HOVER;
            this.orderReturn.Name = "orderReturn";
            this.orderReturn.Size = new System.Drawing.Size(109, 36);
            this.orderReturn.TabIndex = 2;
            this.orderReturn.Text = "return car";
            this.orderReturn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.orderReturn.UseAccentColor = false;
            this.orderReturn.UseVisualStyleBackColor = true;
            this.orderReturn.Click += new System.EventHandler(this.orderReturn_Click);
            // 
            // orderCommentLabel
            // 
            this.orderCommentLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderCommentLabel.Depth = 0;
            this.orderCommentLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.orderCommentLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.orderCommentLabel.Location = new System.Drawing.Point(373, 192);
            this.orderCommentLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.orderCommentLabel.Name = "orderCommentLabel";
            this.orderCommentLabel.Size = new System.Drawing.Size(509, 100);
            this.orderCommentLabel.TabIndex = 1;
            this.orderCommentLabel.Text = "materialLabel5";
            // 
            // orderModelLabel
            // 
            this.orderModelLabel.AutoSize = true;
            this.orderModelLabel.Depth = 0;
            this.orderModelLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.orderModelLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.orderModelLabel.Location = new System.Drawing.Point(722, 97);
            this.orderModelLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.orderModelLabel.Name = "orderModelLabel";
            this.orderModelLabel.Size = new System.Drawing.Size(160, 29);
            this.orderModelLabel.TabIndex = 1;
            this.orderModelLabel.Text = "materialLabel5";
            // 
            // orderBrandLabel
            // 
            this.orderBrandLabel.AutoSize = true;
            this.orderBrandLabel.Depth = 0;
            this.orderBrandLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.orderBrandLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.orderBrandLabel.Location = new System.Drawing.Point(722, 55);
            this.orderBrandLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.orderBrandLabel.Name = "orderBrandLabel";
            this.orderBrandLabel.Size = new System.Drawing.Size(160, 29);
            this.orderBrandLabel.TabIndex = 1;
            this.orderBrandLabel.Text = "materialLabel5";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel10.Location = new System.Drawing.Point(366, 97);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(87, 29);
            this.materialLabel10.TabIndex = 1;
            this.materialLabel10.Text = " Model :";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel8.Location = new System.Drawing.Point(373, 139);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(119, 29);
            this.materialLabel8.TabIndex = 1;
            this.materialLabel8.Text = "Comment :";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel5.Location = new System.Drawing.Point(371, 55);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(76, 29);
            this.materialLabel5.TabIndex = 1;
            this.materialLabel5.Text = "Brand :";
            // 
            // orderImage
            // 
            this.orderImage.Location = new System.Drawing.Point(24, 36);
            this.orderImage.Name = "orderImage";
            this.orderImage.Size = new System.Drawing.Size(300, 300);
            this.orderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orderImage.TabIndex = 0;
            this.orderImage.TabStop = false;
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
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel7.Location = new System.Drawing.Point(380, 363);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(118, 29);
            this.materialLabel7.TabIndex = 3;
            this.materialLabel7.Text = "Start date :";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Depth = 0;
            this.startDateLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.startDateLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.startDateLabel.Location = new System.Drawing.Point(529, 363);
            this.startDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(160, 29);
            this.startDateLabel.TabIndex = 3;
            this.startDateLabel.Text = "materialLabel7";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Depth = 0;
            this.endDateLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.endDateLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.endDateLabel.Location = new System.Drawing.Point(529, 399);
            this.endDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(160, 29);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "materialLabel7";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel12.Location = new System.Drawing.Point(380, 399);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(108, 29);
            this.materialLabel12.TabIndex = 3;
            this.materialLabel12.Text = "End date :";
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
            this.tabPage2.ResumeLayout(false);
            this.noOrderCard.ResumeLayout(false);
            this.noOrderCard.PerformLayout();
            this.orderCard.ResumeLayout(false);
            this.orderCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderImage)).EndInit();
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
        private MaterialSkin.Controls.MaterialLabel orderModelLabel;
        private MaterialSkin.Controls.MaterialLabel orderBrandLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.PictureBox orderImage;
        private MaterialSkin.Controls.MaterialButton orderReturn;
        private MaterialSkin.Controls.MaterialLabel orderCommentLabel;
        private MaterialSkin.Controls.MaterialCard orderCard;
        private MaterialSkin.Controls.MaterialCard noOrderCard;
        private MaterialSkin.Controls.MaterialLabel noOrder;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel endDateLabel;
        private MaterialSkin.Controls.MaterialLabel startDateLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
    }
}
