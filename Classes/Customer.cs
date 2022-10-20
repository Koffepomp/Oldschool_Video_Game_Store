namespace Oldschool_Video_Game_Store.Classes
{
    public class Customer : IUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

        public Customer(string userName, string password, int age)
        {
            UserName = userName;
            Password = password;
            Age = age;
        }
    }
}