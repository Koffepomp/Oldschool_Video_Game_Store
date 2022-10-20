using System;
using System.Windows;

namespace Oldschool_Video_Game_Store
{
    /// <summary>
    /// Interaction logic for RegisterUserWindow.xaml
    /// </summary>
    public partial class RegisterUserWindow : Window
    {
        StoreManager StoreManager;
        public RegisterUserWindow(StoreManager storeManager)
        {
            InitializeComponent();
            StoreManager = storeManager;
        }

        private void btnRegisterUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StoreManager.CreateCustomer(tbUsername.Text, tbPassword.Text, Convert.ToInt32(tbAge.Text));
                MessageBox.Show("Register complete! Please sign in.");
            }
            catch
            {
                MessageBox.Show("Flopp");
            }
            Close();
        }
    }
}
