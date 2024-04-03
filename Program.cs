using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool game = true;
            int menu;
            while (game = true)
            {
                Console.WriteLine("Hey coders, how do you like my little menu? \n1) Prompter \n2) Percentage Calculator \n3) Odd Sum \n4) Random Numbers \n5) The Dice game \n6) LEAVE");
                if (int.TryParse(Console.ReadLine(), out menu))
                {
                    if (menu == 1)
                    {
                        Prompter();
                    }
                    if (menu == 2)
                    { 
                    PercentageCalc();
                    }
                    if (menu == 3)
                    {
                    OddSum();
                    }
                    if (menu == 4)
                    {
                    RandomNum();
                    }
                    if (menu == 5)
                    {
                    DiceGame();
                    }
                    if (menu == 6)
                    {
                        game = false;
                    }
                }
                else
                {
                    Console.WriteLine("It would seem your choice is not on our menu, press ENTER to start again.");
                    Console.ReadLine();

                }
            }
        }
        static void Prompter()
        {
            int min, max;
            bool minEnter = false, maxEnter = false;
            Console.WriteLine();
            Console.WriteLine("*WELCOME TO THE PROMPTER*:");
            Console.WriteLine("The prompter will give take two numbers from you\nand return a random value inbetween your two givens\n\nLet's get your first whole number:");
            while (minEnter == false)
            {
                if (int.TryParse(Console.ReadLine().Trim(), out min))
                {
                    minEnter = true;
                }
                else
                {


                    Console.WriteLine("For one reason or another, your minimum does not compute.\nPlease try again and remember whole numbers only (no decimals)");
                }
            }
        }
        static void PercentageCalc()
        {

        }
        static void OddSum()
        {

        }
        static void RandomNum()
        {

        }
        static void DiceGame()
        {

        }
    }
}
