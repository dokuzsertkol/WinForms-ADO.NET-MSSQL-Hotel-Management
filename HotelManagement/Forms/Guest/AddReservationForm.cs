using HOTELAPP.Helpers;
using System.Data.SqlClient;

namespace HOTELAPP
{
    public partial class AddReservationForm : Form
    {
        bool isOtherFormActive = false;
        private readonly string username;

        public AddReservationForm(string user)
        {
            InitializeComponent();

            DTP_CheckIn.MinDate = DateTime.Now;
            DTP_CheckOut.MinDate = DateTime.Now;
            username = user;
        }

        private void B_GoBack_Click(object sender, EventArgs e)
        {
            isOtherFormActive = true;
            MemberForm member = new MemberForm(username);
            member.Show();
            this.Close();
        }

        private void B_SearchRooms_Click(object sender, EventArgs e)
        {
            string? bedCountStr = CB_RoomType.SelectedItem.ToString();
            if (bedCountStr == null) return;

            CB_Rooms.Items.Clear();
            CB_Rooms.Items.Insert(0, "Please Select a Room Type");
            CB_Rooms.SelectedIndex = 0;

            int bedCount = 0;
            switch (bedCountStr)
            {
                case "All":
                    bedCount = 0;
                    break;
                case "1 Bed":
                    bedCount = 1;
                    break;
                case "2 Beds":
                    bedCount = 2;
                    break;
                case "3 Beds":
                    bedCount = 3;
                    break;
            }

            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
            SqlCommand command = new SqlCommand();

            if (bedCountStr == "All") command = new SqlCommand("SELECT room_id, price FROM [RoomInventory] WHERE status = 1", sqlConnection.Sql);
            else
            {
                command = new SqlCommand("SELECT room_id, price FROM [RoomInventory] WHERE capacity = @bed AND status = 1", sqlConnection.Sql);
                command.Parameters.AddWithValue("@bed", bedCount);
            }
            SqlDataReader reader = command.ExecuteReader();

            List<string> roomids = new List<string>();
            while (reader.Read())
            {
                roomids.Add(reader[0].ToString());
            }
            reader.Close();

            command = new SqlCommand("SELECT room_id, check_in_date, check_out_date FROM [Reservation]", sqlConnection.Sql);
            reader = command.ExecuteReader();

            DateTime dateIn = DTP_CheckIn.Value.Date;
            DateTime dateOut = DTP_CheckOut.Value.Date;

            while (reader.Read())
            {
                DateTime resIn = reader.GetDateTime(1);
                DateTime resOut = reader.GetDateTime(2);

                if ((resIn <= dateIn && resOut >= dateIn) || (resIn <= dateOut && resOut >= dateOut))
                    roomids.Remove(reader[0].ToString());

            }
            reader.Close();

            command = new SqlCommand("SELECT room_type FROM [RoomInventory] WHERE room_id = @id", sqlConnection.Sql);
            foreach (string type in roomids)
            {
                command.Parameters.AddWithValue("@id", type);
                reader = command.ExecuteReader();
                reader.Read();
                CB_Rooms.Items.Add(reader[0]);
                reader.Close();
                command.Parameters.Clear();
            }

            sqlConnection.Sql.Close();
        }

