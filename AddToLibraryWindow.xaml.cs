using Oldschool_Video_Game_Store.Classes;
using System;
using System.Windows;

namespace Oldschool_Video_Game_Store
{
    /// <summary>
    /// Interaction logic for AddToLibraryWindow.xaml
    /// </summary>
    public partial class AddToLibraryWindow : Window
    {
        StoreManager StoreManager;
        public AddToLibraryWindow(StoreManager storeManager)
        {
            InitializeComponent();
            StoreManager = storeManager;
            foreach (MovieGenres genre in Enum.GetValues(typeof(MovieGenres)))
            {
                cbGenre.Items.Add(genre);
            }
            foreach (GameGenres genre in Enum.GetValues(typeof(GameGenres)))
            {
                cbGenre.Items.Add(genre);
            }
        }

        private void btnSubmitTitle_Click(object sender, RoutedEventArgs e)
        {
            bool isMovie = false;
            foreach (MovieGenres genre in Enum.GetValues(typeof(MovieGenres)))
            {
                if (cbGenre.Text == genre.ToString())
                {
                    isMovie = true;
                }
            }

            if (isMovie)
            {
                StoreManager.CreateMovie(tbTitle.Text, (MovieGenres)cbGenre.SelectedItem, (bool)chbxRRated.IsChecked);
            }
            else
            {
                StoreManager.CreateGame(tbTitle.Text, (GameGenres)cbGenre.SelectedItem, (bool)chbxRRated.IsChecked);
            }

            MessageBox.Show("Title has been added to the library!");
            Close();
        }
    }
}
