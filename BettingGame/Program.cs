﻿using System;

namespace BettingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = .75;
            Guy player = new Guy() { Name = "The Player", Cash = 100 };

            Console.WriteLine("Welcome to The Casino. The odds are " + odds);
            while (player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.Write("How much do you want to bet: ");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;
                    if (random.NextDouble() > odds)
                    {
                        Console.WriteLine("Congratulations! You win " + pot);
                        player.ReceiveCash(pot);
                    }
                    else
                    {
                        Console.WriteLine("Bad luck, you loose");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            Console.WriteLine("The house always wins.");
        }
    }
}
