using System;

// using System; is a command
// Configuring the file
// Will need to use with C# so we need ot specify it


// Saying what project we're in
namespace cstutorial
    // These specific curly brackets signals our program is starting
    // Can write code in here
{
    // class is a container where we can put in our code
    // A program is a set of instructions specificed in a particular order
    class Program

    {
        // Method or a function. ANother container where we can put out code
        // Main is important because we cna put all our code here
        // This code will execute 
        static void Main(string[] args)
        {
            // Opens up the terminal and prints this.
            // Reads line by line (like vanilla JS)
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello there World");

            // Keeps the console open
            //Console.WriteLine();

            // Creating a variable, storingplain text which is a string
            // 
            string name = "Sumitra";

            // Creating a variable to store a number. int is used means whole numbeer (not a decimal number)
            int age = 21;

            // can also do this 
            // int age;
            // age = 21;

            Console.WriteLine(name + " " + age);

        }
    }
}
