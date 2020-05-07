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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.usernameBox = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordBox = new MaterialSkin.Controls.MaterialTextBox();
            this.repeatPasswordBox = new MaterialSkin.Controls.MaterialTextBox();
            this.register = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.Depth = 0;
            this.usernameBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.usernameBox.Hint = "username";
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
            this.passwordBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.passwordBox.Hint = "password";
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
            this.repeatPasswordBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.repeatPasswordBox.Hint = "repeat pessword";
            this.repeatPasswordBox.Location = new System.Drawing.Point(89, 297);
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
            this.register.Location = new System.Drawing.Point(89, 383);
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
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(417, 546);
            this.Controls.Add(this.register);
            this.Controls.Add(this.repeatPasswordBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox usernameBox;
        private MaterialSkin.Controls.MaterialTextBox passwordBox;
        private MaterialSkin.Controls.MaterialTextBox repeatPasswordBox;
        private MaterialSkin.Controls.MaterialButton register;
    }
}