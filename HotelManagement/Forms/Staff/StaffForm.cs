using HOTELAPP.Helpers;
using System.Data.SqlClient;

namespace HOTELAPP
{
    public partial class StaffForm : Form
    {
        bool isOtherFromOpened = false;

        public StaffForm()
        {
            InitializeComponent();
        }

        private void loadRooms()
        {
            try
            {
                CB_Rooms.Items.Clear();
                ConfigureSQL sqlConnection = new ConfigureSQL();
                sqlConnection.Sql.Open();
                SqlCommand command = new SqlCommand("SELECT room_type, status FROM [RoomInventory]", sqlConnection.Sql);
                SqlDataReader reader = command.ExecuteReader();
                List<string> rooms = new List<string>();
                while (reader.Read())
                {
                    string status;
                    if (bool.Parse(reader[1].ToString())) status = "Avaliable";
                    else status = "Maintance";

                    rooms.Add(reader[0].ToString() + " - " + status);
                }
                reader.Close();

                foreach (string type in rooms)
                {
                    CB_Rooms.Items.Add(type);
                    reader.Close();
                    command.Parameters.Clear();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("error");
            }
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            loadRooms();
        }

        private void LL_LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isOtherFromOpened = true;
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isOtherFromOpened) Application.Exit();
        }

        private void B_SetMaintenance_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigureSQL sqlConnection = new ConfigureSQL();
                sqlConnection.Sql.Open();
                SqlCommand command = new SqlCommand("UPDATE [RoomInventory] SET status = 0 WHERE room_type = @room", sqlConnection.Sql);
                string roomtype = CB_Rooms.SelectedItem.ToString();
                int index = roomtype.IndexOf("-");
                if (index >= 0)
                    roomtype = roomtype.Substring(0, index);
                roomtype.TrimEnd(roomtype[roomtype.Length - 1]);
                command.Parameters.AddWithValue("@room", roomtype);
                command.ExecuteNonQuery();
                loadRooms();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("error");
            }
        }

        private void B_SetAvaliable_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigureSQL sqlConnection = new ConfigureSQL();
                sqlConnection.Sql.Open();
                SqlCommand command = new SqlCommand("UPDATE [RoomInventory] SET status = 1 WHERE room_type = @room", sqlConnection.Sql);
                string roomtype = CB_Rooms.SelectedItem.ToString();
                int index = roomtype.IndexOf("-");
                if (index >= 0)
                    roomtype = roomtype.Substring(0, index);
                roomtype.TrimEnd(roomtype[roomtype.Length - 1]);
                command.Parameters.AddWithValue("@room", roomtype);
                command.ExecuteNonQuery();
                loadRooms();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("error");
            }
        }
    }
}
