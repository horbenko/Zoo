using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooConsole
{
    class ZooConsoleApp
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("<--- You are in the console emulator of life in a zoo. ---> ");
            Console.WriteLine("The zoo already has animals: one for each available species.");

            //Default added animals
            Zoo zoo = new Zoo();
            zoo.Add("Baako", Animal.Species.Bear);
            zoo.Add("Eamon", Animal.Species.Elephant);
            zoo.Add("Fabio", Animal.Species.Fox);
            zoo.Add("Lacey", Animal.Species.Lion);
            zoo.Add("Tad", Animal.Species.Tiger);
            zoo.Add("Walcott", Animal.Species.Wolf);

            foreach (string name in zoo)
            {
                Console.Write(name + ", ");
            }
            Console.WriteLine('.');
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }
}