        private void B_Reserve_Click(object sender, EventArgs e)
        {
            try
            {
                int index = CB_Rooms.SelectedIndex - 1;
                if (index == -1) return;
                DateTime dateIn = DTP_CheckIn.Value.Date;
                DateTime dateOut = DTP_CheckOut.Value.Date;
                string dateInStr = dateIn.ToString();
                string dateOutStr = dateOut.ToString();

                ConfigureSQL sqlConnection = new ConfigureSQL();
                sqlConnection.Sql.Open();

                SqlCommand command = new SqlCommand("SELECT room_id FROM [RoomInventory] WHERE room_type = @roomname", sqlConnection.Sql);
                string roomName;

                roomName = CB_Rooms.SelectedItem.ToString();

                command.Parameters.AddWithValue("@roomname", roomName);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string room = reader[0].ToString();
                int roomid = int.Parse(room);
                reader.Close();

                command = new SqlCommand("SELECT * FROM [ReservationIDCounter]", sqlConnection.Sql); // unique id for reservation
                reader = command.ExecuteReader();
                reader.Read();
                int reservationId = int.Parse(reader[0].ToString()) + 1;
                reader.Close();

                command = new SqlCommand("INSERT INTO [Reservation] (reservation_id,guestname,room_id,check_in_date,check_out_date) values (@resid,@guest,@roomid,@in,@out)", sqlConnection.Sql);
                command.Parameters.AddWithValue("@resid", reservationId);
                command.Parameters.AddWithValue("@guest", username);
                command.Parameters.AddWithValue("@roomid", roomid);
                command.Parameters.AddWithValue("@in", dateIn);
                command.Parameters.AddWithValue("@out", dateOut);
                command.ExecuteNonQuery(); // also adds loyalty points with trigger

                command = new SqlCommand("EXEC NewID", sqlConnection.Sql); // stored procedure
                command.ExecuteNonQuery();

                CB_Rooms.Items.Clear();
                CB_Rooms.Items.Insert(0, "Please Select a Room Type");
                CB_Rooms.SelectedIndex = 0;

                command.Parameters.Clear();
                command = new SqlCommand("SELECT email FROM [User] WHERE username = @user", sqlConnection.Sql);
                command.Parameters.AddWithValue("@user", username);
                reader = command.ExecuteReader();
                reader.Read();
                string guestMail = reader[0].ToString();
                reader.Close();

                sqlConnection.Sql.Close();

                MessageBox.Show("Reservation complete (+5 points)");
            }
            catch (Exception Ex)
            {
                return;
            }
        }

        private void DTP_CheckIn_ValueChanged(object sender, EventArgs e)
        {
            DTP_CheckOut.MinDate = DTP_CheckIn.Value.Date;
            CB_Rooms.SelectedIndex = -1;
        }

        private void DTP_CheckOut_VisibleChanged(object sender, EventArgs e)
        {
            CB_Rooms.SelectedIndex = -1;
        }

        private void AddReservationForm_Load(object sender, EventArgs e)
        {
            CB_Rooms.Items.Insert(0, "Please Select a Room Type");
            CB_Rooms.SelectedIndex = 0;
            CB_RoomType.SelectedIndex = 0;
            TB_RoomInformation1.ReadOnly = true;
            TB_RoomInformation2.ReadOnly = true;
            TB_RoomInformation3.ReadOnly = true;
            TB_Price.ReadOnly = true;
        }

        private void AddReservationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isOtherFormActive) Application.Exit();
        }

        private void CB_Rooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            PB_Room1.Visible = false;
            PB_Room2.Visible = false;
            PB_Room3.Visible = false;
            TB_RoomInformation2.Visible = false;
            TB_RoomInformation1.Visible = false;
            TB_RoomInformation3.Visible = false;
            TB_Price.Visible = false;

            if (CB_Rooms.SelectedIndex != -1 && CB_Rooms.SelectedIndex != 0)
            {
                ConfigureSQL sqlConnection = new ConfigureSQL();
                sqlConnection.Sql.Open();
                SqlCommand command = new SqlCommand("SELECT price FROM [RoomInventory] WHERE room_type = @name AND status = 1", sqlConnection.Sql);
                command.Parameters.AddWithValue("@name", CB_Rooms.GetItemText(CB_Rooms.SelectedItem));
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                PB_Room1.Visible = true;
                PB_Room2.Visible = true;
                PB_Room3.Visible = true;
                TB_RoomInformation3.Visible = true;
                TB_Price.Visible = true;
                TB_Price.Text = reader[0] + " per night";

                sqlConnection.Sql.Close();
            }
        }
    }
}
