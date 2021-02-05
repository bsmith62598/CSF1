using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoops
    {
        static void Main(string[] args)
        {
            string[] periods = new string[6];
            periods[0] = ".";
            periods[1] = "..";
            periods[2] = "...";
            periods[3] = "....";
            periods[4] = ".....";
            periods[5] = "......";

            string[] fruits = new string[6];
            fruits[0] = "Apple";
            fruits[1] = "Grape";
            fruits[2] = "Kiwi";
            fruits[3] = "Peach";
            fruits[4] = "Pear";
            fruits[5] = "Orange";
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"{fruits[i]}\n");
                Console.WriteLine($"{periods[i]}");
            }
        }
    }
}
