namespace WindowsFormsApp2
{
    partial class Form1
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
            this.successMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regPasswordText = new System.Windows.Forms.TextBox();
            this.regUserNametext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.regEmailText = new System.Windows.Forms.TextBox();
            this.regNameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.regAddressText = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.registerSuccess = new System.Windows.Forms.Label();
            this.userNameTakenError = new System.Windows.Forms.Label();
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
            this.Password.Location = new System.Drawing.Point(47, 99);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(56, 13);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password:";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(45, 73);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(58, 13);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "Username:";
            // 
            // successMessage
            // 
            this.successMessage.AutoSize = true;
            this.successMessage.Location = new System.Drawing.Point(155, 162);
            this.successMessage.Name = "successMessage";
            this.successMessage.Size = new System.Drawing.Size(58, 13);
            this.successMessage.TabIndex = 5;
            this.successMessage.Text = "Logged In!";
            this.successMessage.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // regPasswordText
            // 
            this.regPasswordText.Location = new System.Drawing.Point(495, 99);
            this.regPasswordText.Name = "regPasswordText";
            this.regPasswordText.Size = new System.Drawing.Size(136, 20);
            this.regPasswordText.TabIndex = 7;
            // 
            // regUserNametext
            // 
            this.regUserNametext.Location = new System.Drawing.Point(495, 73);
            this.regUserNametext.Name = "regUserNametext";
            this.regUserNametext.Size = new System.Drawing.Size(136, 20);
            this.regUserNametext.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Full Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email:";
            // 
            // regEmailText
            // 
            this.regEmailText.Location = new System.Drawing.Point(495, 151);
            this.regEmailText.Name = "regEmailText";
            this.regEmailText.Size = new System.Drawing.Size(136, 20);
            this.regEmailText.TabIndex = 11;
            // 
            // regNameText
            // 
            this.regNameText.Location = new System.Drawing.Point(495, 125);
            this.regNameText.Name = "regNameText";
            this.regNameText.Size = new System.Drawing.Size(136, 20);
            this.regNameText.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Address:";
            // 
            // regAddressText
            // 
            this.regAddressText.Location = new System.Drawing.Point(495, 177);
            this.regAddressText.Name = "regAddressText";
            this.regAddressText.Size = new System.Drawing.Size(136, 20);
            this.regAddressText.TabIndex = 14;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(525, 203);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 16;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // registerSuccess
            // 
            this.registerSuccess.AutoSize = true;
            this.registerSuccess.Location = new System.Drawing.Point(532, 229);
            this.registerSuccess.Name = "registerSuccess";
            this.registerSuccess.Size = new System.Drawing.Size(61, 13);
            this.registerSuccess.TabIndex = 17;
            this.registerSuccess.Text = "Registered!";
            this.registerSuccess.Visible = false;
            // 
            // userNameTakenError
            // 
            this.userNameTakenError.AutoSize = true;
            this.userNameTakenError.Location = new System.Drawing.Point(522, 229);
            this.userNameTakenError.Name = "userNameTakenError";
            this.userNameTakenError.Size = new System.Drawing.Size(92, 13);
            this.userNameTakenError.TabIndex = 18;
            this.userNameTakenError.Text = "Username Taken!";
            this.userNameTakenError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userNameTakenError);
            this.Controls.Add(this.registerSuccess);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.regAddressText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.regEmailText);
            this.Controls.Add(this.regNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regPasswordText);
            this.Controls.Add(this.regUserNametext);
            this.Controls.Add(this.successMessage);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.loginButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label successMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regPasswordText;
        private System.Windows.Forms.TextBox regUserNametext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox regEmailText;
        private System.Windows.Forms.TextBox regNameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox regAddressText;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label registerSuccess;
        private System.Windows.Forms.Label userNameTakenError;
    }
}

