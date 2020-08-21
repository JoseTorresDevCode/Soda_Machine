using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SodaMachine
{
    static class UserInterface
    {
        //Member Variables
        //soda price? 

        //private static double colaPrice = .35;
        //private static double rootBeerPrice = .60;
        // private static double orangeSodaPrice = .06;
        // private static double quarterValue = .25;
        // private static double dimeValue = .10;
        // private static double nickelValue = .05;
        // private static double pennyVaule = .01

        //Constructor

        //Member Methods
        public static string MakeASelection()
        {
            Console.WriteLine("Please Enter your selection");
            Console.WriteLine("Enter 1: Orange Soda / Enter 2: Root Beer / Enter 3: Cola");

            string userInput = "";
            bool validChoice = false;
            while (validChoice == false)
            {
                
                userInput = Console.ReadLine();
                if (userInput == "1" || userInput == "2" || userInput == "3")
                {
                    validChoice = true;
                    Console.WriteLine("You have selected:" + " " + userInput);
                }
                else
                {
                    Console.WriteLine("Your choice was invalid, please choose again");
                    return MakeASelection();
                }

            }
            return userInput;

            
        }


        public static string PayWithCoin()
        {
            Console.WriteLine("please enter coins to pay");
            Console.WriteLine("Enter: quarter Enter: dime Enter: nickel Enter: penny");

            string coinInput = "";
            bool isCoinSelected = false;

            while (isCoinSelected == false)
            {
                coinInput = Console.ReadLine();
                if (coinInput == "quarter" || coinInput == "dime" || coinInput == "nickel" || coinInput == "penny")

                {
                    isCoinSelected = true;
                    Console.WriteLine("You entered a:" + coinInput);
                }
                else
                {
                    Console.WriteLine("You entered an invalid coin. Please enter a valid coin.");
                    return PayWithCoin();
                }

            }
            return coinInput;
        }




        // Greet(make your selection) 
        // insert coin or pay with card 
        //  disperse change? 
    }
}
