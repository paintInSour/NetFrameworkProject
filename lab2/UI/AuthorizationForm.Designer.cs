namespace lab2.UI
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
            this.user = new MaterialSkin.Controls.MaterialRadioButton();
            this.admin = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Depth = 0;
            this.user.Location = new System.Drawing.Point(134, 184);
            this.user.Margin = new System.Windows.Forms.Padding(0);
            this.user.MouseLocation = new System.Drawing.Point(-1, -1);
            this.user.MouseState = MaterialSkin.MouseState.HOVER;
            this.user.Name = "user";
            this.user.Ripple = true;
            this.user.Size = new System.Drawing.Size(65, 37);
            this.user.TabIndex = 0;
            this.user.TabStop = true;
            this.user.Text = "user";
            this.user.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Depth = 0;
            this.admin.Location = new System.Drawing.Point(134, 232);
            this.admin.Margin = new System.Windows.Forms.Padding(0);
            this.admin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.admin.MouseState = MaterialSkin.MouseState.HOVER;
            this.admin.Name = "admin";
            this.admin.Ripple = true;
            this.admin.Size = new System.Drawing.Size(80, 37);
            this.admin.TabIndex = 0;
            this.admin.TabStop = true;
            this.admin.Text = "admin";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(134, 316);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(101, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Authorize";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 497);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.user);
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton user;
        private MaterialSkin.Controls.MaterialRadioButton admin;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}