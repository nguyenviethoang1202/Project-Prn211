namespace Project_Prn211
{
    partial class LibrarySystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarySystem));
            pHeader = new Panel();
            lbHome = new Label();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            lbFullname = new Label();
            pLeft = new Panel();
            btnUser = new Button();
            btnLibrary = new Button();
            btnMyHiredBook = new Button();
            btnInfoForm = new Button();
            pBody = new Panel();
            pictureBox2 = new PictureBox();
            pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pLeft.SuspendLayout();
            pBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pHeader
            // 
            pHeader.BackColor = SystemColors.MenuHighlight;
            pHeader.Controls.Add(lbHome);
            pHeader.Controls.Add(pictureBox1);
            pHeader.Controls.Add(btnLogout);
            pHeader.Controls.Add(lbFullname);
            pHeader.Dock = DockStyle.Top;
            pHeader.Location = new Point(0, 0);
            pHeader.Name = "pHeader";
            pHeader.Size = new Size(1454, 61);
            pHeader.TabIndex = 0;
            // 
            // lbHome
            // 
            lbHome.AutoSize = true;
            lbHome.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbHome.Location = new Point(169, 9);
            lbHome.Name = "lbHome";
            lbHome.Size = new Size(109, 46);
            lbHome.TabIndex = 3;
            lbHome.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Home;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(1304, 16);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lbFullname
            // 
            lbFullname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbFullname.AutoSize = true;
            lbFullname.Location = new Point(1119, 20);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new Size(50, 20);
            lbFullname.TabIndex = 0;
            lbFullname.Text = "label1";
            // 
            // pLeft
            // 
            pLeft.BackColor = SystemColors.MenuHighlight;
            pLeft.Controls.Add(btnUser);
            pLeft.Controls.Add(btnLibrary);
            pLeft.Controls.Add(btnMyHiredBook);
            pLeft.Controls.Add(btnInfoForm);
            pLeft.Dock = DockStyle.Left;
            pLeft.Location = new Point(0, 61);
            pLeft.Name = "pLeft";
            pLeft.Size = new Size(120, 617);
            pLeft.TabIndex = 1;
            // 
            // btnUser
            // 
            btnUser.Dock = DockStyle.Top;
            btnUser.Location = new Point(0, 174);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(120, 58);
            btnUser.TabIndex = 3;
            btnUser.Text = "User management";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnLibrary
            // 
            btnLibrary.Dock = DockStyle.Top;
            btnLibrary.Location = new Point(0, 116);
            btnLibrary.Name = "btnLibrary";
            btnLibrary.Size = new Size(120, 58);
            btnLibrary.TabIndex = 2;
            btnLibrary.Text = "Library";
            btnLibrary.UseVisualStyleBackColor = true;
            btnLibrary.Click += btnLibrary_Click;
            // 
            // btnMyHiredBook
            // 
            btnMyHiredBook.Dock = DockStyle.Top;
            btnMyHiredBook.Location = new Point(0, 58);
            btnMyHiredBook.Name = "btnMyHiredBook";
            btnMyHiredBook.Size = new Size(120, 58);
            btnMyHiredBook.TabIndex = 1;
            btnMyHiredBook.Text = "My Hired Book";
            btnMyHiredBook.UseVisualStyleBackColor = true;
            btnMyHiredBook.Click += btnMyHiredBook_Click;
            // 
            // btnInfoForm
            // 
            btnInfoForm.Dock = DockStyle.Top;
            btnInfoForm.Location = new Point(0, 0);
            btnInfoForm.Name = "btnInfoForm";
            btnInfoForm.Size = new Size(120, 58);
            btnInfoForm.TabIndex = 0;
            btnInfoForm.Text = "My Info";
            btnInfoForm.UseVisualStyleBackColor = true;
            btnInfoForm.Click += btnInfoForm_Click;
            // 
            // pBody
            // 
            pBody.Controls.Add(pictureBox2);
            pBody.Dock = DockStyle.Fill;
            pBody.Location = new Point(120, 61);
            pBody.Name = "pBody";
            pBody.Size = new Size(1334, 617);
            pBody.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.center;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1334, 617);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // LibrarySystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 678);
            Controls.Add(pBody);
            Controls.Add(pLeft);
            Controls.Add(pHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LibrarySystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library System";
            FormClosing += LibrarySystem_FormClosing;
            pHeader.ResumeLayout(false);
            pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pLeft.ResumeLayout(false);
            pBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pHeader;
        private Panel pLeft;
        private Panel pBody;
        private Button btnInfoForm;
        private Label lbFullname;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button4;
        private Button btnUser;
        private Button btnLibrary;
        private Button btnMyHiredBook;
        private Label label1;
        private Label lbHome;
    }
}