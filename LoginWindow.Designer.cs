namespace WindowsFormsApp2
{
    partial class LoginWindow
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
            this.loginButton = new System.Windows.Forms.Button();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.errorText = new System.Windows.Forms.Label();
            this.createUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(148, 125);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(120, 73);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(136, 20);
            this.userNameText.TabIndex = 1;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(120, 99);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(136, 20);
            this.passwordText.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Location = new System.Drawing.Point(47, 99);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(56, 13);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password:";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.Transparent;
            this.UserName.Location = new System.Drawing.Point(45, 73);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(58, 13);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "Username:";
            // 
            // errorText
            // 
            this.errorText.BackColor = System.Drawing.Color.Transparent;
            this.errorText.Location = new System.Drawing.Point(120, 164);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(136, 13);
            this.errorText.TabIndex = 5;
            this.errorText.Text = "Invalid credentials!";
            this.errorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorText.Visible = false;
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(120, 193);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(136, 23);
            this.createUserButton.TabIndex = 6;
            this.createUserButton.Text = "Create Account";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.WindowBackground;
            this.ClientSize = new System.Drawing.Size(374, 251);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.loginButton);
            this.Name = "LoginWindow";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.Button createUserButton;
    }
}

