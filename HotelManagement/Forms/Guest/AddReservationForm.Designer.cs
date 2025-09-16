namespace HOTELAPP
{
    partial class AddReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReservationForm));
            PB_Room1 = new PictureBox();
            PB_Room2 = new PictureBox();
            PB_Room3 = new PictureBox();
            CB_Rooms = new ComboBox();
            DTP_CheckIn = new DateTimePicker();
            DTP_CheckOut = new DateTimePicker();
            TB_Price = new TextBox();
            label1 = new Label();
            TB_RoomInformation1 = new TextBox();
            TB_RoomInformation2 = new TextBox();
            TB_RoomInformation3 = new TextBox();
            CB_RoomType = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            B_GoBack = new Button();
            B_SearchRooms = new Button();
            B_Reserve = new Button();
            ((System.ComponentModel.ISupportInitialize)PB_Room1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_Room2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_Room3).BeginInit();
            SuspendLayout();
            // 
            // PB_Room1
            // 
            PB_Room1.BackgroundImageLayout = ImageLayout.Stretch;
            PB_Room1.Image = Properties.Resources.one_bed_room;
            PB_Room1.Location = new Point(26, 94);
            PB_Room1.Margin = new Padding(3, 4, 3, 4);
            PB_Room1.Name = "PB_Room1";
            PB_Room1.Size = new Size(555, 465);
            PB_Room1.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_Room1.TabIndex = 0;
            PB_Room1.TabStop = false;
            PB_Room1.Visible = false;
            // 
            // PB_Room2
            // 
            PB_Room2.BackgroundImageLayout = ImageLayout.Stretch;
            PB_Room2.Image = Properties.Resources.two_bed_room;
            PB_Room2.Location = new Point(26, 94);
            PB_Room2.Margin = new Padding(3, 4, 3, 4);
            PB_Room2.Name = "PB_Room2";
            PB_Room2.Size = new Size(554, 465);
            PB_Room2.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_Room2.TabIndex = 1;
            PB_Room2.TabStop = false;
            PB_Room2.Visible = false;
            // 
            // PB_Room3
            // 
            PB_Room3.BackgroundImageLayout = ImageLayout.Stretch;
            PB_Room3.Image = Properties.Resources.three_bed_room;
            PB_Room3.Location = new Point(26, 94);
            PB_Room3.Margin = new Padding(3, 4, 3, 4);
            PB_Room3.Name = "PB_Room3";
            PB_Room3.Size = new Size(554, 467);
            PB_Room3.SizeMode = PictureBoxSizeMode.StretchImage;
            PB_Room3.TabIndex = 2;
            PB_Room3.TabStop = false;
            PB_Room3.Visible = false;
            // 
            // CB_Rooms
            // 
            CB_Rooms.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Rooms.Font = new Font("Arial", 15.19F, FontStyle.Regular, GraphicsUnit.Point);
            CB_Rooms.FormattingEnabled = true;
            CB_Rooms.Location = new Point(667, 155);
            CB_Rooms.Margin = new Padding(3, 4, 3, 4);
            CB_Rooms.Name = "CB_Rooms";
            CB_Rooms.Size = new Size(444, 36);
            CB_Rooms.TabIndex = 3;
            CB_Rooms.SelectedIndexChanged += CB_Rooms_SelectedIndexChanged;
            // 
            // DTP_CheckIn
            // 
            DTP_CheckIn.Checked = false;
            DTP_CheckIn.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            DTP_CheckIn.Format = DateTimePickerFormat.Short;
            DTP_CheckIn.Location = new Point(634, 94);
            DTP_CheckIn.Margin = new Padding(3, 4, 3, 4);
            DTP_CheckIn.Name = "DTP_CheckIn";
            DTP_CheckIn.Size = new Size(134, 36);
            DTP_CheckIn.TabIndex = 4;
            DTP_CheckIn.ValueChanged += DTP_CheckIn_ValueChanged;
            // 
            // DTP_CheckOut
            // 
            DTP_CheckOut.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            DTP_CheckOut.Format = DateTimePickerFormat.Short;
            DTP_CheckOut.Location = new Point(774, 93);
            DTP_CheckOut.Margin = new Padding(3, 4, 3, 4);
            DTP_CheckOut.Name = "DTP_CheckOut";
            DTP_CheckOut.Size = new Size(133, 36);
            DTP_CheckOut.TabIndex = 5;
            DTP_CheckOut.VisibleChanged += DTP_CheckOut_VisibleChanged;
            // 
            // TB_Price
            // 
            TB_Price.BorderStyle = BorderStyle.FixedSingle;
            TB_Price.Location = new Point(687, 574);
            TB_Price.Margin = new Padding(3, 4, 3, 4);
            TB_Price.Multiline = true;
            TB_Price.Name = "TB_Price";
            TB_Price.Size = new Size(169, 37);
            TB_Price.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(687, 542);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 7;
            label1.Text = "Price:";
            // 
            // TB_RoomInformation1
            // 
            TB_RoomInformation1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TB_RoomInformation1.Location = new Point(687, 220);
            TB_RoomInformation1.Margin = new Padding(3, 4, 3, 4);
            TB_RoomInformation1.Multiline = true;
            TB_RoomInformation1.Name = "TB_RoomInformation1";
            TB_RoomInformation1.Size = new Size(402, 295);
            TB_RoomInformation1.TabIndex = 8;
            TB_RoomInformation1.Text = resources.GetString("TB_RoomInformation1.Text");
            TB_RoomInformation1.Visible = false;
            // 
            // TB_RoomInformation2
            // 
            TB_RoomInformation2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TB_RoomInformation2.Location = new Point(687, 220);
            TB_RoomInformation2.Margin = new Padding(3, 4, 3, 4);
            TB_RoomInformation2.Multiline = true;
            TB_RoomInformation2.Name = "TB_RoomInformation2";
            TB_RoomInformation2.Size = new Size(402, 299);
            TB_RoomInformation2.TabIndex = 9;
            TB_RoomInformation2.Text = resources.GetString("TB_RoomInformation2.Text");
            TB_RoomInformation2.Visible = false;
            // 
            // TB_RoomInformation3
            // 
            TB_RoomInformation3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TB_RoomInformation3.Location = new Point(687, 221);
            TB_RoomInformation3.Margin = new Padding(3, 4, 3, 4);
            TB_RoomInformation3.Multiline = true;
            TB_RoomInformation3.Name = "TB_RoomInformation3";
            TB_RoomInformation3.Size = new Size(402, 298);
            TB_RoomInformation3.TabIndex = 10;
            TB_RoomInformation3.Text = resources.GetString("TB_RoomInformation3.Text");
            TB_RoomInformation3.Visible = false;
            // 
            // CB_RoomType
            // 
            CB_RoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_RoomType.Font = new Font("Arial", 15.19F, FontStyle.Regular, GraphicsUnit.Point);
            CB_RoomType.FormattingEnabled = true;
            CB_RoomType.Items.AddRange(new object[] { "All", "3 Beds", "2 Beds", "1 Bed" });
            CB_RoomType.Location = new Point(913, 93);
            CB_RoomType.Margin = new Padding(3, 4, 3, 4);
            CB_RoomType.Name = "CB_RoomType";
            CB_RoomType.Size = new Size(100, 36);
            CB_RoomType.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(913, 61);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 15;
            label2.Text = "Choose:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(634, 62);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 16;
            label3.Text = "Check In:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(774, 62);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 17;
            label4.Text = "Check Out:";
            // 
            // B_GoBack
            // 
            B_GoBack.Location = new Point(49, 30);
            B_GoBack.Name = "B_GoBack";
            B_GoBack.Size = new Size(105, 37);
            B_GoBack.TabIndex = 18;
            B_GoBack.Text = "Go Back";
            B_GoBack.UseVisualStyleBackColor = true;
            B_GoBack.Click += B_GoBack_Click;
            // 
            // B_SearchRooms
            // 
            B_SearchRooms.Location = new Point(1019, 93);
            B_SearchRooms.Name = "B_SearchRooms";
            B_SearchRooms.Size = new Size(157, 37);
            B_SearchRooms.TabIndex = 19;
            B_SearchRooms.Text = "Search Rooms";
            B_SearchRooms.UseVisualStyleBackColor = true;
            B_SearchRooms.Click += B_SearchRooms_Click;
            // 
            // B_Reserve
            // 
            B_Reserve.Location = new Point(929, 574);
            B_Reserve.Name = "B_Reserve";
            B_Reserve.Size = new Size(160, 37);
            B_Reserve.TabIndex = 20;
            B_Reserve.Text = "Reserve";
            B_Reserve.UseVisualStyleBackColor = true;
            B_Reserve.Click += B_Reserve_Click;
            // 
            // AddReservationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 695);
            Controls.Add(B_Reserve);
            Controls.Add(B_SearchRooms);
            Controls.Add(B_GoBack);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CB_RoomType);
            Controls.Add(TB_RoomInformation3);
            Controls.Add(TB_RoomInformation2);
            Controls.Add(TB_RoomInformation1);
            Controls.Add(label1);
            Controls.Add(TB_Price);
            Controls.Add(DTP_CheckOut);
            Controls.Add(DTP_CheckIn);
            Controls.Add(CB_Rooms);
            Controls.Add(PB_Room3);
            Controls.Add(PB_Room2);
            Controls.Add(PB_Room1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddReservationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Make Reservation";
            FormClosing += AddReservationForm_FormClosing;
            Load += AddReservationForm_Load;
            ((System.ComponentModel.ISupportInitialize)PB_Room1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_Room2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_Room3).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private PictureBox PB_Room1;
        private PictureBox PB_Room2;
        private PictureBox PB_Room3;
        private ComboBox CB_Rooms;
        private DateTimePicker DTP_CheckIn;
        private DateTimePicker DTP_CheckOut;
        private TextBox TB_Price;
        private Label label1;
        private TextBox TB_RoomInformation1;
        private TextBox TB_RoomInformation2;
        private TextBox TB_RoomInformation3;
        private ComboBox CB_RoomType;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button B_GoBack;
        private Button B_SearchRooms;
        private Button B_Reserve;
    }
}