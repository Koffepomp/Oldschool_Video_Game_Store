namespace Oldschool_Video_Game_Store.Classes
{
    public interface IUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}
