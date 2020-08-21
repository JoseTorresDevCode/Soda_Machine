using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        //Member Variables
        
        public List<Can> machineInventory;
        public List<Coin> register;
        //Constructor
        public SodaMachine()
        {
            machineInventory = new List<Can>();
            register = new List<Coin>();
            FillRegister();
            FillSodaMachine();
        }
            
        //Member Methods
        public void FillRegister()
        {
            for (int i = 0; i < 20; i++)
            {
                register.Add(new Quarter());
            }
            for (int i = 0; i < 10; i++)
            {
                register.Add(new Dime());
            }
            for (int i = 0; i < 20; i++)
            {
                register.Add(new Nickel());
            }
            for (int i = 0; i < 50; i++)
            {
                register.Add(new Penny());
            }

            
        }

        public void FillSodaMachine()
        {
            for (int i = 0; i < 15; i++)
            {
                machineInventory.Add(new OrangeSoda());
            }
            for (int i = 0; i < 15; i++)
            {
                machineInventory.Add(new RootBeer());
            }
            for (int i = 0; i < 15; i++)
            {
                machineInventory.Add(new Cola());
            }
        }


        //public string SellASoda(Customer customer)
       // {
            //Take in payment

           // Console.WriteLine($"Your selection is: + {UserInterface.MakeASelection()}");
          // / 
            
            
            
            
            //Soda choice - pass in?







            //Cola cola = new Cola();
            //customer.backpack.cans.Add(machineInventory[0]);


       // }

    }
}
