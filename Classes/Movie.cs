namespace Oldschool_Video_Game_Store.Classes
{
    internal class Movie : IMedia
    {
        public string Name { get; set; }
        public int Rating { get; set; } = 0;
        public int NumRatings { get; set; } = 0;
        public string Genre { get; set; }
        public Customer Renter { get; set; }
        public bool IsRented { get; set; } = false;
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
        public Movie(string name, MovieGenres genre, bool isRRated)
        {
            Name = name;
            Genre = genre.ToString();
            IsRRated = isRRated;
        }
    }
}
