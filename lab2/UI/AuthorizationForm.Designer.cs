namespace netFrameworkProject.UI
{
    partial class AuthorizationForm
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
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.logingTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.registerButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(86, 289);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(222, 48);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Authorize";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // logingTextBox
            // 
            this.logingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logingTextBox.Depth = 0;
            this.logingTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.logingTextBox.Location = new System.Drawing.Point(86, 143);
            this.logingTextBox.MaxLength = 15;
            this.logingTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.logingTextBox.Multiline = false;
            this.logingTextBox.Name = "logingTextBox";
            this.logingTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.logingTextBox.Size = new System.Drawing.Size(222, 50);
            this.logingTextBox.TabIndex = 2;
            this.logingTextBox.Text = "";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(86, 199);
            this.passwordTextBox.MaxLength = 15;
            this.passwordTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Password = true;
            this.passwordTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.passwordTextBox.Size = new System.Drawing.Size(222, 50);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "";
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = false;
            this.registerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerButton.Depth = 0;
            this.registerButton.DrawShadows = true;
            this.registerButton.HighEmphasis = true;
            this.registerButton.Icon = null;
            this.registerButton.Location = new System.Drawing.Point(86, 349);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(222, 49);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "REgister";
            this.registerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.registerButton.UseAccentColor = false;
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 497);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.logingTextBox);
            this.Controls.Add(this.materialButton1);
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox logingTextBox;
        private MaterialSkin.Controls.MaterialTextBox passwordTextBox;
        private MaterialSkin.Controls.MaterialButton registerButton;
    }
}