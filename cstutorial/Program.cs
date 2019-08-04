using System;

// using System; is a command
// Configuring the file
// Will need to use with C# so we need to specify it


// Saying what project we're in
namespace cstutorial
    // These specific curly brackets signals our program is starting
    // Can write code in here
{
    // "class" is a container where we can put in our code
    // A program is a set of instructions specificed in a particular order
    class Program

    {
        // Method or a function. Another container where we can put out code
        // Main is important because we can put all our code here and this code
        // will execute in terminal
        static void Main(string[] args)
        {
            // Opens up the terminal and prints this.
            // Reads line by line (like vanilla JS)
            Console.WriteLine("Hello World");

            // Keeps the console open
            // Console.WriteLine();

            // Creating a variable, storing plain text which is a string.
            string name = "sumitra manga";

            // Creating a variable to store a number. 'int' is used which means
            // a whole number.
            // (not a decimal number)
            // Can also use negative (-30) numbers
            // Can be fractional as well as whole values
            int age = 21;
            double gpa = 3.2;


            // Can also do this
            // int age;
            // age = 21;

            var concatNameAndAge = name + " " + age;

            // char means character. Only a single character can be stored
            // within this variable. If we are wanting to store more than one
            // character then the 'string' will have to be used. We also use
            // single quotes for 'char'.
            char grade = 'A';


            // Boolean
            bool isFemale = true;

            // constant - not stored in a variable not keeping track of it

            // "\n" will print the following on a separate line
            string newLine = "sumitra\nmanga";

            // Print the quotation mark whilst still being able to close the
            // string.
            string quoteWithinString = "sumitra\"manga";

            // Get the number of characers within a string
            var getLength = newLine.Length;



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

            // Get the character index position (remember to use single
            // quotation's))
            var getCharIndexPos = name.IndexOf('m');

            // Print out everything from this index position and end when 3
            // characters have been printed.
            var printLetters = name.Substring(8, 3);
            // Result - man



            // WORKING WITH NUMBERS --------------------------------------------

            var testSum1 = 1 + 1 * 4;

            var addNumbersInBracketsThenTimesByFour = (1 + 1) * 4;
            // Result - 2 * 4

            int num = 6;
            num++;
            // Result - 7
            // Can do a similar thing with "num--" which will equal to 5


            // Math methods
            // ------------

            var getMaxNumber = Math.Max(4, 90);
            // Result - 90

            var getMinimumNumber = Math.Min(4, 90);
            // Result - 4

            var getNearestWholeNum = Math.Round(4.3);
            // Result - 4



            // GETTING USER INPUT ----------------------------------------------

            // We are holding the app from doing anything until the user puts in
            // their name.
            //Console.WriteLine("Enter your name: ");

            // The name typed out is stored in the usersName variable
            // string usersName = Console.ReadLine();

            // Write Hello and the name
            // Console.WriteLine("Hello " + usersName);

            // Coverting a string into a number
            int number = Convert.ToInt32("45");
            // Console.WriteLine(number);

            // We need to covert the Console.Readline() as it is a string by
            // default.
            // int usersNumberInput = Convert.ToInt32(Console.ReadLine());



            // ARRAY'S ---------------------------------------------------------

            // Making an array of numbers by signifiy the square brakets
            int[] numbers = { 5, 10, 15, 20, 25 };

            // Changing the value within a certain index position
            numbers[2] = 50;

            // Result - 50
            // Console.WriteLine(numbers[2]);

            // Creating a new array, we need to define the length/size of the
            // array if it is empty so it knows how much data can be stored.
            string[] friends = new string[5];

            // Populate the array
            friends[0] = "Jim";



            // METHODS ---------------------------------------------------------

            // Calling the SayHi method as it won't execute on its own unless
            // it's called in the Main method.

            // Passing through values name and age
            SayHi("Priya", 21);
            // Result = "Hello Priya21"


            // RETURN STATEMENT ------------------------------------------------

            // cube(2); wont work as we haven't console.write within the method

            // Console.WriteLine(cube(2));
            // Result = 8



            // IF STATEMENTS ---------------------------------------------------

            bool isAFemale = true;
            bool isTall = true;

            // && = and
            // || = or

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


            Console.WriteLine(GetDay(4));
            // Result = Thursday
        }
        // Main Method ends ======



        // METHODS -------------------------------------------------------------

        // - Similar to JavaScript when creating fuctions

        // void - Means this method/function won't return any type of information
        // SayHi is the name of the method we specified

        // sayHi take parameters/arguement, which is a name
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + age);
        }



        // RETURN STATEMENT ----------------------------------------------------

        // returning an int
        // int num is the number we want to pass through
        static int cube(int num) {
            int result = num * num * num;

            // return a piece of info to the caller. also breaks out the method 
            return result;
        }



        // MORE IF STATEMENTS --------------------------------------------------

        // Making a max method - Give two values and will execute the biggest number
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

        // - Checks conditions similar to if statements
        // - Less messier/eaiser than if statements if it becomes lengthy

        static string GetDay(int dayNumber)
        {
            string dayName;

            switch (dayNumber)
            {
                // In the case the dayNumber is 0 then do this. If dayNumber has
                // a value of 0 then make dayName equal to Sunday.
                case 0:
                    dayName = "Sunday";
                    // Break out of the structure instead of continuing to check
                    // If this is not defined then the switch will continue and
                    // change the value.
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

                // If the user has inputted a invalid number that doesn't match
                // the above numbers specificed then we want to show a default
                // message.
                default:
                    dayName = "Invalid Day Number";
                    break;
            }


            return dayName;

            // WHILE LOOPS -----------------------------------------------------

        }
    }
}
