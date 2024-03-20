namespace Project_Prn211
{
    partial class InfoForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsername = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtFullname = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            gbInfo = new GroupBox();
            txtId = new TextBox();
            label6 = new Label();
            gbChangePass = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            txtRepass = new TextBox();
            txtNewpass = new TextBox();
            txtOldpass = new TextBox();
            btnUpdate = new Button();
            btnChange = new Button();
            gbInfo.SuspendLayout();
            gbChangePass.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 47);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 114);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 225);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 384);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(302, 261);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Enabled = false;
            txtUsername.Location = new Point(151, 90);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(230, 27);
            txtUsername.TabIndex = 24;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(151, 202);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(230, 27);
            txtPhone.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(151, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 27);
            txtEmail.TabIndex = 22;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(151, 123);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(230, 27);
            txtFullname.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 93);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 19;
            label8.Text = "Username";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 205);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 18;
            label9.Text = "Phone number";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 165);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 17;
            label10.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 126);
            label11.Name = "label11";
            label11.Size = new Size(73, 20);
            label11.TabIndex = 16;
            label11.Text = "Full name";
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(txtId);
            gbInfo.Controls.Add(label6);
            gbInfo.Controls.Add(label11);
            gbInfo.Controls.Add(label2);
            gbInfo.Controls.Add(label8);
            gbInfo.Controls.Add(txtUsername);
            gbInfo.Controls.Add(label3);
            gbInfo.Controls.Add(label5);
            gbInfo.Controls.Add(label10);
            gbInfo.Controls.Add(txtPhone);
            gbInfo.Controls.Add(label9);
            gbInfo.Controls.Add(txtEmail);
            gbInfo.Controls.Add(txtFullname);
            gbInfo.Location = new Point(52, 88);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(401, 254);
            gbInfo.TabIndex = 28;
            gbInfo.TabStop = false;
            gbInfo.Text = "Info";
            // 
            // txtId
            // 
            txtId.Location = new Point(151, 50);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(230, 27);
            txtId.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 53);
            label6.Name = "label6";
            label6.Size = new Size(22, 20);
            label6.TabIndex = 25;
            label6.Text = "Id";
            // 
            // gbChangePass
            // 
            gbChangePass.Controls.Add(label14);
            gbChangePass.Controls.Add(label13);
            gbChangePass.Controls.Add(label12);
            gbChangePass.Controls.Add(txtRepass);
            gbChangePass.Controls.Add(txtNewpass);
            gbChangePass.Controls.Add(txtOldpass);
            gbChangePass.Location = new Point(544, 88);
            gbChangePass.Name = "gbChangePass";
            gbChangePass.Size = new Size(403, 254);
            gbChangePass.TabIndex = 29;
            gbChangePass.TabStop = false;
            gbChangePass.Text = "Change password";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(21, 178);
            label14.Name = "label14";
            label14.Size = new Size(103, 20);
            label14.TabIndex = 31;
            label14.Text = "Re - password";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(21, 123);
            label13.Name = "label13";
            label13.Size = new Size(106, 20);
            label13.TabIndex = 30;
            label13.Text = "New password";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 69);
            label12.Name = "label12";
            label12.Size = new Size(100, 20);
            label12.TabIndex = 29;
            label12.Text = "Old password";
            // 
            // txtRepass
            // 
            txtRepass.Location = new Point(153, 175);
            txtRepass.Name = "txtRepass";
            txtRepass.PasswordChar = '*';
            txtRepass.Size = new Size(230, 27);
            txtRepass.TabIndex = 28;
            // 
            // txtNewpass
            // 
            txtNewpass.Location = new Point(153, 123);
            txtNewpass.Name = "txtNewpass";
            txtNewpass.PasswordChar = '*';
            txtNewpass.Size = new Size(230, 27);
            txtNewpass.TabIndex = 27;
            // 
            // txtOldpass
            // 
            txtOldpass.Location = new Point(153, 66);
            txtOldpass.Name = "txtOldpass";
            txtOldpass.PasswordChar = '*';
            txtOldpass.Size = new Size(230, 27);
            txtOldpass.TabIndex = 26;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(203, 349);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(736, 355);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(94, 29);
            btnChange.TabIndex = 31;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1316, 570);
            Controls.Add(btnChange);
            Controls.Add(btnUpdate);
            Controls.Add(gbChangePass);
            Controls.Add(gbInfo);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "InfoForm";
            Text = "InfoForm";
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            gbChangePass.ResumeLayout(false);
            gbChangePass.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsername;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtFullname;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private GroupBox gbInfo;
        private GroupBox gbChangePass;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox txtRepass;
        private TextBox txtNewpass;
        private TextBox txtOldpass;
        private TextBox txtId;
        private Label label6;
        private Button btnUpdate;
        private Button btnChange;
    }
}