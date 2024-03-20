namespace Project_Prn211
{
    partial class UserManagement
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
            dgvUserHiredBooks = new DataGridView();
            dgvUsers = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtUserId = new TextBox();
            txtUserFullname = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            label7 = new Label();
            cbsIsBanned = new ComboBox();
            btnBan = new Button();
            btnUnban = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUserHiredBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUserHiredBooks
            // 
            dgvUserHiredBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserHiredBooks.Location = new Point(871, 49);
            dgvUserHiredBooks.Name = "dgvUserHiredBooks";
            dgvUserHiredBooks.RowHeadersWidth = 51;
            dgvUserHiredBooks.RowTemplate.Height = 29;
            dgvUserHiredBooks.Size = new Size(433, 509);
            dgvUserHiredBooks.TabIndex = 0;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(432, 49);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.Height = 29;
            dgvUsers.Size = new Size(433, 509);
            dgvUsers.TabIndex = 1;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "User id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "User full name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 135);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 170);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(638, 9);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 6;
            label5.Text = "User";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1035, 9);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 7;
            label6.Text = "User hired book";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(145, 65);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(230, 27);
            txtUserId.TabIndex = 8;
            txtUserId.TextChanged += textBox1_TextChanged;
            // 
            // txtUserFullname
            // 
            txtUserFullname.Location = new Point(145, 97);
            txtUserFullname.Name = "txtUserFullname";
            txtUserFullname.Size = new Size(230, 27);
            txtUserFullname.TabIndex = 9;
            txtUserFullname.TextChanged += textBox2_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(145, 132);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(230, 27);
            txtPhone.TabIndex = 10;
            txtPhone.TextChanged += textBox3_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(145, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 27);
            txtEmail.TabIndex = 11;
            txtEmail.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 203);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 12;
            label7.Text = "isBanned";
            // 
            // cbsIsBanned
            // 
            cbsIsBanned.FormattingEnabled = true;
            cbsIsBanned.Location = new Point(145, 200);
            cbsIsBanned.Name = "cbsIsBanned";
            cbsIsBanned.Size = new Size(230, 28);
            cbsIsBanned.TabIndex = 13;
            cbsIsBanned.SelectedIndexChanged += cbsIsBanned_SelectedIndexChanged;
            // 
            // btnBan
            // 
            btnBan.Location = new Point(67, 291);
            btnBan.Name = "btnBan";
            btnBan.Size = new Size(94, 29);
            btnBan.TabIndex = 14;
            btnBan.Text = "Ban";
            btnBan.UseVisualStyleBackColor = true;
            btnBan.Click += btnBan_Click;
            // 
            // btnUnban
            // 
            btnUnban.Location = new Point(217, 291);
            btnUnban.Name = "btnUnban";
            btnUnban.Size = new Size(94, 29);
            btnUnban.TabIndex = 15;
            btnUnban.Text = "Unban";
            btnUnban.UseVisualStyleBackColor = true;
            btnUnban.Click += btnUnban_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(145, 240);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1316, 570);
            Controls.Add(btnRefresh);
            Controls.Add(btnUnban);
            Controls.Add(btnBan);
            Controls.Add(cbsIsBanned);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtUserFullname);
            Controls.Add(txtUserId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvUsers);
            Controls.Add(dgvUserHiredBooks);
            Name = "UserManagement";
            Text = "UserManagement";
            ((System.ComponentModel.ISupportInitialize)dgvUserHiredBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUserHiredBooks;
        private DataGridView dgvUsers;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtUserId;
        private TextBox txtUserFullname;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label label7;
        private ComboBox cbsIsBanned;
        private Button btnBan;
        private Button btnUnban;
        private Button btnRefresh;
    }
}