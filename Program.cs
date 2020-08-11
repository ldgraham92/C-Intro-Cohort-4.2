using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable using the datatype followed by the name
            string text; // Strings store text
            char character; // Stores a single character (Including space, newline, etc)
            int wholeNumber; // Int stores a number without a decimal point (positive or negative)
            // byte, short, and long are other int types with varying size limits
            double deciNumber; // Double stores a number with a decimal point
            // float and decimal are alternatives with quirks. Google them if you plan to use them
            bool boolean; // Bool stores a true or false value.

            string name; // Declare our variable
            int age, birthYear;

            Console.WriteLine("Please Enter Your Name:"); // Tell the user what we're expecting them to input
            name = Console.ReadLine(); // Assign a value to the variable that we get from the user
         
            Console.WriteLine("Please Enter Your Age:"); // Tell the user what we're expecting them to input
            age = int.Parse(Console.ReadLine()); // Convert the user's input to an integer and store it.
            // If the user enters something that isn't an integer, it will error.

           birthYear = DateTime.Now.Year - age;

            Console.WriteLine("Thank you, " + name + ". You are " + age + " years old. You were born in " + birthYear + ", assuming your birthday has passed this year already."); // Retrieve the value from the variable and send it to the output.



        }
    }
}
