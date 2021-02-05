using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {
            bool menu = true;
            string yourUserName = "thatguy";
            do
            {

                Console.WriteLine("Please enter your user name to continue.");
                string userName = Console.ReadLine().ToLower();
                if (userName == yourUserName)
                {
                    menu = false;
                }
                if (userName != yourUserName)
                {
                    Console.WriteLine("Oops, the user name you entered doesn't match any account. Please try again.");
                }
            } while (menu);

            Console.Clear();

            bool pin = true;
            int password = 7777;
            do
            {
                Console.WriteLine("Please enter your password to continue.");
                string userPin = Console.ReadLine();
                int userPinNumber = int.Parse(userPin);

                if (userPinNumber == password)
                {
                    pin = false;
                }

                if (userPinNumber != password)
                {
                    Console.WriteLine("Looks like you've entered the wrong password. Please try again.");
                }
            } while (pin);

            Console.Clear();
        }
    }
}
