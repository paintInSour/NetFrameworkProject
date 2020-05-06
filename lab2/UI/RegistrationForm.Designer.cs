namespace netFrameworkProject
{
    partial class RegistrationForm
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
            this.usernameBox = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordBox = new MaterialSkin.Controls.MaterialTextBox();
            this.repeatPasswordBox = new MaterialSkin.Controls.MaterialTextBox();
            this.register = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.Depth = 0;
            this.usernameBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.usernameBox.Location = new System.Drawing.Point(89, 142);
            this.usernameBox.MaxLength = 50;
            this.usernameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameBox.Multiline = false;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(247, 50);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.Text = "";
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Depth = 0;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordBox.Location = new System.Drawing.Point(89, 216);
            this.passwordBox.MaxLength = 50;
            this.passwordBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordBox.Multiline = false;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(247, 50);
            this.passwordBox.TabIndex = 0;
            this.passwordBox.Text = "";
            // 
            // repeatPasswordBox
            // 
            this.repeatPasswordBox.BackColor = System.Drawing.SystemColors.Window;
            this.repeatPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repeatPasswordBox.Depth = 0;
            this.repeatPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.repeatPasswordBox.Location = new System.Drawing.Point(89, 306);
            this.repeatPasswordBox.MaxLength = 50;
            this.repeatPasswordBox.MouseState = MaterialSkin.MouseState.OUT;
            this.repeatPasswordBox.Multiline = false;
            this.repeatPasswordBox.Name = "repeatPasswordBox";
            this.repeatPasswordBox.Size = new System.Drawing.Size(247, 50);
            this.repeatPasswordBox.TabIndex = 0;
            this.repeatPasswordBox.Text = "";
            // 
            // register
            // 
            this.register.AutoSize = false;
            this.register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.register.Depth = 0;
            this.register.DrawShadows = true;
            this.register.HighEmphasis = true;
            this.register.Icon = null;
            this.register.Location = new System.Drawing.Point(89, 392);
            this.register.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.register.MouseState = MaterialSkin.MouseState.HOVER;
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(247, 50);
            this.register.TabIndex = 1;
            this.register.Text = "register";
            this.register.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.register.UseAccentColor = false;
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(175, 194);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Username";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(175, 269);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Password";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(157, 359);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(123, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Repeat password";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(417, 546);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.repeatPasswordBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox usernameBox;
        private MaterialSkin.Controls.MaterialTextBox passwordBox;
        private MaterialSkin.Controls.MaterialTextBox repeatPasswordBox;
        private MaterialSkin.Controls.MaterialButton register;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}