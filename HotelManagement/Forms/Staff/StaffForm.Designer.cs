namespace HOTELAPP
{
    partial class StaffForm
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
            label1 = new Label();
            CB_Rooms = new ComboBox();
            B_SetAvaliable = new Button();
            B_SetMaintenance = new Button();
            SuspendLayout();
            // 
            // LL_LogOut
            // 
            LL_LogOut.ActiveLinkColor = Color.CornflowerBlue;
            LL_LogOut.AutoSize = true;
            LL_LogOut.BackColor = Color.Transparent;
            LL_LogOut.DisabledLinkColor = Color.MidnightBlue;
            LL_LogOut.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LL_LogOut.LinkArea = new LinkArea(0, 7);
            LL_LogOut.LinkBehavior = LinkBehavior.NeverUnderline;
            LL_LogOut.LinkColor = Color.RoyalBlue;
            LL_LogOut.Location = new Point(68, 39);
            LL_LogOut.Name = "LL_LogOut";
            LL_LogOut.Size = new Size(167, 41);
            LL_LogOut.TabIndex = 21;
            LL_LogOut.TabStop = true;
            LL_LogOut.Text = "Log Out";
            LL_LogOut.LinkClicked += LL_LogOut_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(601, 207);
            label1.Name = "label1";
            label1.Size = new Size(226, 32);
            label1.TabIndex = 22;
            label1.Text = "Choose Room Type:";
            // 
            // CB_Rooms
            // 
            CB_Rooms.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Rooms.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CB_Rooms.FormattingEnabled = true;
            CB_Rooms.Location = new Point(572, 253);
            CB_Rooms.Name = "CB_Rooms";
            CB_Rooms.Size = new Size(301, 39);
            CB_Rooms.TabIndex = 23;
            // 
            // B_SetAvaliable
            // 
            B_SetAvaliable.Location = new Point(572, 379);
            B_SetAvaliable.Name = "B_SetAvaliable";
            B_SetAvaliable.Size = new Size(128, 29);
            B_SetAvaliable.TabIndex = 24;
            B_SetAvaliable.Text = "Set Avaliable";
            B_SetAvaliable.UseVisualStyleBackColor = true;
            B_SetAvaliable.Click += B_SetAvaliable_Click;
            // 
            // B_SetMaintenance
            // 
            B_SetMaintenance.Location = new Point(745, 379);
            B_SetMaintenance.Name = "B_SetMaintenance";
            B_SetMaintenance.Size = new Size(128, 29);
            B_SetMaintenance.TabIndex = 25;
            B_SetMaintenance.Text = "Set Maintenance";
            B_SetMaintenance.UseVisualStyleBackColor = true;
            B_SetMaintenance.Click += B_SetMaintenance_Click;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1514, 848);
            Controls.Add(B_SetMaintenance);
            Controls.Add(B_SetAvaliable);
            Controls.Add(CB_Rooms);
            Controls.Add(label1);
            Controls.Add(LL_LogOut);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StaffForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            FormClosing += StaffForm_FormClosing;
            Load += Staff_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private LinkLabel LL_LogOut;
        private Label label1;
        private ComboBox CB_Rooms;
        private Button B_SetAvaliable;
        private Button B_SetMaintenance;
    }
}