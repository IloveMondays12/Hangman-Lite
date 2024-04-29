namespace Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            string secretWord, guessLetter, wordSelectionMethod;
            int wrongGeusses, players, playerOneScore, playerTwoScore;
            bool menu = false, validNum = false, menuSelection = false;
            List <string> wordBank = new List<string>(); 
            while (!menu)
            {
                Console.WriteLine("Welcome to HANGMAN, where you are sent to try and save the stickman before he is drawn. \nHow many teams will be playing in your game today?");
                Console.WriteLine("1 or 2? :");
                while (validNum == false)
                {
                    if (int.TryParse(Console.ReadLine().Trim(), out players))
                    {
                        if (players == 1)
                        {
                           Console.WriteLine("Your number will be generated shortly...");
                            Thread.Sleep(1000);
                            validNum = true;
                            wordSelectionMethod = "2";
                        }
                        else if (players == 2)
                        {
                            Console.WriteLine("Would you like choose your own words or generate a random words today? \n1) Compete against each others words \n2) Test your luck with the computer's word bank");
                            validNum = true;
                            while (menuSelection == false)
                            {
                               wordSelectionMethod = Console.ReadLine().Trim().ToUpper();
                                    if (wordSelectionMethod == "1")
                                    {
                                    menuSelection = true;
                                    Console.WriteLine("Player One please type the word you'd like ");
                                    }
                                    else if (wordSelectionMethod == "2")
                                    {
                                    Console.WriteLine("Your numbers will be generated shortly...");
                                    Thread.Sleep(1000);
                                    menuSelection = true;
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                        else
                        {
                            Console.WriteLine("Please pertain to the 1 or 2 team limit. \nHow many teams would you like to register?");
                        }

                    }
                    
                    else
                    {
                        Console.WriteLine("Whatever you entered is just wrong.\nPlease enter wether you want 1 or 2 teams by typing '1' or '2' then hitting enter");
                    }
                }
            }
        }
        static void OnePlayer()
        {
        }
        static void TwoPlayers()
        {
        }
        static void StageStart()
        {
            Console.Clear();
            Console.WriteLine("  +---+\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n=========");
        }
        static void StageOne()
        {
            Console.Clear();
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n      |\r\n      |\r\n      |\r\n=========");
        }
        static void StageTwo()
        {
            Console.Clear();
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n      |\r\n      |\r\n=========");
        }
        static void StageThree()
        {
            Console.Clear();
            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n / \\  |\r\n      |\r\n=========");
        }
    }
}