using Oldschool_Video_Game_Store.Classes;
using System.Collections.Generic;

namespace Oldschool_Video_Game_Store
{
    public class StoreManager
    {
        List<IUser> Users = new();
        List<IMedia> Medias = new();
        public StoreManager()
        {
            CreateStandardUsers();
            CreateStandardMedias();
        }



        private void CreateStandardMedias()
        {
            CreateMovie("Jaws", MovieGenres.Horror, true);
            CreateMovie("Seinfeldt", MovieGenres.Comedy, false);
        }

        public void CreateMovie(string name, MovieGenres genre, bool isRRated)
        {
            Movie newMovie = new(name, genre, isRRated);
            Medias.Add(newMovie);
        }
        public void CreateGame(string name, GameGenres genre, bool isRRated)
        {
            Game newGame = new(name, genre, isRRated);
            Medias.Add(newGame);
        }
        public List<IMedia> GetAllMedias()
        {
            return Medias;
        }

        public void RemoveMedia(IMedia item)
        {
            Medias.Remove(item);
        }








        private void CreateStandardUsers()
        {
            CreateCustomer("Jimmie", "asd", 40);
            CreateAdmin("admin", "asd", 30);
        }
        public void CreateCustomer(string userName, string password, int age)
        {
            Customer customer = new(userName, password, age);
            Users.Add(customer);
        }
        public void CreateAdmin(string userName, string password, int age)
        {
            Admin admin = new(userName, password, age);
            Users.Add(admin);
        }
        public List<IUser> GetAllUsers()
        {
            return Users;
        }
    }
}
