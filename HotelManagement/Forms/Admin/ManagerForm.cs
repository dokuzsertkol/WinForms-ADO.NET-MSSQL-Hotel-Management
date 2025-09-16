using HOTELAPP.Helpers;
using System.Data;
using System.Data.SqlClient;

namespace HOTELAPP
{
    public partial class ManagerForm : Form
    {
        bool isOtherFormOpened = false;
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerWindow_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigureSQL sqlConnection = new ConfigureSQL();
                sqlConnection.Sql.Open();
                SqlCommand query = new SqlCommand("SELECT name, surname, gender, role FROM [User] WHERE role = 'Staff' OR role = 'Manager'", sqlConnection.Sql);
                SqlDataAdapter adapter = new SqlDataAdapter(query);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                sqlConnection.Sql.Close();

                DGV_Employee.DataSource = dataTable;
                foreach (DataGridViewColumn column in DGV_Employee.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    column.FillWeight = 1; // equal weight for all columns
                }

                sqlConnection.Sql.Open();
                query = new SqlCommand("SELECT * FROM [User] WHERE role = 'Guest' ", sqlConnection.Sql);
                adapter = new SqlDataAdapter(query);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                DGV_Client.DataSource = dataTable;
                foreach (DataGridViewColumn column in DGV_Client.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    column.FillWeight = 1;
                }
            }
            catch (Exception Ex)
            {

            }
        }

        private void B_AddEmployee_Click(object sender, EventArgs e)
        {
            isOtherFormOpened = true;
            AddEmployeeForm addEmployee = new AddEmployeeForm();
            addEmployee.Show();
            this.Close();
        }

        private void B_ShowClients_Click(object sender, EventArgs e)
        {
            DGV_Employee.Visible = false;
            B_AddEmployee.Visible = false;

            DGV_Client.Visible = true;
        }

        private void B_ShowEmployees_Click(object sender, EventArgs e)
        {
            DGV_Employee.Visible = true;
            B_AddEmployee.Visible = true;

            DGV_Client.Visible = false;
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isOtherFormOpened) Application.Exit();
        }

        private void LL_LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isOtherFormOpened = true;
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
