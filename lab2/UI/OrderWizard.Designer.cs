namespace netFrameworkProject.UI
{
    partial class OrderWizard
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.userIdTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.getRentButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(32, 163);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(117, 29);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Person ID :";
            // 
            // userIdTextbox
            // 
            this.userIdTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userIdTextbox.Depth = 0;
            this.userIdTextbox.Font = new System.Drawing.Font("Roboto", 12F);
            this.userIdTextbox.Location = new System.Drawing.Point(168, 142);
            this.userIdTextbox.MaxLength = 50;
            this.userIdTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.userIdTextbox.Multiline = false;
            this.userIdTextbox.Name = "userIdTextbox";
            this.userIdTextbox.Size = new System.Drawing.Size(261, 50);
            this.userIdTextbox.TabIndex = 1;
            this.userIdTextbox.Text = "";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Location = new System.Drawing.Point(105, 221);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(324, 38);
            this.startDatePicker.TabIndex = 3;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Location = new System.Drawing.Point(105, 294);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(324, 38);
            this.endDatePicker.TabIndex = 3;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(34, 226);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 29);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "From :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(34, 299);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(41, 29);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "To :";
            // 
            // getRentButton
            // 
            this.getRentButton.AutoSize = false;
            this.getRentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getRentButton.Depth = 0;
            this.getRentButton.DrawShadows = true;
            this.getRentButton.HighEmphasis = true;
            this.getRentButton.Icon = null;
            this.getRentButton.Location = new System.Drawing.Point(142, 383);
            this.getRentButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.getRentButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.getRentButton.Name = "getRentButton";
            this.getRentButton.Size = new System.Drawing.Size(151, 43);
            this.getRentButton.TabIndex = 5;
            this.getRentButton.Text = "submit";
            this.getRentButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.getRentButton.UseAccentColor = false;
            this.getRentButton.UseVisualStyleBackColor = true;
            this.getRentButton.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // OrderWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 480);
            this.Controls.Add(this.getRentButton);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.userIdTextbox);
            this.Controls.Add(this.materialLabel1);
            this.Name = "OrderWizard";
            this.Text = "OrderWizard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox userIdTextbox;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton getRentButton;
    }
}