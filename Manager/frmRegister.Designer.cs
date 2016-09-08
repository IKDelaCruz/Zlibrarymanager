namespace Manager
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentEmployeeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(220, 254);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Sign Up";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(23, 118);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(121, 22);
            this.txtFirstname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name";
            // 
            // txtStudentEmployeeId
            // 
            this.txtStudentEmployeeId.Location = new System.Drawing.Point(23, 77);
            this.txtStudentEmployeeId.Name = "txtStudentEmployeeId";
            this.txtStudentEmployeeId.Size = new System.Drawing.Size(179, 22);
            this.txtStudentEmployeeId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student / Employee ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(139, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbxGender
            // 
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cbxGender.Location = new System.Drawing.Point(23, 200);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(121, 21);
            this.cbxGender.TabIndex = 5;
            this.cbxGender.SelectedIndexChanged += new System.EventHandler(this.cbxGender_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "User Type";
            // 
            // cbxUserType
            // 
            this.cbxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Items.AddRange(new object[] {
            "Student",
            "Faculty",
            "NonTeachingPersonel"});
            this.cbxUserType.Location = new System.Drawing.Point(234, 200);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(121, 21);
            this.cbxUserType.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(234, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(234, 118);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(179, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Password";
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(234, 159);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Size = new System.Drawing.Size(179, 22);
            this.txtRepeatPassword.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Confirm Password";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(20, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(393, 42);
            this.label8.TabIndex = 22;
            this.label8.Text = "By clicking Sign Up, you agree to our Terms and that you have read our Data Polic" +
    "y, including our Cookie Use.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 45);
            this.label9.TabIndex = 23;
            this.label9.Text = "Sign Up";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(23, 159);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(179, 22);
            this.txtLastName.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Last Name";
            // 
            // txtMI
            // 
            this.txtMI.Location = new System.Drawing.Point(150, 118);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(52, 22);
            this.txtMI.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "M.I.";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 371);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMI);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxUserType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudentEmployeeId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentEmployeeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxUserType;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.Label label11;
    }
}