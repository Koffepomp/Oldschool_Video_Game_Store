using Oldschool_Video_Game_Store.Classes;
using System.Collections.Generic;
using System.Windows;

namespace Oldschool_Video_Game_Store
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StoreManager storeManager = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOpenRegisterNewAccount_Click(object sender, RoutedEventArgs e)
        {
            RegisterUserWindow registerUserWindow = new(storeManager);
            registerUserWindow.Show();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            List<IUser> Users = storeManager.GetAllUsers();

            string inputUsername = tbUsername.Text;
            string inputPassword = tbPassword.Password;
            bool loginAuthentikised = false;
            foreach (IUser user in Users)
            {
                if (user.UserName == inputUsername && user.Password == inputPassword)
                {
                    loginAuthentikised = true;
                    RentWindow rentWindow = new(storeManager, user);
                    rentWindow.Show();
                    tbUsername.Clear();
                    tbPassword.Clear();
                }
            }
            if (!loginAuthentikised)
            {
                MessageBox.Show("Wrong user or passowrd.");
                tbPassword.Clear();
            }
        }
    }
}
