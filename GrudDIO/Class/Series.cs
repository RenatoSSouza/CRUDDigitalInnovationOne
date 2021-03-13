using GrudDIO.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrudDIO.Class
{
    class Series : BaseEntity
    {
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool Excluded { get; set; }

        public Series(int id, Genre genre, string title, string description, int year)
        {
            Id = id;
            Genre = genre;
            Title = title;
            Description = description;
            Year = year;
            Excluded = false;
        }

        public override string ToString()
        {
            string turnBack = "";
            turnBack += $"Genre {Genre + Environment.NewLine}";
            turnBack += $"Title {Title + Environment.NewLine}";
            turnBack += $"Description {Description + Environment.NewLine}";
            turnBack += $"Year {Year + Environment.NewLine}";
            return turnBack;
        }

        public string ReturnTitle()
        {
            return Title;
        }

        public int ReturnId()
        {
            return Id;
        }

        public void Excludes()
        {
            Excluded = true;
        }
    }
}
