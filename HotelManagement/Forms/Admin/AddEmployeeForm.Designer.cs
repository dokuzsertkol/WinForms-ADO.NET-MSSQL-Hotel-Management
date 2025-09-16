namespace HOTELAPP
{
    partial class AddEmployeeForm
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
            TB_Username = new TextBox();
            TB_Surname = new TextBox();
            TB_Firstname = new TextBox();
            TB_Password = new TextBox();
            DTP_Birth = new DateTimePicker();
            CB_Gender = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            CB_Role = new ComboBox();
            label7 = new Label();
            TB_Email = new TextBox();
            label8 = new Label();
            B_Add = new Button();
            B_GoBack = new Button();
            SuspendLayout();
            // 
            // TB_Username
            // 
            TB_Username.BackColor = SystemColors.Window;
            TB_Username.ForeColor = SystemColors.WindowText;
            TB_Username.Location = new Point(205, 159);
            TB_Username.Margin = new Padding(3, 4, 3, 4);
            TB_Username.Multiline = true;
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(260, 39);
            TB_Username.TabIndex = 0;
            // 
            // TB_Surname
            // 
            TB_Surname.BackColor = SystemColors.Window;
            TB_Surname.ForeColor = SystemColors.WindowText;
            TB_Surname.Location = new Point(875, 159);
            TB_Surname.Margin = new Padding(3, 4, 3, 4);
            TB_Surname.Multiline = true;
            TB_Surname.Name = "TB_Surname";
            TB_Surname.Size = new Size(260, 39);
            TB_Surname.TabIndex = 1;
            // 
            // TB_Firstname
            // 
            TB_Firstname.BackColor = SystemColors.Window;
            TB_Firstname.ForeColor = SystemColors.WindowText;
            TB_Firstname.Location = new Point(542, 159);
            TB_Firstname.Margin = new Padding(3, 4, 3, 4);
            TB_Firstname.Multiline = true;
            TB_Firstname.Name = "TB_Firstname";
            TB_Firstname.Size = new Size(260, 39);
            TB_Firstname.TabIndex = 2;
            // 
            // TB_Password
            // 
            TB_Password.BackColor = SystemColors.Window;
            TB_Password.ForeColor = SystemColors.WindowText;
            TB_Password.Location = new Point(205, 305);
            TB_Password.Margin = new Padding(3, 4, 3, 4);
            TB_Password.Multiline = true;
            TB_Password.Name = "TB_Password";
            TB_Password.Size = new Size(260, 39);
            TB_Password.TabIndex = 3;
            // 
            // DTP_Birth
            // 
            DTP_Birth.CalendarFont = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DTP_Birth.CalendarMonthBackground = Color.RoyalBlue;
            DTP_Birth.CalendarTitleBackColor = Color.RoyalBlue;
            DTP_Birth.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DTP_Birth.Format = DateTimePickerFormat.Custom;
            DTP_Birth.Location = new Point(875, 305);
            DTP_Birth.Margin = new Padding(3, 4, 3, 4);
            DTP_Birth.Name = "DTP_Birth";
            DTP_Birth.Size = new Size(260, 39);
            DTP_Birth.TabIndex = 4;
            // 
            // CB_Gender
            // 
            CB_Gender.BackColor = SystemColors.Control;
            CB_Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Gender.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CB_Gender.FormattingEnabled = true;
            CB_Gender.Items.AddRange(new object[] { "Male ", "Female", "Other", "Do Not Specify" });
            CB_Gender.Location = new Point(205, 442);
            CB_Gender.Margin = new Padding(3, 4, 3, 4);
            CB_Gender.Name = "CB_Gender";
            CB_Gender.Size = new Size(260, 39);
            CB_Gender.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(205, 128);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 6;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(875, 127);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 7;
            label2.Text = "Surname :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(875, 273);
            label3.Name = "label3";
            label3.Size = new Size(62, 28);
            label3.TabIndex = 8;
            label3.Text = "Birth :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(542, 128);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 9;
            label4.Text = "Firstname :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(205, 273);
            label5.Name = "label5";
            label5.Size = new Size(102, 28);
            label5.TabIndex = 10;
            label5.Text = "Password :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(205, 410);
            label6.Name = "label6";
            label6.Size = new Size(85, 28);
            label6.TabIndex = 11;
            label6.Text = "Gender :";
            // 
            // CB_Role
            // 
            CB_Role.BackColor = SystemColors.Control;
            CB_Role.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Role.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CB_Role.FormattingEnabled = true;
            CB_Role.Items.AddRange(new object[] { "Staff", "Manager" });
            CB_Role.Location = new Point(542, 442);
            CB_Role.Margin = new Padding(3, 4, 3, 4);
            CB_Role.Name = "CB_Role";
            CB_Role.Size = new Size(260, 39);
            CB_Role.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(542, 410);
            label7.Name = "label7";
            label7.Size = new Size(59, 28);
            label7.TabIndex = 14;
            label7.Text = "Role :";
            // 
            // TB_Email
            // 
            TB_Email.BackColor = SystemColors.Window;
            TB_Email.ForeColor = SystemColors.WindowText;
            TB_Email.Location = new Point(542, 305);
            TB_Email.Margin = new Padding(3, 4, 3, 4);
            TB_Email.Multiline = true;
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new Size(260, 39);
            TB_Email.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(542, 274);
            label8.Name = "label8";
            label8.Size = new Size(76, 28);
            label8.TabIndex = 16;
            label8.Text = "E-mail :";
            // 
            // B_Add
            // 
            B_Add.ForeColor = SystemColors.ControlText;
            B_Add.Location = new Point(603, 540);
            B_Add.Name = "B_Add";
            B_Add.Size = new Size(164, 47);
            B_Add.TabIndex = 17;
            B_Add.Text = "Add";
            B_Add.UseVisualStyleBackColor = true;
            B_Add.Click += B_Add_Click;
            // 
            // B_GoBack
            // 
            B_GoBack.ForeColor = SystemColors.ControlText;
            B_GoBack.Location = new Point(70, 43);
            B_GoBack.Name = "B_GoBack";
            B_GoBack.Size = new Size(127, 52);
            B_GoBack.TabIndex = 18;
            B_GoBack.Text = "Go Back";
            B_GoBack.UseVisualStyleBackColor = true;
            B_GoBack.Click += B_GoBack_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1333, 792);
            Controls.Add(B_GoBack);
            Controls.Add(B_Add);
            Controls.Add(label8);
            Controls.Add(TB_Email);
            Controls.Add(label7);
            Controls.Add(CB_Role);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CB_Gender);
            Controls.Add(DTP_Birth);
            Controls.Add(TB_Password);
            Controls.Add(TB_Firstname);
            Controls.Add(TB_Surname);
            Controls.Add(TB_Username);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddEmployeeForm";
            Text = "Add Employee";
            FormClosing += AddEmployeeForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private TextBox TB_Surname;
        private TextBox TB_Firstname;
        private TextBox TB_Password;
        private DateTimePicker DTP_Birth;
        private ComboBox CB_Gender;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox CB_Role;
        private Label label7;
        private TextBox TB_Email;
        private Label label8;
        private Button B_Add;
        private Button B_GoBack;
        private TextBox TB_Username;
    }
}