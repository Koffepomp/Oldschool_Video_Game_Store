using System.Windows;

namespace Oldschool_Video_Game_Store
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOpenRegisterNewAccount_Click(object sender, RoutedEventArgs e)
        {
            RegisterUserWindow registerUserWindow = new();
            registerUserWindow.Show();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            RentWindow rentWindow = new();
            rentWindow.Show();
            tbUsername.Clear();
            tbPassword.Clear();
        }
    }
}
