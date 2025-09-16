namespace HOTELAPP
{
    partial class RegiterForm
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
            label6 = new Label();
            DTP_BirthDate = new DateTimePicker();
            CB_Gender = new ComboBox();
            TB_Password = new TextBox();
            TB_Email = new TextBox();
            TB_Firstname = new TextBox();
            label7 = new Label();
            TB_Surname = new TextBox();
            TB_Username = new TextBox();
            SignInButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(199, 119);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 0;
            label1.Text = "Firstname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(199, 252);
            label2.Name = "label2";
            label2.Size = new Size(130, 32);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Trebuchet MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(199, 380);
            label3.Name = "label3";
            label3.Size = new Size(100, 32);
            label3.TabIndex = 2;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(915, 119);
            label4.Name = "label4";
            label4.Size = new Size(85, 32);
            label4.TabIndex = 3;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Trebuchet MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(915, 252);
            label5.Name = "label5";
            label5.Size = new Size(133, 32);
            label5.TabIndex = 4;
            label5.Text = "Birth Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Trebuchet MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(915, 380);
            label6.Name = "label6";
            label6.Size = new Size(123, 32);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // DTP_BirthDate
            // 
            DTP_BirthDate.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            DTP_BirthDate.Format = DateTimePickerFormat.Short;
            DTP_BirthDate.Location = new Point(915, 292);
            DTP_BirthDate.Margin = new Padding(3, 4, 3, 4);
            DTP_BirthDate.Name = "DTP_BirthDate";
            DTP_BirthDate.Size = new Size(305, 52);
            DTP_BirthDate.TabIndex = 6;
            // 
            // CB_Gender
            // 
            CB_Gender.AccessibleRole = AccessibleRole.ScrollBar;
            CB_Gender.AllowDrop = true;
            CB_Gender.CausesValidation = false;
            CB_Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Gender.FlatStyle = FlatStyle.Popup;
            CB_Gender.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CB_Gender.FormattingEnabled = true;
            CB_Gender.ItemHeight = 45;
            CB_Gender.Items.AddRange(new object[] { "Male", "Female", "Other", "Do Not Specify" });
            CB_Gender.Location = new Point(199, 419);
            CB_Gender.Margin = new Padding(3, 4, 3, 4);
            CB_Gender.Name = "CB_Gender";
            CB_Gender.Size = new Size(307, 53);
            CB_Gender.TabIndex = 7;
            // 
            // TB_Password
            // 
            TB_Password.BorderStyle = BorderStyle.FixedSingle;
            TB_Password.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Password.Location = new Point(915, 419);
            TB_Password.Margin = new Padding(3, 4, 3, 4);
            TB_Password.Name = "TB_Password";
            TB_Password.PasswordChar = '*';
            TB_Password.Size = new Size(305, 52);
            TB_Password.TabIndex = 8;
            TB_Password.UseSystemPasswordChar = true;
            // 
            // TB_Email
            // 
            TB_Email.BorderStyle = BorderStyle.FixedSingle;
            TB_Email.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Email.Location = new Point(915, 157);
            TB_Email.Margin = new Padding(3, 4, 3, 4);
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new Size(305, 52);
            TB_Email.TabIndex = 9;
            // 
            // TB_Firstname
            // 
            TB_Firstname.BorderStyle = BorderStyle.FixedSingle;
            TB_Firstname.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Firstname.Location = new Point(199, 157);
            TB_Firstname.Margin = new Padding(3, 4, 3, 4);
            TB_Firstname.Name = "TB_Firstname";
            TB_Firstname.Size = new Size(307, 52);
            TB_Firstname.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Trebuchet MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(562, 119);
            label7.Name = "label7";
            label7.Size = new Size(116, 32);
            label7.TabIndex = 14;
            label7.Text = "Surname";
            // 
            // TB_Surname
            // 
            TB_Surname.BorderStyle = BorderStyle.FixedSingle;
            TB_Surname.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Surname.Location = new Point(562, 157);
            TB_Surname.Margin = new Padding(3, 4, 3, 4);
            TB_Surname.Name = "TB_Surname";
            TB_Surname.Size = new Size(305, 52);
            TB_Surname.TabIndex = 15;
            // 
            // TB_Username
            // 
            TB_Username.BorderStyle = BorderStyle.FixedSingle;
            TB_Username.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Username.Location = new Point(199, 296);
            TB_Username.Margin = new Padding(3, 4, 3, 4);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(305, 52);
            TB_Username.TabIndex = 16;
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(668, 572);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(139, 44);
            SignInButton.TabIndex = 17;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // RegiterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 817);
            Controls.Add(SignInButton);
            Controls.Add(TB_Username);
            Controls.Add(TB_Surname);
            Controls.Add(label7);
            Controls.Add(TB_Firstname);
            Controls.Add(TB_Email);
            Controls.Add(TB_Password);
            Controls.Add(CB_Gender);
            Controls.Add(DTP_BirthDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegiterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker DTP_BirthDate;
        private ComboBox CB_Gender;
        private TextBox TB_Password;
        private TextBox TB_Email;
        private TextBox TB_Firstname;
        private Label label7;
        private TextBox TB_Surname;
        private TextBox TB_Username;
        private Button SignInButton;
    }
}