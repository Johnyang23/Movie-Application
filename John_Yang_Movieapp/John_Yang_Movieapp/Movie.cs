using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace John_Yang_Movieapp
{
    class Movie
    {
        private string moviename;
        private string rating;
        private string time;
        private string genre;
        private string director;
        private string releasedate;
        private string info;

        public Movie()
        {

        }

        public Movie (string movieName, string Rating, string Time, 
            string Genre, string Director, string releaseDate, string Info)
        {
            moviename = movieName;
            rating = Rating;
            time = Time;
            genre = Genre;
            director = Director;
            releasedate = releaseDate;
            info = Info;
        }

        public string Moviename
        {
            get
            {
                return moviename;
            }
            set
            {
                moviename = value;
            }
        }

        public string Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value;
            }
        }

        public string Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }

        public string Director
        {
            get
            {
                return director;
            }
            set
            {
                director = value;
            }
        }

        public string Releasedate
        {
            get
            {
                return releasedate;
            }
            set
            {
                releasedate = value;
            }
        }

        public string Info
        {
            get
            {
                return info;
            }
            set
            {
                info = value;
            }
        }

        public override string ToString()
        {
            return  "\nMovie Name: " + moviename + "\nRating: " + rating
                + "\nTime: " + time + "\nGenre: " + genre + "\nDirector: " + director + "\nRelease Date: "
                + releasedate + "\nSummary: " + info;
        }




    }
}
