﻿namespace Oldschool_Video_Game_Store.Classes
{
    public interface IMedia
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public int NumRatings { get; set; }
        public string Genre { get; set; }
        public Customer Renter { get; set; }
        public bool IsRented { get; set; }
        public bool IsRRated { get; set; }
        public string GetInfo();
    }
}