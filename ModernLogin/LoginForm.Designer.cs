namespace ModernLogin
{
    partial class LoginForm
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
            this.loginForm1 = new AnimaForm();
            this.closeButton = new AnimaButton();
            this.loginButton = new AnimaButton();
            this.passwordTextBox = new AnimaTextBox();
            this.emailTextBox = new AnimaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginForm1
            // 
            this.loginForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.loginForm1.Controls.Add(this.closeButton);
            this.loginForm1.Controls.Add(this.loginButton);
            this.loginForm1.Controls.Add(this.passwordTextBox);
            this.loginForm1.Controls.Add(this.emailTextBox);
            this.loginForm1.Controls.Add(this.label2);
            this.loginForm1.Controls.Add(this.label1);
            this.loginForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.loginForm1.Location = new System.Drawing.Point(0, 0);
            this.loginForm1.Name = "loginForm1";
            this.loginForm1.Size = new System.Drawing.Size(543, 126);
            this.loginForm1.TabIndex = 0;
            this.loginForm1.Text = "MODERN LOGIN";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.closeButton.ImageLocation = new System.Drawing.Point(30, 6);
            this.closeButton.ImageSize = new System.Drawing.Size(14, 14);
            this.closeButton.Location = new System.Drawing.Point(504, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(27, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "x";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.loginButton.ImageLocation = new System.Drawing.Point(30, 6);
            this.loginButton.ImageSize = new System.Drawing.Size(14, 14);
            this.loginButton.Location = new System.Drawing.Point(454, 71);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Dark = false;
            this.passwordTextBox.Location = new System.Drawing.Point(234, 71);
            this.passwordTextBox.MaxLength = 50;
            this.passwordTextBox.MultiLine = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Numeric = false;
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.Size = new System.Drawing.Size(213, 23);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Dark = false;
            this.emailTextBox.Location = new System.Drawing.Point(15, 71);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.MultiLine = false;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Numeric = false;
            this.emailTextBox.ReadOnly = false;
            this.emailTextBox.Size = new System.Drawing.Size(213, 23);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMAIL";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 126);
            this.Controls.Add(this.loginForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODERN LOGIN";
            this.loginForm1.ResumeLayout(false);
            this.loginForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AnimaForm loginForm1;
        private AnimaTextBox passwordTextBox;
        private AnimaTextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AnimaButton loginButton;
        private AnimaButton closeButton;
    }
}

