namespace HOTELAPP
{
    partial class MemberForm
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
            LL_LogOut = new LinkLabel();
            MakeReservationButton = new Button();
            ReservationHistoryButton = new Button();
            ProfileButton = new Button();
            PointShopButton = new Button();
            SuspendLayout();
            // 
            // LL_LogOut
            // 
            LL_LogOut.ActiveLinkColor = Color.CornflowerBlue;
            LL_LogOut.AutoSize = true;
            LL_LogOut.BackColor = Color.Transparent;
            LL_LogOut.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LL_LogOut.LinkArea = new LinkArea(0, 7);
            LL_LogOut.LinkBehavior = LinkBehavior.NeverUnderline;
            LL_LogOut.LinkColor = Color.RoyalBlue;
            LL_LogOut.Location = new Point(55, 60);
            LL_LogOut.Name = "LL_LogOut";
            LL_LogOut.Size = new Size(167, 41);
            LL_LogOut.TabIndex = 20;
            LL_LogOut.TabStop = true;
            LL_LogOut.Text = "Log Out";
            LL_LogOut.LinkClicked += LL_LogOut_LinkClicked;
            // 
            // MakeReservationButton
            // 
            MakeReservationButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MakeReservationButton.Location = new Point(433, 274);
            MakeReservationButton.Name = "MakeReservationButton";
            MakeReservationButton.Size = new Size(308, 141);
            MakeReservationButton.TabIndex = 29;
            MakeReservationButton.Text = "Make a Reservation";
            MakeReservationButton.UseVisualStyleBackColor = true;
            MakeReservationButton.Click += MakeReservationButton_Click;
            // 
            // ReservationHistoryButton
            // 
            ReservationHistoryButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ReservationHistoryButton.Location = new Point(756, 274);
            ReservationHistoryButton.Name = "ReservationHistoryButton";
            ReservationHistoryButton.Size = new Size(308, 141);
            ReservationHistoryButton.TabIndex = 30;
            ReservationHistoryButton.Text = "Reservation History";
            ReservationHistoryButton.UseVisualStyleBackColor = true;
            ReservationHistoryButton.Click += ReservationHistoryButton_Click;
            // 
            // ProfileButton
            // 
            ProfileButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ProfileButton.Location = new Point(756, 421);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(308, 141);
            ProfileButton.TabIndex = 31;
            ProfileButton.Text = "Profile";
            ProfileButton.UseVisualStyleBackColor = true;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // PointShopButton
            // 
            PointShopButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PointShopButton.Location = new Point(433, 421);
            PointShopButton.Name = "PointShopButton";
            PointShopButton.Size = new Size(308, 141);
            PointShopButton.TabIndex = 32;
            PointShopButton.Text = "Point Shop";
            PointShopButton.UseVisualStyleBackColor = true;
            PointShopButton.Click += PointShopButton_Click;
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1447, 817);
            Controls.Add(PointShopButton);
            Controls.Add(ProfileButton);
            Controls.Add(ReservationHistoryButton);
            Controls.Add(MakeReservationButton);
            Controls.Add(LL_LogOut);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MemberForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select";
            FormClosing += MemberForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel LL_LogOut;
        private Button MakeReservationButton;
        private Button ReservationHistoryButton;
        private Button ProfileButton;
        private Button PointShopButton;
    }
}