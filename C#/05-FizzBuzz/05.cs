using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFizzBuzz
{
    //programming challenge 05 FizzBuzz  //@github/simonl94
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                bool fizz = i % 3 == 0; //Defines fizz to be divisible by 3
                bool buzz = i % 5 == 0; //Defines buzz to be divisible by 5

                if (fizz && buzz) //If divisible by both Fizz & Buzz
                {
                    Console.Write("Fizz Buzz"); //Write to the console "Fizz Buzz"
                }
                else if (fizz) //If 'i is divisible by fizz (3)
                {
                    Console.Write("Fizz"); //Write to the console "Fizz"
                }
                else if (buzz) //If 'i' is divisible  by "Buzz"
                {
                    Console.Write("Buzz"); //Write to the console "Buzz"
                }
                else 
                Console.Write(i); //If not divisible by 'fizz' or 'buzz', print 'i'
                Console.ReadLine(); //Waits for the 'enter' key to be pressed
            }
        }
    }
}
