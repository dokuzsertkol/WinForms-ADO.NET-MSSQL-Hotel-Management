using HOTELAPP.Helpers;
using System.Data.SqlClient;

namespace HOTELAPP
{
    public partial class LoginForm : Form
    {

        bool isOtherFormActive = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {

            ConfigureSQL sqlConnection = new ConfigureSQL();

            try
            {
                sqlConnection.Sql.Open();
                SqlCommand userCmd = new SqlCommand("SELECT username, password, role FROM [User]", sqlConnection.Sql);
                SqlDataReader userTable = userCmd.ExecuteReader();

                string usernameText = TB_Username.Text, passwordText = TB_Password.Text;

                while (userTable.Read())
                {

                    if (usernameText == userTable[0].ToString() && passwordText == userTable[1].ToString())
                    {
                        switch (userTable[2].ToString())
                        {
                            case "Guest":
                                this.Hide();
                                MemberForm member = new MemberForm(usernameText);
                                member.ShowDialog();
                                break;

                            case "Staff":
                                this.Hide();
                                StaffForm staff = new StaffForm();
                                staff.Show();
                                break;

                            case "Manager":
                                this.Hide();
                                ManagerForm manage = new ManagerForm();
                                manage.Show();
                                break;
                        }

                        sqlConnection?.Sql.Close();
                        isOtherFormActive = true;
                        this.Close();

                        return;
                    }
                }
                MessageBox.Show("not found");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("sql yüklenemedi");
            }
        }

        private void SignUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegiterForm f2 = new();
            f2.Show();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassWordCheckBox.Checked) TB_Password.UseSystemPasswordChar = true;
            else TB_Password.UseSystemPasswordChar = false;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isOtherFormActive) Application.Exit();
        }
    }
}
