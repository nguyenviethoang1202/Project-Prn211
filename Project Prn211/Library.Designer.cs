namespace Project_Prn211
{
    partial class Library
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
            dgvBooks = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBookId = new TextBox();
            txtBookName = new TextBox();
            txtAuthor = new TextBox();
            txtPublisher = new TextBox();
            btnDetails = new Button();
            btnRefresh = new Button();
            cbsType = new ComboBox();
            label6 = new Label();
            cbsIsAvaiable = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(423, 12);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.RowTemplate.Height = 29;
            dgvBooks.Size = new Size(881, 546);
            dgvBooks.TabIndex = 0;
            dgvBooks.CellClick += dgvBooks_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(23, 341);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(154, 341);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(281, 341);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 4;
            label1.Text = "Find by book id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 57);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 5;
            label2.Text = "Find by book name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 94);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 6;
            label3.Text = "Find by type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 126);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 7;
            label4.Text = "Find by author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 160);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 8;
            label5.Text = "Find by publisher";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(167, 21);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(208, 27);
            txtBookId.TabIndex = 9;
            txtBookId.TextChanged += txtBookId_TextChanged;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(167, 54);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(208, 27);
            txtBookName.TabIndex = 10;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(167, 123);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(208, 27);
            txtAuthor.TabIndex = 12;
            txtAuthor.TextChanged += txtAuthor_TextChanged;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(167, 157);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(208, 27);
            txtPublisher.TabIndex = 13;
            txtPublisher.TextChanged += txtPublisher_TextChanged;
            // 
            // btnDetails
            // 
            btnDetails.Enabled = false;
            btnDetails.Location = new Point(209, 248);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(94, 29);
            btnDetails.TabIndex = 14;
            btnDetails.Text = "Details";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(65, 248);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cbsType
            // 
            cbsType.FormattingEnabled = true;
            cbsType.Location = new Point(167, 91);
            cbsType.Name = "cbsType";
            cbsType.Size = new Size(208, 28);
            cbsType.TabIndex = 17;
            cbsType.SelectedIndexChanged += cbsType_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 203);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 18;
            label6.Text = "Avaiable/Hired";
            // 
            // cbsIsAvaiable
            // 
            cbsIsAvaiable.FormattingEnabled = true;
            cbsIsAvaiable.Location = new Point(167, 200);
            cbsIsAvaiable.Name = "cbsIsAvaiable";
            cbsIsAvaiable.Size = new Size(208, 28);
            cbsIsAvaiable.TabIndex = 19;
            cbsIsAvaiable.SelectedIndexChanged += cbsIsAvaiable_SelectedIndexChanged_1;
            // 
            // Library
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1316, 570);
            Controls.Add(cbsIsAvaiable);
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
            Controls.Add(dgvBooks);
            Name = "Library";
            Text = "Library";
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBooks;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBookId;
        private TextBox txtBookName;
        private TextBox txtAuthor;
        private TextBox txtPublisher;
        private Button btnDetails;
        private Button btnRefresh;
        private ComboBox cbsType;
        private Label label6;
        private ComboBox cbsIsAvaiable;
    }
}