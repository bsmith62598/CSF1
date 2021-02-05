using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            bool menu = true;
            int accountNumber = 123456789;
            do
            {
                Console.WriteLine("Thank you for using this ATM.");
                Console.WriteLine("Please enter your account number to continue.");
                string userAccountNumber = Console.ReadLine();
                int userAccount = int.Parse(userAccountNumber);
                if (userAccount == accountNumber)
                {
                    menu = false;
                }
                if (userAccount != accountNumber)
                {
                    Console.WriteLine("Oops, the account number you entered doesn't match any account. Please try again.");
                }
            } while (menu);

            Console.Clear();

            bool pin = true;
            int pinNumber = 7777;
            do
            {
                Console.WriteLine("Please enter your 4 digit pin code to continue.");
                string userPin = Console.ReadLine();
                int userPinNumber = int.Parse(userPin);

                if (userPinNumber == pinNumber)
                {
                    pin = false;
                }

                if (userPinNumber != pinNumber)
                {
                    Console.WriteLine("Looks like you've entered the wrong pin number. Please try again.");
                }
            } while (pin);

            Console.Clear();

            bool repeat = true;
            decimal balance = 0;
            bool overDraft = true;
            do
            {
                Console.WriteLine("Thanks for banking with us. How can we help you today?");
                Console.WriteLine(" B for Balance\n D for Deposit\n W for Withdraw\n X for Exit");
                string userChoice = Console.ReadLine().ToLower();

                Console.Clear();

                switch (userChoice)
                {
                    case "b":
                    case "balance":
                        Console.WriteLine($"Your account balance is {balance:c} \n");
                        break;

                    case "d":
                    case "deposit":
                        Console.WriteLine("How much would you like to deposit? \n");
                        string deposit = Console.ReadLine();
                        decimal depositValue = decimal.Parse(deposit);
                        balance += depositValue;
                        Console.WriteLine($"Thank you. Your new balance is {balance:c}");
                        break;

                    case "w":
                    case "withdraw":
                        Console.WriteLine("How much would you like to withdraw?\n");
                        string withdraw = Console.ReadLine();
                        decimal withdrawValue = decimal.Parse(withdraw);

                        Console.Clear();

                        if (withdrawValue > balance)
                        {
                            do
                            {
                                Console.WriteLine("Are you sure? This will result in an overdraft. Additional fees will apply to accounts without overdraft protection.");
                                Console.WriteLine("Input yes or no in the form of Y for yes, or N for no.");
                                string overDraftSelection = Console.ReadLine().ToLower();
                                switch (overDraftSelection)
                                {
                                    case "y":
                                    case "yes":
                                        balance -= withdrawValue;
                                        Console.WriteLine(balance);
                                        Console.WriteLine($"All set. Your new balance is {balance}");
                                        overDraft = false;
                                        break;

                                    case "n":
                                    case "no":
                                        Console.WriteLine("Good idea.");
                                        overDraft = false;
                                        break;

                                    default:
                                        Console.WriteLine("Invalid selection. Please try again.");
                                        break;
                                }
                            } while (overDraft);
                        }

                        else if (withdrawValue <= balance)
                        {
                            balance -= withdrawValue;
                            Console.WriteLine($"Your new blance is {balance:c}");
                        }
                        break;

                    case "x":
                    case "exit":
                        Console.WriteLine("Thanks for your business. Goodbye.");
                        repeat = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Selection. \n");

                        break;
                }
            } while (repeat);
        }
    }
}
