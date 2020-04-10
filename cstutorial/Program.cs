using System;
/*
    - "using System;" is a command
    - Configuring the file
    - Will need to use with C# so we need to specify it
*/


// Saying what project we're in
namespace cstutorial
    /*
        - These specific curly brackets signals our program is starting
        - Can write code in here
    */
{
    /*
        - "class" is a container where we can put in our code
        - A program is a set of instructions specificed in a particular order
    */

    class Program

    {
        /*
            Main is a method or a function. Another container where we can put
            our code. Main is important because we can put all our code here and
            this code will execute in terminal.
        */
        static void Main(string[] args)
        {
            /*
                Console.WriteLine() opens up the terminal and prints this.
                Reads line by line (like vanilla JS)
            */

            Console.WriteLine("Hello World");

            // Keeps the console open
            // Console.WriteLine();

            // Creating a data type here, storing plain text which is a string.
            string name = "sumitra manga";

            /*
                - Creating a data type to store a number here. 'int' is used
                  which means a whole number (not a decimal number)
                - Can also use negative (-30) numbers
                - Can be fractional as well as whole values
            */

            int age = 21;
            double gpa = 3.2;


            /*
             Can also set a data type and number then add value to it later:
                int age;
                age = 21;
            */

            var concatNameAndAge = name + " " + age;

            /*
             * 'char' means character. Only a single character can be stored
             * within this data type variable. If we are wanting to store more
             * than onecharacter then the 'string' data type will have to be
             * used. We also use single quotes within 'char'.
            */

            char grade = 'A';


            // Boolean
            bool isFemale = true;

            // constant - not stored in a variable, not keeping track of it

            // "\n" will print the following on a separate line
            string newLine = "sumitra\nmanga";

            // Print quotation mark whilst still being able to close the string.
            string quoteWithinString = "sumitra\"manga";

            // Get the number of characers within a string
            var getLength = newLine.Length;
            //Console.WriteLine(getLength);



            // STRING METHODS --------------------------------------------------

            // Methods are called by adding "." to give us a list of methods

            // Makes all the letters in the string uppercase
            var makeUpperCase = name.ToUpper();

            // Returns true or false (is also case sensitive)
            var getBoolForString = name.Contains("manga");

            // Gets the value of the index position of 0 (first character)
            var getValue = name[0];

            // Gets what index position this starts at
            var getIndexPos = name.IndexOf("manga");

            /*
                Get the character index position (remember to use single
                quotation's))
            */
            var getCharIndexPos = name.IndexOf('m');

            /*
                Print out everything from this index position and end when 3
                characters have been printed.
            */
            var printLetters = name.Substring(8, 3);
            // Result = man



            // WORKING WITH NUMBERS --------------------------------------------

            var testSum1 = 1 + 1 * 4;

            var addNumbersInBracketsThenTimesByFour = (1 + 1) * 4;
            // Result = 2 * 4

            int num = 6;
            num++;
            // Result = 7

            // Can do a similar thing with "num--" which will equal to 5


            // Math methods
            // ------------

            var getMaxNumber = Math.Max(4, 90);
            // Result = 90

            var getMinimumNumber = Math.Min(4, 90);
            // Result = 4

            var getNearestWholeNum = Math.Round(4.3);
            // Result = 4



            // GETTING USER INPUT ----------------------------------------------

            /*
                1. We are holding the app from doing anything until the user
                puts in their name:
                Console.WriteLine("Enter your name: ");

                2. The name typed out is stored in the usersName variable:
                string usersName = Console.ReadLine();

                3. Write Hello and the name:
                Console.WriteLine("Hello " + usersName);
             */

            // Coverting a string into a number
            int number = Convert.ToInt32("45");
            // Console.WriteLine(number);
            // Result = ?

            /*
                We need to covert the Console.Readline() as it is a string by
                default.
            */

            // int usersNumberInput = Convert.ToInt32(Console.ReadLine());
            // Result = ?



            // ARRAY'S ---------------------------------------------------------

            // Making an array of numbers by signifiy the square brakets
            int[] numbers = { 5, 10, 15, 20, 25 };

            // Changing the value within a certain index position
            numbers[2] = 50;

            // Console.WriteLine(numbers[2]);
            // Result = 50

            /*
                Creating a new array, we need to define the length/size of the
                array if it is empty so it knows how much data can be stored.
            */
            string[] friends = new string[5];

            // Populate the array
            friends[0] = "Jim";



            // METHODS ---------------------------------------------------------

            /*
                Calling the SayHi method as it won't execute on its own unless
                it's called in the Main method.
            */

            // Passing through values name and age
            // SayHi("Priya", 21);
            // Result = "Hello Priya21"



            // RETURN STATEMENT ------------------------------------------------

            // cube(2); wont work as we haven't console.write within the method

            // Console.WriteLine(cube(2));
            // Result = 8



            // IF STATEMENTS ---------------------------------------------------

            bool isAFemale = true;
            bool isTall = true;

            /*
                && = and
                || = or
            */

            if (isAFemale && isTall)
            {
                var answer = "You are female and tall";
            }
            else if (!isAFemale)
            {
                var answer = "You are not a female";
            }
            else
            {
                var answer = "You are not female and/or tall";
            }



            // MORE IF STATEMENTS ----------------------------------------------


            // Console.WriteLine(GetMax(2, 19));
            // Result = 19


            // Console.WriteLine(GetDay(4));
            // Result = Thursday



            // WHILE LOOPS -----------------------------------------------------

            /*
                - Loop over block of code while a certain condition is true
                - Loop through repeatly while the condition is true
            */

            int indexNum = 1;

            /*
               - Speific a condition like an if statement when checking a
               // conditon
               - Continusly executing it until condiiton is false
            */

            while(indexNum <= 5)
            {
                // Console.WriteLine(indexNum);
                
                // Increment indexNum by 1
                indexNum++;

                /*
                    Result = 1 2 3 4 5

                    Checks it once which is equal to 1, logs out the number,
                    then increments the value. Then checks if the value is true
                    again, logs out the number already stored (which is 2) then
                    increments the value again.

                    Since the number has been incremented to 6, when the while
                    checks the condition it is false, therefore nothing will
                    happen.

                    This loop can get caught in an infinte loop if the condition
                    never changes.
                */
            }


            // Do while loop
            // -------------

            /*
                - Opposite of while loop
                - First, run the code we want to then check the condition
            */

            int indexNum2 = 6;

            do
            {
                // Console.WriteLine(indexNum2);
                indexNum2++;
            } while (indexNum2 <= 5);

            /*
                Result = 6
                This will console write due to the condition being checked after
                executing the desired code
            */


            // FOR LOOPS -------------------------------------------------------

            /*
                - Keep track of iterarating variable (i = 1) changes every time
                  going through the loop
                - Going through a loop but with a variable
                - Have a variable that we're using constantly through the loop
                - More compact
                - Easier to access
            */

            // While loop example/breakdown
            int j = 1;
            while(j <= 5)
            {
                //Console.WriteLine(j);
                j++;
            }


            /*
                 Parameters a for loop takes:

                 1. Initialise the varaible "i"
                 2. Write out the loop conidition (how long to loop for)
                 3. Incremet "i"

                 - Check the condition, if true, then execute code and increment
                 "i", check the condition, if true, execute etc.
            */

            for (int i = 1; i <= 5; i++)
            {
                //Console.WriteLine(i);
            }

            // Array of lucky numbers
            int[] luckyNums = { 4, 8, 12, 16, 20 };
            
            /*
                 - k = 0 bc array index equal to 0
                 - luckyNums.Length - get the length of the array
                 - k < luckyNums.Length - less than due to index position. If <=
                   then we are getting luckyNum[6]
            */
            for (int k = 0; k < luckyNums.Length; k++)
            {
                //Console.WriteLine(luckyNums[k]);
            }

            // 2D Array --------------------------------------------------------

            /*
                - Arrays within an array
                - [,] = Tells C# we want a 2d array
            */

            int[,] numberGrid = {
                { 1,2 },
                { 3,4 },
                { 5,6 }
            };

            /*
                Console.WriteLine(numberGrid[0, 1]);
                Result = 2 (accessing the first array and the 2 item in the
                array using index position)

                If we don't know what elements/data are going into the array we
                can still prepare the structure.

                [2,3] = Defining hte number of rows and number of columns
            */


            int[,] myArray = new int[2, 3];

            // CODE COMMENTS ---------------------------------------------------

            // = Single line comment

            /*
                Multiline comment
                Woohoo!
            */

            // EXCEPTION HANDLING ----------------------------------------------

            // Catch the code so we can handle it
            // try catch block here
            // testing the risky code
            // if the code breaks then print out error
            try
            {
                Console.WriteLine("Number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Another Number: ");
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(number1 / number2);
            }
            catch (DivideByZeroException e)
            {
                // (Exception e) - taking the Exception parameter which we've
                // named e, go into the exception parameter and get the official
                // error message
                Console.WriteLine(e.Message);

                // two scenarios can happen so we can define specific exceptions
                // catch (DivideByZeroException e) will only catch the 0 divison
                // error but if letter input error will terminate the app as we
                // haven't caught that error too
            }
            catch (FormatException e)
            {
                // can catch more than one error/exception by doing this
                Console.WriteLine(e.Message);
            }
            //finally
            //{
            // this will Always get excecuted no matter what
            // optinal block here
            //}

            // Search c# exception list to get all the expctions tahat could
            // happen


            // CLASSES AND OBJECTS ---------------------------------------------
            // Create your own custom data types as int and string wont always
            // be able cover it (like a mlbile phone is made of many things not
            // just a string or just a number)

            // Created a file

            // Object - instance of a class, physically book inside our program

            // Classes & Objects should be within the project (cstutorial not
            // cstutorial (master))or it won't pick up there is a class compenet 

            // this is creating the book

            // create a book object here
            // we have a parameter we have to pass through
            //Book book1 = new Book("mike");

            // define the objects properties
            // old way without public Book constructor
            //book1.title = "harry potter";
            //book1.author = "JK Rowling";
            //book1.pages = 401;


            // Console.WriteLine(book2.author);
            // result = 'someone'


            // CONSTRUCTORS  ---------------------------------------------------

            // - special method u can put into a c# class which is caleed when
            // creating hta object

            // here we are injecting the called class with values through the
            // parameters
            Book book2 = new Book("lord of the rings", "someone", 700);

            // can also change the value after calling the class
            book2.title = "the hobbit";

            Console.WriteLine(book2.title);
            //result = the hobbit


            // OBJECT METHODS --------------------------------------------------

            // a method that we can define inside out class ojebcts of thr class
            // find out info or modify info

            // Create staff members here
            Staff staff1 = new Staff("Jim", "BA", 28);
            Staff staff2 = new Staff("Pam", "Designer", 22);

            // we check each staff memebers ages and return a boolean value of
            // true or false
            Console.WriteLine(staff1.Is25AndOver());
            Console.WriteLine(staff2.Is25AndOver());

            // GETTERS AND SETTERS  --------------------------------------------
            // 2 types of methods, defined in classes, contorls access of the
            // attricute of the classes, makes classes more secure, define what
            // data is value
            // get - 
            // set -

            Movie avengersEndgame = new Movie("Avengers: Endgame", "Anthony Russo", "nope");
            Movie spiderManFarFromHome = new Movie("Spider-Man: Far From Home", "Jon Watts", "PG-13");

            // Rating is the class
            Console.WriteLine(avengersEndgame.Rating);

            // STATIC ATTRIBUTES IN CLASSES ------------------------------------

            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            // result = 1
            Song someSong = new Song("some song", "some cool band", 300);
            Console.WriteLine(Song.songCount);
            // result = 2

            Console.WriteLine(someSong.getSongCount());
            // result = 2
            // individual song count is being accessed here


            // STATIC METHODS --------------------------------------------------

            // method that belongs to the clas. dont hav to make na instances of
            // that class to use it
            UsefulTools.SayHelloThere("Sumi");
            // result = hello sumi

            // can still do this
            UsefulTools useful = new UsefulTools();

            // cant create an instance with the Math class as it is static
            // if we want this for the usefulTools class then we need to declare
            // static in the class

            // INHERITANCE -----------------------------------------------------

            // class indianChef : chef { }
            // this will inherant all the chef class functionality
            // super class is the chef class. indainChef is the sub class

            // public virtual void
            // put this on the super class
            // virtual = method can get overiden in any sub class

            // public override void
            // put his on the sub class




        }
        // Main Method ends ====================================================



        // METHODS -------------------------------------------------------------

        //  Similar to JavaScript when creating fuctions


        /*
             - Similar to JavaScript when creating fuctions
             - void: Means this method/function won't return any type of
               information
             - SayHi is the name of the method we specified
             - SayHi take parameters/arguement, which is a name
        */


        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + age);
        }



        // RETURN STATEMENT ----------------------------------------------------

        /*
            - returning an int
            - int num is the number we want to pass through
        */
        static int cube(int num) {
            int result = num * num * num;

            // Return a piece of info to the caller. Also breaks out the method 
            return result;
        }



        // MORE IF STATEMENTS --------------------------------------------------

        // Making a max method - Give two values and will execute the biggest
        // number
        static int GetMax(int num1, int num2)
        {
            int result;

            // Comparing two values
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }


            // Return the result from this method
            return result;
        }



        // SWITCH STATEMENTS ---------------------------------------------------

        /*
            - Checks conditions similar to if statements
            - Less messier/eaiser than if statements if it becomes lengthy
        */

        static string GetDay(int dayNumber)
        {
            string dayName;

            switch (dayNumber)
            {
                /*
                     In the case the dayNumber is 0 then do this. If dayNumber
                     has a value of 0 then make dayName equal to Sunday.
                 */
                case 0:
                    dayName = "Sunday";

                    /*
                        Break out of the structure instead of continuing to
                        check. If this is not defined then the switch will
                        continue and change the value.
                    */
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;

                /*
                    If the user has inputted a invalid number that doesn't match
                    the above numbers specificed then we want to show a default
                    message.
                */
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;

        }


        // BUILD A GUESSING GAME -----------------------------------------------

        static string GuessingGame()
        {
            string secretWord = "Bunnies";
            string usersAnswer = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuesses = false;

            /*
                Keeps asking user if the guess is wrong and they're not out of
                guesses
            */
            while (usersAnswer != secretWord && !outOfGuesses)
            {
                // if the guessCount is under the limit (5) then prompt question
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Guess the secret word: ");
                    usersAnswer = Console.ReadLine();
                    guessCount++;
                }
                // else the outOfGuesses is true
                else
                {
                    outOfGuesses = true;
                }

            }

            // If outOfGuesses is true/the user is out of guesses, then error
            // out
            if (outOfGuesses)
            {
                Console.WriteLine("Sorry, you've run out of guesses");
                return "No guesses";
            }
            // If the user wins, then congratulate
            else
            {
                Console.WriteLine("You got it!");
                return "Correct";
            }

            // Challenge - use a do while loop to build this game
        }

        static string forLoops()
        {

            return "";
        }
    }
}
