namespace Project_Prn211
{
    partial class LibraryAction
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
            txtPublisher = new TextBox();
            txtAuthor = new TextBox();
            txtBookName = new TextBox();
            txtBookId = new TextBox();
            t = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtHiredBy = new TextBox();
            lbHiredBy = new Label();
            lbHiredDate = new Label();
            label7 = new Label();
            rtxtDescription = new RichTextBox();
            label8 = new Label();
            btnSave = new Button();
            pnAdmin = new Panel();
            txtReturnDate = new TextBox();
            txtHireDate = new TextBox();
            pnAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // cbsType
            // 
            cbsType.FormattingEnabled = true;
            cbsType.Location = new Point(210, 94);
            cbsType.Name = "cbsType";
            cbsType.Size = new Size(262, 28);
            cbsType.TabIndex = 22;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(210, 161);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(262, 27);
            txtPublisher.TabIndex = 21;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(210, 128);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(262, 27);
            txtAuthor.TabIndex = 20;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(210, 61);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(262, 27);
            txtBookName.TabIndex = 19;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(210, 27);
            txtBookId.Name = "txtBookId";
            txtBookId.ReadOnly = true;
            txtBookId.Size = new Size(262, 27);
            txtBookId.TabIndex = 18;
            // 
            // t
            // 
            t.AutoSize = true;
            t.Location = new Point(95, 30);
            t.Name = "t";
            t.Size = new Size(60, 20);
            t.TabIndex = 23;
            t.Text = "Book Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 64);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 24;
            label2.Text = "Book name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 97);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 25;
            label3.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 131);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 26;
            label4.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 164);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 27;
            label5.Text = "Publisher";
            // 
            // txtHiredBy
            // 
            txtHiredBy.Location = new Point(118, 14);
            txtHiredBy.Name = "txtHiredBy";
            txtHiredBy.Size = new Size(262, 27);
            txtHiredBy.TabIndex = 28;
            // 
            // lbHiredBy
            // 
            lbHiredBy.AutoSize = true;
            lbHiredBy.Location = new Point(3, 17);
            lbHiredBy.Name = "lbHiredBy";
            lbHiredBy.Size = new Size(66, 20);
            lbHiredBy.TabIndex = 30;
            lbHiredBy.Text = "Hired By";
            // 
            // lbHiredDate
            // 
            lbHiredDate.AutoSize = true;
            lbHiredDate.Location = new Point(3, 50);
            lbHiredDate.Name = "lbHiredDate";
            lbHiredDate.Size = new Size(73, 20);
            lbHiredDate.TabIndex = 31;
            lbHiredDate.Text = "Hire Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(95, 205);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 32;
            label7.Text = "Description";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(210, 202);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(262, 120);
            rtxtDescription.TabIndex = 33;
            rtxtDescription.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 78);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 36;
            label8.Text = "Return Date";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(226, 469);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 37;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pnAdmin
            // 
            pnAdmin.Controls.Add(txtReturnDate);
            pnAdmin.Controls.Add(txtHireDate);
            pnAdmin.Controls.Add(lbHiredBy);
            pnAdmin.Controls.Add(txtHiredBy);
            pnAdmin.Controls.Add(label8);
            pnAdmin.Controls.Add(lbHiredDate);
            pnAdmin.Location = new Point(95, 328);
            pnAdmin.Name = "pnAdmin";
            pnAdmin.Size = new Size(393, 109);
            pnAdmin.TabIndex = 38;
            // 
            // txtReturnDate
            // 
            txtReturnDate.Location = new Point(118, 78);
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.Size = new Size(262, 27);
            txtReturnDate.TabIndex = 38;
            // 
            // txtHireDate
            // 
            txtHireDate.Location = new Point(118, 47);
            txtHireDate.Name = "txtHireDate";
            txtHireDate.Size = new Size(262, 27);
            txtHireDate.TabIndex = 37;
            // 
            // LibraryAction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 510);
            Controls.Add(pnAdmin);
            Controls.Add(btnSave);
            Controls.Add(rtxtDescription);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(t);
            Controls.Add(cbsType);
            Controls.Add(txtPublisher);
            Controls.Add(txtAuthor);
            Controls.Add(txtBookName);
            Controls.Add(txtBookId);
            Name = "LibraryAction";
            Text = "LibraryAction";
            pnAdmin.ResumeLayout(false);
            pnAdmin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbsType;
        private TextBox txtPublisher;
        private TextBox txtAuthor;
        private TextBox txtBookName;
        private TextBox txtBookId;
        private Label t;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtHiredBy;
        private Label lbHiredBy;
        private Label lbHiredDate;
        private Label label7;
        private RichTextBox rtxtDescription;
        private Label label8;
        private Button btnSave;
        private Panel pnAdmin;
        private TextBox txtReturnDate;
        private TextBox txtHireDate;
    }
}