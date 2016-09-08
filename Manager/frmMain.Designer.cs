namespace Manager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initializeBookListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAvailableBooks = new System.Windows.Forms.Label();
            this.lblBorrowedBooks = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dvAvailable = new System.Windows.Forms.DataGridView();
            this.dvBorrowed = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvBorrowed)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.userToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.registerToolStripMenuItem.Text = "Sign Up";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(112, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializeBookListToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.userToolStripMenuItem.Text = "Edit";
            // 
            // initializeBookListToolStripMenuItem
            // 
            this.initializeBookListToolStripMenuItem.Name = "initializeBookListToolStripMenuItem";
            this.initializeBookListToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.initializeBookListToolStripMenuItem.Text = "Initialize Book List && Users";
            this.initializeBookListToolStripMenuItem.Click += new System.EventHandler(this.initializeBookListToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblAvailableBooks
            // 
            this.lblAvailableBooks.AutoSize = true;
            this.lblAvailableBooks.Location = new System.Drawing.Point(12, 56);
            this.lblAvailableBooks.Name = "lblAvailableBooks";
            this.lblAvailableBooks.Size = new System.Drawing.Size(91, 13);
            this.lblAvailableBooks.TabIndex = 8;
            this.lblAvailableBooks.Text = "Available Books ";
            // 
            // lblBorrowedBooks
            // 
            this.lblBorrowedBooks.AutoSize = true;
            this.lblBorrowedBooks.Location = new System.Drawing.Point(12, 368);
            this.lblBorrowedBooks.Name = "lblBorrowedBooks";
            this.lblBorrowedBooks.Size = new System.Drawing.Size(118, 13);
            this.lblBorrowedBooks.TabIndex = 10;
            this.lblBorrowedBooks.Text = "Your Borrowed Books";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(897, 343);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnBorrow.TabIndex = 12;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(204, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(768, 45);
            this.lblWelcome.TabIndex = 25;
            this.lblWelcome.Text = "Please Login to use this Application";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dvAvailable
            // 
            this.dvAvailable.AllowUserToAddRows = false;
            this.dvAvailable.AllowUserToDeleteRows = false;
            this.dvAvailable.AllowUserToOrderColumns = true;
            this.dvAvailable.AllowUserToResizeRows = false;
            this.dvAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvAvailable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvAvailable.Location = new System.Drawing.Point(12, 72);
            this.dvAvailable.MultiSelect = false;
            this.dvAvailable.Name = "dvAvailable";
            this.dvAvailable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvAvailable.Size = new System.Drawing.Size(960, 265);
            this.dvAvailable.TabIndex = 26;
            // 
            // dvBorrowed
            // 
            this.dvBorrowed.AllowUserToAddRows = false;
            this.dvBorrowed.AllowUserToDeleteRows = false;
            this.dvBorrowed.AllowUserToOrderColumns = true;
            this.dvBorrowed.AllowUserToResizeRows = false;
            this.dvBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvBorrowed.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvBorrowed.Location = new System.Drawing.Point(12, 384);
            this.dvBorrowed.MultiSelect = false;
            this.dvBorrowed.Name = "dvBorrowed";
            this.dvBorrowed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvBorrowed.Size = new System.Drawing.Size(960, 136);
            this.dvBorrowed.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(816, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Borrow";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dvBorrowed);
            this.Controls.Add(this.dvAvailable);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.lblBorrowedBooks);
            this.Controls.Add(this.lblAvailableBooks);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simplified Library System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvBorrowed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Label lblAvailableBooks;
        private System.Windows.Forms.Label lblBorrowedBooks;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dvAvailable;
        private System.Windows.Forms.DataGridView dvBorrowed;
        private System.Windows.Forms.ToolStripMenuItem initializeBookListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button button2;
    }
}

