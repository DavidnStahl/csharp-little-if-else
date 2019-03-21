using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_terms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name? ");    
            string name = Console.ReadLine();   

            if (name == "Anna")                 
            {
                Console.WriteLine("Hello Anna!");
                Console.WriteLine("Is it okey if I call you \"Anna Panna\"...?");
            }
            else if (name == "Olle")            
            {
                Console.WriteLine("Hey Olle!");
                Console.WriteLine("Is it okey if I call you \"Olle Bolle\"...?");
            }
            else                                
            {
                Console.WriteLine("Hey " + name + "!");
                Console.WriteLine("Is it okey if I call you \"Friend\"...?");
            }

            Console.ReadLine();
        }
    }
}
