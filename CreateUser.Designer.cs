namespace WindowsFormsApp2
{
    partial class CreateUser
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
            this.userNameTakenError = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.regAddressText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.regEmailText = new System.Windows.Forms.TextBox();
            this.regNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regPasswordText = new System.Windows.Forms.TextBox();
            this.regUserNametext = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameTakenError
            // 
            this.userNameTakenError.BackColor = System.Drawing.Color.Transparent;
            this.userNameTakenError.Location = new System.Drawing.Point(134, 186);
            this.userNameTakenError.Name = "userNameTakenError";
            this.userNameTakenError.Size = new System.Drawing.Size(136, 13);
            this.userNameTakenError.TabIndex = 31;
            this.userNameTakenError.Text = "Username Taken!";
            this.userNameTakenError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userNameTakenError.Visible = false;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(164, 160);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 29;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(61, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Address:";
            // 
            // regAddressText
            // 
            this.regAddressText.Location = new System.Drawing.Point(134, 134);
            this.regAddressText.Name = "regAddressText";
            this.regAddressText.Size = new System.Drawing.Size(136, 20);
            this.regAddressText.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(59, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Full Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(61, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Email:";
            // 
            // regEmailText
            // 
            this.regEmailText.Location = new System.Drawing.Point(134, 108);
            this.regEmailText.Name = "regEmailText";
            this.regEmailText.Size = new System.Drawing.Size(136, 20);
            this.regEmailText.TabIndex = 24;
            // 
            // regNameText
            // 
            this.regNameText.Location = new System.Drawing.Point(134, 82);
            this.regNameText.Name = "regNameText";
            this.regNameText.Size = new System.Drawing.Size(136, 20);
            this.regNameText.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(61, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Password:";
            // 
            // regPasswordText
            // 
            this.regPasswordText.Location = new System.Drawing.Point(134, 56);
            this.regPasswordText.Name = "regPasswordText";
            this.regPasswordText.Size = new System.Drawing.Size(136, 20);
            this.regPasswordText.TabIndex = 20;
            // 
            // regUserNametext
            // 
            this.regUserNametext.Location = new System.Drawing.Point(134, 30);
            this.regUserNametext.Name = "regUserNametext";
            this.regUserNametext.Size = new System.Drawing.Size(136, 20);
            this.regUserNametext.TabIndex = 19;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(275, 233);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(121, 23);
            this.backButton.TabIndex = 33;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.WindowBackground;
            this.ClientSize = new System.Drawing.Size(408, 268);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.userNameTakenError);
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
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameTakenError;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox regAddressText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox regEmailText;
        private System.Windows.Forms.TextBox regNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox regPasswordText;
        private System.Windows.Forms.TextBox regUserNametext;
        private System.Windows.Forms.Button backButton;
    }
}