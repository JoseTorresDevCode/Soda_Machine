using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        //Member Variables
        public List<Coin> coins;

        //Constructor
        public Wallet()
        {
            coins = new List<Coin>;
            AddWalletCoins();
        }


        //Member Methods
                 //payment method
        
        public void AddWalletCoins()
        {
            for (int i = 0; i < 12; i++)
            {
                coins.Add(new Quarter());
            }
            for (int i = 0; i < 20; i++)
            {
                coins.Add(new Dime());
            }
            for (int i = 0; i < 10; i++)
            {
                coins.Add(new Nickel());
            }
            for (int i = 0; i < 50; i++)
            {
                coins.Add(new Penny());
            }
        }         
    }
}
