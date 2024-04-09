using Making_a__die;
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
                Console.WriteLine($"{genorator.Next(min, max + 1)}");
                Thread.Sleep(300);
            }
            Console.WriteLine("PROGRAM: 'Random Numbers' - COMPLETED \nPlease press 'ENTER' to continue.");
            Console.ReadLine();
            Console.Clear();
        }
        static void DiceGame()
        {
            Console.WriteLine("Welcome to your The thundering times. \nYou'll be starting with 100$ and will go from there.");

            bool diceGame = false, doubles, even;
            double balance = 100.00, bet, win = 0.00;
            string betOption, gameEnthusiasm;
            Die dieOne;
            Die dieTwo;

           

            dieOne = new Die();

            dieTwo = new Die();

            while (diceGame == false)
            {
                bet = 0;
                Console.WriteLine($"You have {balance}$ in your betting account go to town \nYou will be rolling two dice and putting money on the expected result.");
                Console.WriteLine("Bet Options: \nA) Doubles - X3 your bet \nB) Not Doubles - X1.5 your bet\nC) Even Roll - X2 your bet\nD) Odd Roll - X2 your bet");
                betOption = null;
                while (betOption == null)
                {

                    Console.WriteLine("Which result would you like to put your money on?");
                    betOption = Console.ReadLine().ToLower();
                    if (betOption == "a")
                    {
                        Console.WriteLine("You've locked in on Doubles.");
                        win = 2.00;
                    }
                    else if (betOption == "b")
                    {
                        Console.WriteLine("You've locked in on not doubles");
                        win = 0.50;
                    }
                    else if (betOption == "c")
                    {
                        Console.WriteLine("You've locked in on an Even Result");
                        win = 1.00;
                    }
                    else if (betOption == "d")
                    {
                        Console.WriteLine("You've locked in on an Odd result");
                        win = 1.00;
                    }
                    else if (betOption != null)
                    {
                        Console.WriteLine("Seems your bet isn't in our system, we'll say your sitting out this turn");
                        win = 0.00;
                    }
                    else
                    {
                        Console.WriteLine("Your bet wasn't valid, make sure you use the letter representative and nothing else! \nTry again...");
                    }

                }

                Console.WriteLine($"Balance: {balance}$\nNow that we got your picks,\nHow much would you like to put down (remember you only have so much)?");
                if (Double.TryParse(Console.ReadLine(), out bet))
                {
                    if (bet > balance)
                    {
                        bet = balance;
                    }
                    if (bet < 0)
                    {
                        bet = 0.00;
                    }
                }
                else
                {
                    bet = 0.00;
                }
                bet = Math.Round(bet, 2);
                Console.WriteLine("Alright we're ready to roll! \nPress 'ENTER' to roll.");
                Console.ReadLine();
                dieOne.RollDie();
                dieOne.DrawRoll();
                dieTwo.RollDie();
                dieTwo.DrawRoll();

                Console.WriteLine($"The result is {(dieOne.Roll + dieTwo.Roll)}");
                if (((dieOne.Roll + dieTwo.Roll) % 2.00) == 0)
                {
                    even = true;
                    Console.WriteLine("You got an even roll");
                }
                else
                {
                    even = false;
                    Console.WriteLine("You got an odd roll");
                }
                if (dieOne.Roll == dieTwo.Roll)
                {
                    doubles = true;
                    Console.WriteLine("Huzzah! you got doubles.");
                }
                else
                {
                    doubles = false;
                    Console.WriteLine("No doubles.");
                }
                if (betOption == "a")
                {
                    if (doubles == true)
                    {
                        balance = (bet * win) + balance;
                        Console.WriteLine("\nWinner, winner, chicken dinner!");
                    }
                    else
                    {
                        balance = balance - bet;
                        Console.WriteLine("\nBetter luck next time!");
                    }
                }
                if (betOption == "b")
                {
                    if (doubles == true)
                    {
                        balance = balance - bet;
                        Console.WriteLine("\nBetter luck next time!");
                    }
                    else
                    {
                        balance = (bet * win) + balance;
                        Console.WriteLine("\nWinner, winner, chicken dinner!");
                    }
                }
                if (betOption == "c")
                {
                    if (even == true)
                    {
                        balance = (bet * win) + balance;
                        Console.WriteLine("\nWinner, winner, chicken dinner!");
                    }
                    else
                    {
                        balance = balance - bet;
                        Console.WriteLine("\nBetter luck next time!");
                    }
                }
                if (betOption == "d")
                {
                    if (even == true)
                    {
                        balance = balance - bet;
                        Console.WriteLine("\nBetter luck next time!");
                    }
                    else
                    {
                        balance = (bet * win) + balance;
                        Console.WriteLine("\nWinner, winner, chicken dinner!");
                    }
                }
                balance = Math.Round(balance, 2);
                if (balance == 0)
                {
                    Console.WriteLine("Unfortunatly you've run clean out of funds, you'll be returned to the menu now");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                Console.WriteLine($"You have {balance}$ left in your account\nWould you like to continue playing. Y or N");
                gameEnthusiasm = Console.ReadLine().Trim().ToLower();
                if (gameEnthusiasm == "y")
                {
                    diceGame = false;
                }
                else if (gameEnthusiasm == "n")
                {
                    diceGame = true;
                    Console.WriteLine("Thanks for stopping by!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Looks like your having troubles navigating, looks like your stuck with us forever\nMWAHAHAHA!");
                }
            }
        }
    }
}
