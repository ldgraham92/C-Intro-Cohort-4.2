using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string name; // Declare a variable named string


            Console.WriteLine("Please Enter Your Name:"); // Tell the user what we're expecting them to input
            name = Console.ReadLine(); // Assign a value to the variable that we get from the user
         
            Console.WriteLine("Thank you, " + name);



        }
    }
}
