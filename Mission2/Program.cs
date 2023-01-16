﻿using System;
using System.Linq;

namespace Mission2
{
    class Program
    {
        static int numOfOptions = 11;
        static int[] totals = new int[numOfOptions];

        static int numRolled;

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("");
            Console.WriteLine("How many dice rolls would you like to simulate? ");
            Console.WriteLine("");
            numRolled = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i < numRolled; i++)
            {
                Random rnd = new Random();

                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);

                int sum = dice1 + dice2;

                AddToArray(sum);
            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each ' * ' represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numRolled}.");
            Console.WriteLine("");

            Print();
            Console.WriteLine("");
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }

        static void AddToArray (int sum)
        {
            switch(sum)
            {
                case 2:
                    totals[0] = totals[0] + 1;
                    break;
                case 3:
                    totals[1] = totals[1] + 1;
                    break;
                case 4:
                    totals[2] = totals[2] + 1;
                    break;
                case 5:
                    totals[3] = totals[3] + 1;
                    break;
                case 6:
                    totals[4] = totals[4] + 1;
                    break;
                case 7:
                    totals[5] = totals[5] + 1;
                    break;
                case 8:
                    totals[6] = totals[6] + 1;
                    break;
                case 9:
                    totals[7] = totals[7] + 1;
                    break;
                case 10:
                    totals[8] = totals[8] + 1;
                    break;
                case 11:
                    totals[9] = totals[9] + 1;
                    break;
                case 12:
                    totals[10] = totals[10] + 1;
                    break;
            }
        }

        static void Print()
        {
            int num = 2;// this will be used for printing the numbers out

            for (int i = 0; i < numOfOptions; i++)
            {
                decimal percent; // will hold the percent of the total for each num
                string astricks = ""; // this will hold the num of astricks each number has
                int arrayNum = totals[i];
                // this equation will get the percent of each type of roll
                percent = ((decimal)arrayNum / (decimal)numRolled) * (decimal)100;

                for (int t = 0; t < percent; t++)
                {
                    astricks += "*";
                }



                Console.WriteLine($"{num}: {astricks}");

                num++; // this will increment the number each time one is printed
            }
            
        }
    }
}
