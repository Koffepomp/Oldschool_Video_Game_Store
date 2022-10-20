namespace Oldschool_Video_Game_Store.Classes
{
    internal class Game : IMedia
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public int NumRatings { get; set; }
        public string Genre { get; set; }
        public Customer Renter { get; set; }
        public bool IsRented { get; set; }
        public bool IsRRated { get; set; }

        public string GetInfo()
        {
            string info = $"{Name} | {Rating} | {NumRatings} | {Genre}";
            if (IsRRated)
            {
                info += " | R-Rated";
            }
            if (IsRented)
            {
                info += $" | Is Rented by {Renter.UserName}";
            }
            else
            {
                info += " | AVAILABLE";
            }
            return info;
        }
        public Game(string name, GameGenres genre, bool isRRated)
        {
            Name = name;
            Genre = genre.ToString();
            IsRRated = isRRated;
        }
    }
}
