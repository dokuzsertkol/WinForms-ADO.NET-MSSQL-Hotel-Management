namespace HOTELAPP
{
    partial class ReservationHistoryForm
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
            CB_Active = new ComboBox();
            CB_Old = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            BB_GoBack = new Button();
            SuspendLayout();
            // 
            // CB_Active
            // 
            CB_Active.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Active.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            CB_Active.FormattingEnabled = true;
            CB_Active.Location = new Point(430, 157);
            CB_Active.Margin = new Padding(3, 4, 3, 4);
            CB_Active.Name = "CB_Active";
            CB_Active.Size = new Size(508, 53);
            CB_Active.TabIndex = 18;
            // 
            // CB_Old
            // 
            CB_Old.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Old.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            CB_Old.FormattingEnabled = true;
            CB_Old.Location = new Point(430, 440);
            CB_Old.Margin = new Padding(3, 4, 3, 4);
            CB_Old.Name = "CB_Old";
            CB_Old.Size = new Size(508, 53);
            CB_Old.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(430, 96);
            label1.Name = "label1";
            label1.Size = new Size(382, 57);
            label1.TabIndex = 20;
            label1.Text = "Active Reservations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(430, 379);
            label2.Name = "label2";
            label2.Size = new Size(337, 57);
            label2.TabIndex = 21;
            label2.Text = "Old Reservations";
            // 
            // BB_GoBack
            // 
            BB_GoBack.Location = new Point(68, 40);
            BB_GoBack.Name = "BB_GoBack";
            BB_GoBack.Size = new Size(143, 48);
            BB_GoBack.TabIndex = 22;
            BB_GoBack.Text = "Go Back";
            BB_GoBack.UseVisualStyleBackColor = true;
            BB_GoBack.Click += BB_GoBack_Click;
            // 
            // ReservationHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 825);
            Controls.Add(BB_GoBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CB_Old);
            Controls.Add(CB_Active);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReservationHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation History";
            FormClosing += ReservationHistoryForm_FormClosing;
            Load += ReservationHistory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox CB_Active;
        private ComboBox CB_Old;
        private Label label1;
        private Label label2;
        private Button BB_GoBack;
    }
}