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
            while (game == true)
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
                    Console.Clear();

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
                    Thread.Sleep(3000);
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
            string entered;
            Console.WriteLine("Let's count the assingments passed within your academic record. \nStart by entering each grade and hitting enter to continue to the next.");
            Console.WriteLine("Type your next grade then hit enter to continue or leave your line blank and hit Enter to Submit your results");
            while (activeGrades == true) 
            {
            
                entered = Console.ReadLine();
                if (Double.TryParse(entered.Trim(),out grade) && grade <= 100)
                {
                    ++assingments;
                    if(grade > 70)
                    {
                        trophyScores++;
                    }
                }
                else if (entered == "")
                {
                    activeGrades=false;
                }
                else
                {
                    Console.WriteLine("*VALUE DOES NOT COMPUTE* (make sure to use a number value within 0-100, and that uses a reasonable # of decimals)");
                }
            }
            Console.WriteLine($"It reads here that you've exceeded on {Math.Round(((trophyScores/assingments)*100),1)}% of your assingments");
            if (Math.Round((trophyScores / assingments),1) > 0.5)
            {
                Console.WriteLine("Your an academic weapon!");
            }
            else
            {
                Console.WriteLine("Your less then your average Joe six pack");
            }
            Console.ReadLine();
            Console.Clear();
        }
        static void OddSum()
        {
                int total = 0, chosen = 0;
            bool validNum = false, negative= false;
            Console.WriteLine("Go ahead and enter a number and I will add all the uneven previous numbers till' zero \nWell go on now...(whole numbers only)");
            while (validNum == false)
            {
                if (int.TryParse(Console.ReadLine().Trim(), out chosen))
                {
                    if (chosen < 0)
                    {
                        chosen = (chosen * -1);
                        negative = true;
                    }

                    for (int i = 0; i < chosen; i++)
                    {
                        if ( (i % 2) == 1)
                        {
                            total = total + i;
                        }
                    }
                    if (negative == true)
                    {
                        total = (total * -1); 
                    }
                    Console.WriteLine($"Counting from all the odd numbers your number rounds up to be {total}.\nDrop a like and comment if you enjoyes this program and I'll see yall on the next one");
                   Console.ReadLine ();
                    Console.Clear();
                    validNum = true;
                }
                else
                {
                    Console.WriteLine("Your number is no good, remember I'll be needing a whole number (no decimals) and a WHOLE NUMBER ONLY!");
                }
            }
        }
        static void RandomNum()
        {
            Random genorator = new Random();
            int max = 0, min = 0;
            bool validInput = false;
            Console.WriteLine("The random numbers is all about selection, \nso given a range you'll be returned with an ample 25 numbers to do with as you please!");
            Console.WriteLine("Please start with giving me a minimum to work with (whole number)");
            while (validInput == false)
            {
                if (int.TryParse(Console.ReadLine().Trim(), out min))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("For one reason or another, your minimum does not compute.\nPlease try again and remember whole numbers only (no decimals)");
                }
            }
            Console.WriteLine("MINIMUM ACCEPTED");
            Thread.Sleep(1000);
            Console.WriteLine("**\nNow we'll need to get a maximum value,\nsomething bigger then your first (still no deciamls):");
            validInput = false;
            while (validInput == false)
            {
                if (int.TryParse(Console.ReadLine().Trim(), out max) && max > min)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine($"Your value was either not a valid number (No decimals), or was equal or smaller then your minimum ({min}) \nTry Again.");
                }
            }
            Console.WriteLine("Computing...");
            Thread.Sleep(1000);
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine($"{genorator.Next(min,max+1)}");
                Thread.Sleep(300);
            }
            Console.WriteLine("PROGRAM: 'Random Numbers' - COMPLETED \nPlease press 'ENTER' to continue.");
            Console.ReadLine();
            Console.Clear();

        }
        static void DiceGame()
        {

        }
    }
}
