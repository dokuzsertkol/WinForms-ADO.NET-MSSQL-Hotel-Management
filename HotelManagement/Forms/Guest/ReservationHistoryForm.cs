using HOTELAPP.Helpers;
using System.Data.SqlClient;

namespace HOTELAPP
{
    public partial class ReservationHistoryForm : Form
    {
        bool isOtherFormOpened = false;
        private readonly string username;
        public ReservationHistoryForm(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void ReservationHistory_Load(object sender, EventArgs e)
        {
            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
            SqlCommand command = new SqlCommand("SELECT room_id, check_in_date, check_out_date FROM [Reservation] WHERE guestname = @user", sqlConnection.Sql);
            command.Parameters.AddWithValue("@user", username);
            SqlDataReader reader = command.ExecuteReader();

            List<string> roomOld = new List<string>();
            List<string> roomNew = new List<string>();
            List<string> roomNewIn = new List<string>();
            List<string> roomNewOut = new List<string>();
            List<string> roomOldIn = new List<string>();
            List<string> roomOldOut = new List<string>();
            while (reader.Read())
            {
                string roomId = reader[0].ToString();
                DateTime resIn = reader.GetDateTime(1);
                DateTime resOut = reader.GetDateTime(2);
                DateTime now = DateTime.Now;
                if (resIn <= now)
                {
                    roomOld.Add(roomId);
                    roomOldIn.Add(resIn.ToString().Replace("00:00:00", ""));
                    roomOldOut.Add(resOut.ToString().Replace("00:00:00", ""));
                }
                else
                {
                    roomNew.Add(roomId);
                    roomNewIn.Add(resIn.ToString().Replace("00:00:00", ""));
                    roomNewOut.Add(resOut.ToString().Replace("00:00:00", ""));
                }
            }
            reader.Close();


            command = new SqlCommand("SELECT room_type FROM [RoomInventory] WHERE room_id = @id", sqlConnection.Sql);
            int i = 0;
            foreach (string roomId in roomOld)
            {
                reader.Close();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", roomId);
                reader = command.ExecuteReader();
                reader.Read();
                string room = reader[0].ToString();
                CB_Old.Items.Add(room + "  " + roomOldIn[i] + " - " + roomOldOut[i]);
            }
            reader.Close();


            command = new SqlCommand("SELECT room_type FROM [RoomInventory] WHERE room_id = @id", sqlConnection.Sql);
            foreach (string roomId in roomNew)
            {
                reader.Close();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", roomId);
                reader = command.ExecuteReader();
                reader.Read();
                string room = reader[0].ToString();
                CB_Active.Items.Add(room + "  " + roomNewIn[i] + " - " + roomNewOut[i]);
            }
            reader.Close();
        }

        private void ReservationHistoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isOtherFormOpened) Application.Exit();
        }

        private void BB_GoBack_Click(object sender, EventArgs e)
        {
            isOtherFormOpened = true;
            MemberForm f2 = new MemberForm(username);
            f2.Show();
            this.Close();
        }
    }
}
