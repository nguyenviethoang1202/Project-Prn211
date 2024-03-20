namespace Project_Prn211
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            btnSignup = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtFullname = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            llbSignin = new LinkLabel();
            label7 = new Label();
            txtRepass = new TextBox();
            SuspendLayout();
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(219, 377);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(94, 29);
            btnSignup.TabIndex = 0;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(202, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 46);
            label1.TabIndex = 2;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 90);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Full name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 129);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 166);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 5;
            label4.Text = "Phone number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 202);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 6;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 236);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 7;
            label6.Text = "Password";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(177, 87);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(230, 27);
            txtFullname.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(177, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(177, 163);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(230, 27);
            txtPhone.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(177, 199);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(230, 27);
            txtUsername.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(177, 233);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(230, 27);
            txtPassword.TabIndex = 12;
            // 
            // llbSignin
            // 
            llbSignin.AutoSize = true;
            llbSignin.Location = new Point(177, 339);
            llbSignin.Name = "llbSignin";
            llbSignin.Size = new Size(175, 20);
            llbSignin.TabIndex = 13;
            llbSignin.TabStop = true;
            llbSignin.Text = "Have an account? Sign in";
            llbSignin.LinkClicked += llbSignin_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 270);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 14;
            label7.Text = "Re-password";
            // 
            // txtRepass
            // 
            txtRepass.Location = new Point(177, 267);
            txtRepass.Name = "txtRepass";
            txtRepass.PasswordChar = '*';
            txtRepass.Size = new Size(230, 27);
            txtRepass.TabIndex = 15;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 450);
            Controls.Add(txtRepass);
            Controls.Add(label7);
            Controls.Add(llbSignin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtFullname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSignup);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            FormClosing += SignUp_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignup;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtFullname;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private LinkLabel llbSignin;
        private Label label7;
        private TextBox txtRepass;
    }
}