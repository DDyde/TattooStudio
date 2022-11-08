namespace TattooStudio
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.accountLoginButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelLogIn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.Black;
            this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBox.ForeColor = System.Drawing.Color.White;
            this.loginBox.Location = new System.Drawing.Point(98, 200);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(241, 36);
            this.loginBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.Black;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordBox.ForeColor = System.Drawing.Color.White;
            this.passwordBox.Location = new System.Drawing.Point(98, 252);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(241, 36);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // accountLoginButton
            // 
            this.accountLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountLoginButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountLoginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.accountLoginButton.Location = new System.Drawing.Point(161, 308);
            this.accountLoginButton.Name = "accountLoginButton";
            this.accountLoginButton.Size = new System.Drawing.Size(120, 40);
            this.accountLoginButton.TabIndex = 2;
            this.accountLoginButton.Text = "Войти";
            this.accountLoginButton.UseVisualStyleBackColor = true;
            this.accountLoginButton.Click += new System.EventHandler(this.accountLoginButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Controls.Add(this.labelLogIn);
            this.splitContainer1.Panel2.Controls.Add(this.loginBox);
            this.splitContainer1.Panel2.Controls.Add(this.accountLoginButton);
            this.splitContainer1.Panel2.Controls.Add(this.passwordBox);
            this.splitContainer1.Size = new System.Drawing.Size(723, 453);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 3;
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.Font = new System.Drawing.Font("Magneto", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelLogIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLogIn.Location = new System.Drawing.Point(153, 120);
            this.labelLogIn.MinimumSize = new System.Drawing.Size(120, 0);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(133, 44);
            this.labelLogIn.TabIndex = 3;
            this.labelLogIn.Text = "Login";
            this.labelLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 453);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox loginBox;
        private TextBox passwordBox;
        private Button accountLoginButton;
        private SplitContainer splitContainer1;
        private Label labelLogIn;
    }
}