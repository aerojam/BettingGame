using System;
using System.Collections.Generic;
using System.Text;

namespace BettingGame
{
    class Guy
    {
        public string Name;
        public int Cash;
        
        /// <summary>
        /// Writes my name and amount of cash in my pocket to the console.
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine("My name is " + Name + " and have €" + Cash + " in my pocket.");
        }

        /// <summary>
        /// Gives amount of cache to another guy and removes this amount from my cash. 
        /// </summary>
        /// <param name="amount">Amount of cash to give.</param>
        /// <returns>
        /// Amount of cache removed from my wallet or 0 if I don't have
        /// enough cash or the amount is invalid.
        /// </returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: €" + amount + " is not a valid amount.");
                return 0;
            }
            
            if (amount > Cash)
            {
                Console.WriteLine(Name + " says: I don't have enough cash to give you €" + amount);
                return 0;
            }

            Cash -= amount;
            return amount;
        }

        /// <summary>
        /// Recives some cash and adding it to my wallet. Or printing message if the amount is invalid.
        /// </summary>
        /// <param name="amount">Amount of cash to receive</param>
        /// <returns></returns>
        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " says: €" + amount + " is not a valid amount.");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
