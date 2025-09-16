using HOTELAPP.Helpers;
using System.Data.SqlClient;

namespace HOTELAPP
{
    public partial class PointShopForm : Form
    {
        bool isOtherFormOpened = false;
        int loyaltyPoints;
        private readonly string username;
        List<string> prizes = new List<string>();

        public PointShopForm(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void LoadLoyalty()
        {
            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
            SqlCommand command = new SqlCommand("SELECT loyalty_points FROM [RewardLoyalty] WHERE  guestname = @guestname", sqlConnection.Sql);
            command.Parameters.AddWithValue("@guestname", username);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {

                loyaltyPoints = reader.GetInt32(0);


                LoyaltyPointLabel.Text = "Loyalty Points: " + loyaltyPoints.ToString();
            }
            else
            {
                // Handle the case where no loyalty points are found for the given room type
                LoyaltyPointLabel.Text = " Loyalty Points: 0 ";
            }

            reader.Close();
            sqlConnection.Sql.Close();  // Close the connection after using it
        }

        private void PointShop_Load(object sender, EventArgs e)
        {
            PriceLabel.Text = "0";

            LoadLoyalty();
            LoadClaimed();
        }

        // loyalty_points değerini azaltmak için kullanılan fonksiyon
        private void UpdateLoyaltyPointsInDatabase(int loyaltyPointsToDeduct)
        {
            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
            SqlCommand command = new SqlCommand("SELECT loyalty_points FROM [RewardLoyalty] WHERE guestname = @user", sqlConnection.Sql);

            try // earning points
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@user", username);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                int points = int.Parse(reader[0].ToString()) - loyaltyPointsToDeduct;
                reader.Close();
                if (points < 0)
                {
                    MessageBox.Show("Not enough points.");
                    return;
                }
                command.Parameters.Clear();
                command = new SqlCommand("UPDATE [RewardLoyalty] SET loyalty_points = @newpoint WHERE guestname = @user", sqlConnection.Sql);
                command.Parameters.AddWithValue("@user", username);
                command.Parameters.AddWithValue("@newpoint", points);
                command.ExecuteNonQuery();


            }
            catch (Exception Ex)
            {
                command.Parameters.Clear();
                command = new SqlCommand("INSERT INTO [RewardLoyalty](guestname, loyalty_points) VALUES (@user, 5)", sqlConnection.Sql);
                command.Parameters.AddWithValue("@user", username);
                command.ExecuteNonQuery();
            }

        }

        private void LoadClaimed()
        {
            ConfigureSQL sqlConnection = new ConfigureSQL();
            sqlConnection.Sql.Open();
            SqlCommand command = new SqlCommand("SELECT prize, count FROM [Rewards] WHERE guestname = @user", sqlConnection.Sql);
            command.Parameters.AddWithValue("@user", username);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                string allPrizes = "";
                while (reader.Read())
                {
                    allPrizes += reader[1].ToString() + " " + reader[0].ToString() + ", ";
                }
                allPrizes = allPrizes.Remove(allPrizes.Length - 2, 2);
                TB_ClaimedRewards.Text = allPrizes;
            }
            catch (Exception Ex)
            {
                reader.Close();
            }
        }

        private void B_AddFreeMassage_Click(object sender, EventArgs e)
        {
            TB_Cart.AppendText($"{label3.Text}\r\n");
            int currentValue = int.Parse(PriceLabel.Text);
            int updatedValue = currentValue + 10;
            PriceLabel.Text = updatedValue.ToString();
            prizes.Add("massage");
        }

        private void B_AddVIPDinner_Click(object sender, EventArgs e)
        {
            TB_Cart.AppendText($"{label4.Text}\r\n");
            int currentValue = int.Parse(PriceLabel.Text);
            int updatedValue = currentValue + 10;
            PriceLabel.Text = updatedValue.ToString();
            prizes.Add("dinner");
        }

        private void B_AddVIPBreakfast_Click(object sender, EventArgs e)
        {
            TB_Cart.AppendText($"{label5.Text}\r\n");
            int currentValue = int.Parse(PriceLabel.Text);
            int updatedValue = currentValue + 10;
            PriceLabel.Text = updatedValue.ToString();
            prizes.Add("breakfast");
        }

        private void B_GoBack_Click(object sender, EventArgs e)
        {
            isOtherFormOpened = true;
            MemberForm member = new MemberForm(username);
            member.Show();
            this.Close();
        }

        private void B_Claim_Click(object sender, EventArgs e)
        {

            try
            {
                int loyaltyPointsToDeduct = int.Parse(PriceLabel.Text);

                if (loyaltyPoints < loyaltyPointsToDeduct) throw new Exception();

                UpdateLoyaltyPointsInDatabase(loyaltyPointsToDeduct);

                PriceLabel.Text = "0";
                TB_Cart.Text = "";

                ConfigureSQL sqlConnection = new ConfigureSQL();
                sqlConnection.Sql.Open();
                SqlCommand command = new SqlCommand();


                foreach (string prize in prizes)
                {
                    command.Parameters.Clear();
                    command = new SqlCommand("SELECT count FROM [Rewards] WHERE guestname = @guestname AND prize = @prize", sqlConnection.Sql);
                    command.Parameters.AddWithValue("@guestname", username);
                    command.Parameters.AddWithValue("@prize", prize);
                    SqlDataReader reader = command.ExecuteReader();
                    
                    reader.Read();
                    int count = int.Parse(reader[0].ToString());
                    reader.Close();

                    command.Parameters.Clear();
                    command = new SqlCommand("UPDATE [Rewards] SET count = @count WHERE guestname = @guestname AND prize = @prize", sqlConnection.Sql);
                    command.Parameters.AddWithValue("@guestname", username);
                    command.Parameters.AddWithValue("@prize", prize);
                    command.Parameters.AddWithValue("@count", count + 1);
                    command.ExecuteNonQuery();

                    reader.Close();
                    command.Parameters.Clear();
                    command = new SqlCommand("INSERT INTO [Rewards](guestname, prize, count) VALUES (@guestname, @prize, 1)", sqlConnection.Sql);
                    command.Parameters.AddWithValue("@guestname", username);
                    command.Parameters.AddWithValue("@prize", prize);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Thank you for your loyalty!");
                }
                prizes.Clear();
                LoadLoyalty();
                LoadClaimed();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not enough credit.");
            }
        }

        private void PointShopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isOtherFormOpened) Application.Exit();
        }
    }
}
