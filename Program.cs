using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
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
            Random generator = new Random();
            double userNum = 0.00;
            int min = 0, max = 0;
            bool minEnter = false, maxEnter = false, exit = false;
            Console.WriteLine();
            Console.WriteLine("*WELCOME TO THE PROMPTER*:");
            Console.WriteLine("The prompter will take two numbers from you\nand return a random value inbetween your two givens\n\nLet's get your first whole number (minimum):");
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
            Console.WriteLine("MINIMUM ACCEPTED");
            Thread.Sleep(1000);
            Console.WriteLine("**\nNow we'll need to get a maximum value,\nsomething bigger then your first (still no deciamls):");
            while (maxEnter == false)
            {
                if (int.TryParse(Console.ReadLine().Trim(), out max) && max > min)
                {
                    maxEnter = true;
                }
                else
                {

                    Console.WriteLine($"Either your value wasn't valid or was smaller then your first ({min}),\nplease try again and remember NO DECIMALS:");
                }
            }

            while (exit ==false)
            {
                Console.WriteLine($"Range: {min} - {max}\n");
                Thread.Sleep(1000);
                Console.WriteLine($"Enter a number within your range to leave the infernal progam!");

                if (Double.TryParse(Console.ReadLine().Trim(), out userNum) && userNum< max && userNum> min)
                {
                exit = true;
                    Console.WriteLine("By golly, you've done it! \nPress Enter to Exit.");
                    Console.ReadLine();
                    Console.WriteLine("(Flies away in binary back to the menu)");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("INCORRECT try again in '3' seconds.");
                    Thread.Sleep(3000);
                }
            }
            Console.Clear();
        }
        static void PercentageCalc()
        {
            bool activeGrades = true;
            double grade, assingments =0, trophyScores =0;
            Console.WriteLine("Let's count the assingments passed within your academic record. \nStart by entering each grade and hitting enter to continue to the next.");
            while(activeGrades == true) 
            {
             Console.WriteLine("Enter next grade or hit Enter to exit");
                if (Double.TryParse(Console.ReadLine().Trim(),out grade) && grade <= 100)
                {
                    ++assingments;
                    if(grade > 70)
                    {
                        trophyScores++;
                    }
                }
                if (Console.ReadLine().Trim() == null)
                {
                    activeGrades=false;
                }
            }
            Console.WriteLine($"It reads here that you've exceeded on {Math.Round((assingments/trophyScores),1)}% of your assingments");
            if (Math.Round((assingments / trophyScores),1)>50)
            {
                Console.WriteLine("Your an academic weapon!");
            }
            else
            {
                Console.WriteLine("Your less then your average Joe six pack");
            }
        }
        static void OddSum()
        {
                int total = 0, chosen = 0;
            Console.WriteLine("Go ahead and enter a number and I will add all the uneven previous numbers till' zero \nWell go on now...(whole numbers only)");
            if(int.TryParse(Console.ReadLine().Trim(),out chosen))
            {
                Console.WriteLine("");
            }
        }
        static void RandomNum()
        {

        }
        static void DiceGame()
        {

        }
    }
}
