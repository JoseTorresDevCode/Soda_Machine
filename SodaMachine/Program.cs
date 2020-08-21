using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
         //   SodaMachine sellASoda = new SodaMachine();
          //  sellASoda.SellASoda();
              UserInterface.MakeASelection();
            //UserInterface.PayWithCoin();
            SodaMachine sellASoda = new SodaMachine();
           // sellASoda.SellASoda();
            Console.ReadLine();
            
         
        }
    }
}
