using System.Windows;

namespace Oldschool_Video_Game_Store
{
    /// <summary>
    /// Interaction logic for RentWindow.xaml
    /// </summary>
    public partial class RentWindow : Window
    {
        public RentWindow()
        {
            InitializeComponent();
            cbRating.Items.Add(1);
            cbRating.Items.Add(2);
            cbRating.Items.Add(3);
            cbRating.Items.Add(4);
            cbRating.Items.Add(5);
            cbRating.Items.Add(6);
            cbRating.Items.Add(7);
            cbRating.Items.Add(8);
            cbRating.Items.Add(9);
            cbRating.Items.Add(10);
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRent_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Succesfully rented a game/movie!");
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            // update listview
        }

        private void btnRate_Click(object sender, RoutedEventArgs e)
        {
            // bara för att kunna få upp add fönstret
            btnAddToLibrary.IsEnabled = true;
        }

        private void btnAddToLibrary_Click(object sender, RoutedEventArgs e)
        {
            AddToLibraryWindow addToLibraryWindow = new();
            addToLibraryWindow.Show();
        }

        private void btnRemoveFromLibrary_Click(object sender, RoutedEventArgs e)
        {
            // remove selecteditem in listview
        }
    }
}
