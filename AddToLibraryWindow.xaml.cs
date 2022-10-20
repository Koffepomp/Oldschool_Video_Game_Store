using System.Windows;

namespace Oldschool_Video_Game_Store
{
    /// <summary>
    /// Interaction logic for AddToLibraryWindow.xaml
    /// </summary>
    public partial class AddToLibraryWindow : Window
    {
        public AddToLibraryWindow()
        {
            InitializeComponent();
        }

        private void btnSubmitTitle_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Title has been added to the library!");
            Close();
        }
    }
}
