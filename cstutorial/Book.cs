using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// blue print for a new data type in our program
// custom data type
// 
//to create this we right click on the project, select empty class under c#
namespace cstutorial
{
    class Book
    {
		// creating attributes
		// these variables are class attributes
		// describing what our book is
		// inside our book it has these:

		// these are the specification of out book
		public string title;
		public string author;
		public int pages;

        // can also create a empty constructor so we can call that too
        public Book()
        {

        }

        // this is a constructor
        // pass through a parameter

        // argument title
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;

        }
	}
}
