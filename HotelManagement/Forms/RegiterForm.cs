using System.Data.SqlClient;
using HOTELAPP.Helpers;

namespace HOTELAPP
{
    public partial class RegiterForm : Form
    {
        public RegiterForm()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            ConfigureSQL sqlConnection = new ConfigureSQL();
            try
            {
                sqlConnection.Sql.Open();
                SqlCommand insertCmd = new SqlCommand("INSERT INTO [User] (username, password, name, surname, gender, email, birthday, role) values (@Username, @Password, @Name, @Surname, @Gender, @Email, @Birthday, 'Guest')", sqlConnection.Sql);
                insertCmd.Parameters.AddWithValue("@Username", TB_Username.Text);
                insertCmd.Parameters.AddWithValue("@Password", TB_Password.Text);
                insertCmd.Parameters.AddWithValue("@Name", TB_Firstname.Text);
                insertCmd.Parameters.AddWithValue("@Surname", TB_Surname.Text);
                insertCmd.Parameters.AddWithValue("@Gender", CB_Gender.Text);
                insertCmd.Parameters.AddWithValue("@Birthday", DTP_BirthDate.Value.Date);
                insertCmd.Parameters.AddWithValue("@Email", TB_Email.Text);

                insertCmd.ExecuteNonQuery();
                MessageBox.Show("kayıt olundu");

                this.Close();
            }
            catch (Exception Ex)
            {
                if (sqlConnection == null)
                    MessageBox.Show("sql yüklenemedi");
                else
                {
                    MessageBox.Show("kullanıcı adı alınmış");
                }
            }
            finally
            {
                sqlConnection?.Sql.Close();
            }
        }
    }
}
