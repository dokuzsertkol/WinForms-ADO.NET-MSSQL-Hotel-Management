namespace HOTELAPP
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            LoginButton = new Button();
            ShowPassWordCheckBox = new CheckBox();
            SignUpLinkLabel = new LinkLabel();
            label3 = new Label();
            TB_Password = new TextBox();
            TB_Username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(ShowPassWordCheckBox);
            panel1.Controls.Add(SignUpLinkLabel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TB_Password);
            panel1.Controls.Add(TB_Username);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Cursor = Cursors.IBeam;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(455, 104);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 638);
            panel1.TabIndex = 0;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(53, 408);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 9;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += Login;
            // 
            // ShowPassWordCheckBox
            // 
            ShowPassWordCheckBox.AutoSize = true;
            ShowPassWordCheckBox.BackColor = Color.Transparent;
            ShowPassWordCheckBox.ForeColor = Color.RoyalBlue;
            ShowPassWordCheckBox.Location = new Point(278, 408);
            ShowPassWordCheckBox.Margin = new Padding(3, 4, 3, 4);
            ShowPassWordCheckBox.Name = "ShowPassWordCheckBox";
            ShowPassWordCheckBox.Size = new Size(132, 24);
            ShowPassWordCheckBox.TabIndex = 8;
            ShowPassWordCheckBox.Text = "Show Password";
            ShowPassWordCheckBox.UseVisualStyleBackColor = false;
            ShowPassWordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // SignUpLinkLabel
            // 
            SignUpLinkLabel.ActiveLinkColor = Color.PaleTurquoise;
            SignUpLinkLabel.AutoSize = true;
            SignUpLinkLabel.BackColor = Color.Transparent;
            SignUpLinkLabel.LinkColor = Color.RoyalBlue;
            SignUpLinkLabel.Location = new Point(196, 532);
            SignUpLinkLabel.Name = "SignUpLinkLabel";
            SignUpLinkLabel.Size = new Size(97, 20);
            SignUpLinkLabel.TabIndex = 6;
            SignUpLinkLabel.TabStop = true;
            SignUpLinkLabel.Text = "Sign Up here.";
            SignUpLinkLabel.LinkClicked += SignUpLinkLabel_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.AntiqueWhite;
            label3.Location = new Point(130, 532);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 5;
            label3.Text = "Are you new?";
            // 
            // TB_Password
            // 
            TB_Password.AcceptsReturn = true;
            TB_Password.AcceptsTab = true;
            TB_Password.BorderStyle = BorderStyle.FixedSingle;
            TB_Password.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Password.Location = new Point(53, 327);
            TB_Password.Margin = new Padding(3, 4, 3, 4);
            TB_Password.Name = "TB_Password";
            TB_Password.PasswordChar = '*';
            TB_Password.Size = new Size(357, 52);
            TB_Password.TabIndex = 3;
            // 
            // TB_Username
            // 
            TB_Username.AcceptsReturn = true;
            TB_Username.AcceptsTab = true;
            TB_Username.BorderStyle = BorderStyle.FixedSingle;
            TB_Username.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Username.Location = new Point(53, 163);
            TB_Username.Margin = new Padding(3, 4, 3, 4);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(357, 52);
            TB_Username.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(53, 276);
            label2.Name = "label2";
            label2.Size = new Size(120, 36);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Heading", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(53, 109);
            label1.Name = "label1";
            label1.Size = new Size(127, 36);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.hotel_image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1424, 812);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TB_Username;
        private Label label2;
        private Label label1;
        private LinkLabel SignUpLinkLabel;
        private Label label3;
        protected TextBox TB_Password;
        private CheckBox ShowPassWordCheckBox;
        private Button LoginButton;
    }
}