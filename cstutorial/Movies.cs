using System;
namespace cstutorial
{
    class Movie
    {
        // public - can be accessed by anyone, open to anyone

        // private - only code inside the movie class can be accessed, contained inside of the curly brackets ^
        // this means avengers.rating is not possible
        public string moveTitle;
        public string movieDirector;
        private string movieRating;

        public Movie(string aMovieTitle, string aMovieDirector, string aMovieRating)
        {
            moveTitle = aMovieTitle;
            movieDirector = aMovieDirector;

            // we are setting the rating through the "Rating" class
            Rating = aMovieRating;
        }

        public string Rating
        {
            // allow us to get the rating attribute (avengers.rating)
            get { return movieRating; }
            // set the rating/modify. define a specific rule so there can only spefici values as someone could write anything such as "dog" for the rating
            set {
                if (value == "G" || value == "PG" || value == "PG-13")
                {
                    movieRating = value;
                }
                else
                {
                    // if a value rating is not valid we will by dwfault do this.
                    movieRating = "NR";
                }
            }

            // we need the getter and setter as we made the movieRating private
        }
    }
}
