namespace Project_Prn211
{
    partial class MyHiredBook
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
            cbsType = new ComboBox();
            btnRefresh = new Button();
            btnDetails = new Button();
            txtPublisher = new TextBox();
            txtAuthor = new TextBox();
            txtBookName = new TextBox();
            txtBookId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvHiredBooks = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHiredBooks).BeginInit();
            SuspendLayout();
            // 
            // cbsType
            // 
            cbsType.FormattingEnabled = true;
            cbsType.Location = new Point(231, 88);
            cbsType.Name = "cbsType";
            cbsType.Size = new Size(208, 28);
            cbsType.TabIndex = 35;
            cbsType.SelectedIndexChanged += cbsType_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(60, 306);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 34;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDetails
            // 
            btnDetails.Enabled = false;
            btnDetails.Location = new Point(276, 306);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(94, 29);
            btnDetails.TabIndex = 33;
            btnDetails.Text = "Details";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(231, 154);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(208, 27);
            txtPublisher.TabIndex = 32;
            txtPublisher.TextChanged += txtPublisher_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(231, 120);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(208, 27);
            txtAuthor.TabIndex = 31;
            txtAuthor.TextChanged += txtAuthor_TextChanged;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(231, 51);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(208, 27);
            txtBookName.TabIndex = 30;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(231, 18);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(208, 27);
            txtBookId.TabIndex = 29;
            txtBookId.TextChanged += txtBookId_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 160);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 28;
            label5.Text = "Find by publisher";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 126);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 27;
            label4.Text = "Find by author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 94);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 26;
            label3.Text = "Find by type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 57);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 25;
            label2.Text = "Find by book name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 24;
            label1.Text = "Find by book id";
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(276, 341);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(0, 0);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(149, 341);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(0, 0);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 341);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(0, 0);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvHiredBooks
            // 
            dgvHiredBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHiredBooks.Location = new Point(488, 12);
            dgvHiredBooks.Name = "dgvHiredBooks";
            dgvHiredBooks.RowHeadersWidth = 51;
            dgvHiredBooks.RowTemplate.Height = 29;
            dgvHiredBooks.Size = new Size(811, 546);
            dgvHiredBooks.TabIndex = 20;
            dgvHiredBooks.CellClick += dgvHiredBooks_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 289);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 256);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 223);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 190);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 43;
            // 
            // MyHiredBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1316, 570);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbsType);
            Controls.Add(btnRefresh);
            Controls.Add(btnDetails);
            Controls.Add(txtPublisher);
            Controls.Add(txtAuthor);
            Controls.Add(txtBookName);
            Controls.Add(txtBookId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvHiredBooks);
            Name = "MyHiredBook";
            Text = "MyHiredBook";
            ((System.ComponentModel.ISupportInitialize)dgvHiredBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbsType;
        private Button btnRefresh;
        private Button btnDetails;
        private TextBox txtPublisher;
        private TextBox txtAuthor;
        private TextBox txtBookName;
        private TextBox txtBookId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvHiredBooks;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}