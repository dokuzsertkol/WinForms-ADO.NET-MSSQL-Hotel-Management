using HOTELAPP.Helpers;
using System.Data.SqlClient;

namespace HOTELAPP
{
    public partial class AddEmployeeForm : Form
    {
        bool isOtherFormOpened = false;

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            ConfigureSQL sqlConnection = new ConfigureSQL();
            try
            {
                sqlConnection.Sql.Open();
                SqlCommand insertCmd = new SqlCommand("INSERT INTO [User] (username, password, name, surname, gender, email, birthday, role) values (@Username, @Password, @Name, @Surname, @Gender, @Email, @Birthday, @Role)", sqlConnection.Sql);

                insertCmd.Parameters.AddWithValue("@Name", TB_Firstname.Text);
                insertCmd.Parameters.AddWithValue("@Password", TB_Password.Text);
                insertCmd.Parameters.AddWithValue("@Surname", TB_Surname.Text);
                insertCmd.Parameters.AddWithValue("@Username", TB_Username.Text);
                insertCmd.Parameters.AddWithValue("@Gender", CB_Gender.Text);
                insertCmd.Parameters.AddWithValue("@Birthday", DTP_Birth.Value.Date);
                insertCmd.Parameters.AddWithValue("@Email", TB_Email.Text);
                insertCmd.Parameters.AddWithValue("@Role", CB_Role.Text);

                insertCmd.ExecuteNonQuery();
                MessageBox.Show("Registered");
                TB_Password.Text = "";
                TB_Firstname.Text = "";
                TB_Surname.Text = "";
                TB_Username.Text = "";
                CB_Gender.SelectedIndex = -1;
                TB_Email.Text = "";
                CB_Role.SelectedIndex = -1;
            }
            catch (Exception Ex)
            {
                if (sqlConnection == null)
                    MessageBox.Show("Couldn't access the Database");
                else
                {
                    MessageBox.Show("Username Taken");
                }
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Sql.Close();
                }
            }
        }

        private void B_GoBack_Click(object sender, EventArgs e)
        {
            isOtherFormOpened = true;
            ManagerForm manager = new ManagerForm();
            manager.Show();
            this.Close();
        }

        private void AddEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isOtherFormOpened) Application.Exit();
        }
    }
}
