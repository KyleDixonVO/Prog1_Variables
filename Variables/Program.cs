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

            //Floats
            //Float = "floating point' = stores real numbers
            //100000000.0000
            //100000.0000000
            //10.00000000000
            
            float speed; //in kph
            float distanceTravelled; //in kms
            speed = 100.0f;
            distanceTravelled = 2345.67f;
            
            Console.WriteLine("Speed: " + speed);
            Console.WriteLine("odometer: " + distanceTravelled);

            Console.ReadKey(true);


            //Ints Vs Floats
            int intTest;
            float floatTest;
            intTest = 10 / 3; // = 3
            floatTest = 10 / 3; // =3
            Console.WriteLine(intTest);
            Console.WriteLine(floatTest);
            floatTest = 10.0f / 3.0f; // =3.333333...
            Console.WriteLine(floatTest);

            Console.ReadKey(true);
            
            //Formulas
            //Code is executed in order, variables may be overwritten if not careful.
            //Console.WriteLine is good for debugging.

            int lives;
            lives = 3; 
            Console.WriteLine("Lives: " + lives);
            lives = lives - 1;
            Console.WriteLine("Lives: " + lives);

            
            int enemyPoints;
            enemyPoints = 100; //storing or naming important numbers keeps code readable

            score = 0;
            Console.WriteLine(score);
            score = score + enemyPoints;
            Console.WriteLine(score);
            








            Console.ReadKey(true);
        }   
    
    }
}
