using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy!");

           
            
            //Integers
            int score; //creates integer named score
            score = 0; //set the value of score, in this case 0

            Console.WriteLine(score); //accesses value of score
            Console.WriteLine("score"); //does not access value, writes quoted characters

            score = 100; //assigns score a new value, +100 points

            Console.WriteLine(score);
            Console.ReadKey(true); //waits for keypress

            score = score + 100; //adds 100 to the value to score

            Console.WriteLine(score);
            Console.ReadKey(true);

            //Strings

            string name; //declaring a string with the name "name"
            name = "yourNameHere";  //setting string variable
            Console.WriteLine(name);
            name = "Kyle";
            Console.WriteLine(name);

            string firstName;
            string lastName;
            string fullName;
            firstName = "Kyle";
            lastName = "Dixon";
            fullName = firstName + " " + lastName;
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(fullName);
            Console.ReadKey(true);
        }
    }
}
