namespace Oldschool_Video_Game_Store.Classes
{
    internal class Admin : IUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public Admin(string userName, string password, int age)
        {
            UserName = userName;
            Password = password;
            Age = age;
        }
    }
}
