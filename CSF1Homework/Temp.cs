using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Temp
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            do
            {
                Console.WriteLine("Would you like a Celsius conversion? Or Ferinheit?");
                string userChoice = Console.ReadLine().ToLower();

                Console.Clear();

                switch (userChoice)
                {
                    case "f":
                    case "ferinheit":
                        Console.WriteLine("Please enter a temperature in celsius");
                        string temp = Console.ReadLine();
                        int cel = int.Parse(temp);

                        int far = cel * 9 / 5 + 32;
                        Console.WriteLine($"That is {far} in ferinheit");

                        Console.WriteLine("Would you like another? Y/N");
                        string another = Console.ReadLine().ToLower();

                        switch (another)
                        {
                            case "y":
                            case "yes":
                                break;

                            case "n":
                            case "no":
                                repeat = false;
                                break;

                            default:
                                break;
                        }
                        break;

                    case "c":
                    case "celsius":
                        Console.WriteLine("Enter a temperature in ferinheit.");
                        string newTemp = Console.ReadLine();
                        int newFar = int.Parse(newTemp);
                        int newCel = (newFar - 32) / 9 * 5;
                        Console.WriteLine($"That's {newCel} in celsius");

                        Console.WriteLine("Would you like another? Y/N");
                        string another1 = Console.ReadLine().ToLower();

                        switch (another1)
                        {
                            case "y":
                            case "yes":
                                break;

                            case "n":
                            case "no":
                                repeat = false;
                                break;

                            default:
                                break;
                        }

                        break;



                    default:
                        Console.WriteLine("Invalid Selection.\n");

                        break;
                }
            } while (repeat);
        }
    }
}
