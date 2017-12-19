using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeApps
{
    class Program
    {
        static void Main(string[] args)
        {
            int chosen;
            Console.WriteLine("Please enter a number between 1 and 10");

            while (int.TryParse(Console.ReadLine(), out chosen) == false)
            {
             Console.WriteLine("Try again, please: ");   
            }

            if (chosen <= 0 || chosen > 10)
            {
                Console.WriteLine("Sorry, that number is invalid.");
                Console.WriteLine("Please enter a number between 1 and 10");

                while (int.TryParse(Console.ReadLine(), out chosen) == false)
                {
                    Console.WriteLine("Try again, please: ");
                }
            }
            else if (chosen > 0 && chosen <= 10)
            {
                Console.WriteLine("Congrats.  You can read!");
            }
            
        }

    }
}
