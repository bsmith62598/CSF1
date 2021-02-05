using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.Title = "Mad Lib";
            Console.WriteLine("Please enter some information when prompted to do this Mad Lib\n");
            string[] Lib = new string[10];

            Console.WriteLine("Noun");
            Lib[0] = Console.ReadLine();

            Console.WriteLine("Verb");
            Lib[1] = Console.ReadLine();

            Console.WriteLine("Adjective");
            Lib[2] = Console.ReadLine();

            Console.WriteLine("Noun");
            Lib[3] = Console.ReadLine();

            Console.WriteLine("Verb ending in -ing");
            Lib[4] = Console.ReadLine();

            Console.WriteLine("Adjective");
            Lib[5] = Console.ReadLine();

            Console.WriteLine("Adverb");
            Lib[6] = Console.ReadLine();

            Console.WriteLine("Exclamation");
            Lib[7] = Console.ReadLine();

            Console.WriteLine("City");
            Lib[8] = Console.ReadLine();

            Console.WriteLine("A Time");
            Lib[9] = Console.ReadLine();

            Console.WriteLine($"Here is the Mad Lib you created. \n ");
            Console.WriteLine($"{Lib[0]} {Lib[1]} {Lib[2]} {Lib[3]} {Lib[4]} {Lib[5]} {Lib[6]} {Lib[7]} {Lib[8]} {Lib[9]}");
        }
    }
}
