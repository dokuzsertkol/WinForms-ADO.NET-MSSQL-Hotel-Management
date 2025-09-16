namespace HOTELAPP
{
    public partial class MemberForm : Form
    {
        bool isOtherFormActive = false;
        private readonly string username;
        public MemberForm(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void LL_LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isOtherFormActive = true;
            LoginForm login = new();
            login.Show();
            this.Close();
        }

        private void MakeReservationButton_Click(object sender, EventArgs e)
        {
            isOtherFormActive = true;
            AddReservationForm addReservation = new(username);
            addReservation.Show();
            this.Close();
        }

        private void ReservationHistoryButton_Click(object sender, EventArgs e)
        {
            isOtherFormActive = true;
            ReservationHistoryForm reservationHistory = new(username);
            reservationHistory.Show();
            this.Close();
        }

        private void PointShopButton_Click(object sender, EventArgs e)
        {
            isOtherFormActive = true;
            PointShopForm pointShop = new(username);
            pointShop.Show();
            this.Close();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            isOtherFormActive = true;
            ProfileForm profile = new(username);
            profile.Show();
            this.Close();
        }

        private void MemberForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isOtherFormActive) Application.Exit();
        }
    }
}
