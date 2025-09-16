using HOTELAPP.Helpers;
using System.Data.SqlClient;

namespace HOTELAPP
{
    public partial class ProfileForm : Form
    {
        bool isOtherFormOpened = false;
        private readonly string username;
        public ProfileForm(string user)
        {
            InitializeComponent();
            username = user;
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();

            SqlCommand command = new SqlCommand("SELECT username, name, surname, gender, email, birthday FROM [User] WHERE username=@username", sqlConnection.Sql);
            command.Parameters.AddWithValue("@username", username);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                TB_Firstname.Text = reader["name"].ToString();
                TB_Surname.Text = reader["surname"].ToString();
                TB_Email.Text = reader["email"].ToString();
                TB_Gender.Text = reader["gender"].ToString();
                TB_BirthDate.Text = reader["birthday"].ToString();
                TB_Username.Text = reader["username"].ToString();
            }

            reader.Close();
            sqlConnection.Sql.Close();
        }
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            isOtherFormOpened = true;
            MemberForm member = new MemberForm(username);
            member.Show();
            this.Close();
        }

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isOtherFormOpened) Application.Exit();
        }
    }
}
