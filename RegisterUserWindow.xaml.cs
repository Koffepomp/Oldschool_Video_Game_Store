using System.Windows;

namespace Oldschool_Video_Game_Store
{
    /// <summary>
    /// Interaction logic for RegisterUserWindow.xaml
    /// </summary>
    public partial class RegisterUserWindow : Window
    {
        public RegisterUserWindow()
        {
            InitializeComponent();
        }

        private void btnRegisterUser_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Register complete! Please sign in.");
            Close();
        }
    }
}
