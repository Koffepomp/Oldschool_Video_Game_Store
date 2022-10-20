using Oldschool_Video_Game_Store.Classes;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Oldschool_Video_Game_Store
{
    /// <summary>
    /// Interaction logic for RentWindow.xaml
    /// </summary>
    public partial class RentWindow : Window
    {
        StoreManager StoreManager;
        IUser User;
        public RentWindow(StoreManager storeManager, IUser user)
        {
            InitializeComponent();
            StoreManager = storeManager;
            User = user;
            lblUsername.Content = user.UserName.ToUpper();
            if (User.GetType().Name == "Admin")
            {
                btnAddToLibrary.Visibility = Visibility.Visible;
                btnRemoveFromLibrary.Visibility = Visibility.Visible;
            }

            RefreshMediaListView();

            cbRating.Items.Add("1");
            cbRating.Items.Add("2");
            cbRating.Items.Add(3);
            cbRating.Items.Add(4);
            cbRating.Items.Add(5);
            cbRating.Items.Add(6);
            cbRating.Items.Add(7);
            cbRating.Items.Add(8);
            cbRating.Items.Add(9);
            cbRating.Items.Add(10);
        }

        private void RefreshMediaListView()
        {
            lvMedias.Items.Clear();

            foreach (IMedia media in StoreManager.GetAllMedias())
            {
                ListViewItem newMediaItem = new();
                newMediaItem.Content = media.GetInfo();
                newMediaItem.Tag = media;
                lvMedias.Items.Add(newMediaItem);
            }
            btnRemoveFromLibrary.IsEnabled = false;
            btnRate.IsEnabled = false;
            cbRating.IsEnabled = false;
            btnRent.IsEnabled = false;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ListViewItem currentSelectedItem = new();
                currentSelectedItem = (ListViewItem)lvMedias.SelectedItem;
                IMedia currentMedia = (IMedia)currentSelectedItem.Tag;
                currentMedia.Renter = (Customer)User;
                currentMedia.IsRented = true;
                MessageBox.Show("Succesfully rented a game/movie!");
                RefreshMediaListView();
            }
            catch
            {
                MessageBox.Show("Can't rent while logged in as admin!");
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            RefreshMediaListView();
        }

        private void btnRate_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem currentSelectedItem = new();
            currentSelectedItem = (ListViewItem)lvMedias.SelectedItem;
            IMedia currentMedia = (IMedia)currentSelectedItem.Tag;
            currentMedia.Rating = Convert.ToInt32(cbRating.Text);
            currentMedia.NumRatings++;
            RefreshMediaListView();
            btnRemoveFromLibrary.IsEnabled = false;
            btnRate.IsEnabled = false;
            cbRating.IsEnabled = false;
            btnRent.IsEnabled = false;

        }

        private void btnAddToLibrary_Click(object sender, RoutedEventArgs e)
        {
            AddToLibraryWindow addToLibraryWindow = new(StoreManager);
            addToLibraryWindow.Show();
        }

        private void btnRemoveFromLibrary_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem currentSelectedItem = new();
            currentSelectedItem = (ListViewItem)lvMedias.SelectedItem;
            IMedia selectedMedia = (IMedia)currentSelectedItem.Tag;
            StoreManager.RemoveMedia(selectedMedia);
            RefreshMediaListView();
            btnRemoveFromLibrary.IsEnabled = false;
            btnRate.IsEnabled = false;
            cbRating.IsEnabled = false;
            btnRent.IsEnabled = false;
        }

        private void lvMedias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbRating.IsEnabled = true;
            btnRemoveFromLibrary.IsEnabled = true;
            btnRent.IsEnabled = true;
        }

        private void cbRating_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnRate.IsEnabled = true;
        }
    }
}
