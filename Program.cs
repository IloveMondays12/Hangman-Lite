namespace Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            string secretWord = "", guessLetter, wordSelectionMethod = "",geussletters, geussingLetter; ;
            int wrongGeusses = 0, players = 0, playerOneScore, playerTwoScore;
            bool menu = false, validNum = false, menuSelection = false;
            List <string> wordBank = new List<string>();
            wordBank.Add("tumid");
            wordBank.Add("filigreee");
            wordBank.Add("rubic");
            wordBank.Add("intemperance");
            wordBank.Add("narcissist");
            wordBank.Add("tautology");
            wordBank.Add("uxorious");
            wordBank.Add("quixotic");
            wordBank.Add("abhorrent");
            wordBank.Add("elixir");
            wordBank.Add("potpourri");
            wordBank.Add("actuarial");
            wordBank.Add("ciliated");
            wordBank.Add("raspy");
            wordBank.Add("acidulous");
            wordBank.Add("sesquipedalian");
            wordBank.Add("dolorous");
            wordBank.Add("dogma");
            wordBank.Add("perpetual");
            wordBank.Add("trepidation");
            wordBank.Add("matrix");
            wordBank.Add("benevolent");
            wordBank.Add("benign");
            wordBank.Add("belligerent");
            wordBank.Add("beacon");
            wordBank.Add("impetuous");
            wordBank.Add("ineluctable");
            wordBank.Add("assemblage");
            wordBank.Add("xenophobia");
            wordBank.Add("vexation");
            wordBank.Add("peruse");
            wordBank.Add("pernicious");
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
                                    Console.WriteLine("Player One please type the word you'd like player two to geuss:");
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
                if (players == 1)
                {
                    secretWord = wordBank[generator.Next(0, 33)].ToUpper();
                    Console.WriteLine("Secret word:");
                    for (int i = 0; i < secretWord.Length; i++)
                    {
                        Console.WriteLine(" * ");
                        Thread.Sleep(100);
                    }
                }

                if (players == 2)
                {
                    if (wordSelectionMethod == "2")
                    {
                        
                        secretWord = wordBank[generator.Next(0, 33)];
                        Console.WriteLine("Secret word for player two:");
                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            Console.WriteLine(" * ");
                            Thread.Sleep(100);
                        }
                    }
                    if (wordSelectionMethod == "1") 
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.White;
                        secretWord = Console.ReadLine().Trim().ToUpper();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        if (secretWord == "")
                        {
                            Console.WriteLine("Looks like you may have forgotten to enter a word, you will be returned to the main menu. \nPress enter to continue");
                            Console.ReadLine();
                        }
                    }
                    if (secretWord != "")
                    {
                        while (wrongGeusses == 0)
                        {
                            Console.Clear();
                            geussingLetter = "";
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("  +---+\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n=========");
                            Console.WriteLine();
                            Console.WriteLine("Secret Word:");
                            for (int i = 0;i < secretWord.Length;i++)
                            {
                                if (secretWord[i] == geussingLetter[0])
                                {
                                    geussletters = geussingletters + geu
                                }
                            }

                        }
                        while (wrongGeusses == 1)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n      |\r\n      |\r\n      |\r\n=========");

                        }
                        while (wrongGeusses == 2)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n  |   |\r\n      |\r\n      |\r\n=========\r\n");

                        }
                        while (wrongGeusses == 3)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n      |\r\n      |\r\n=========");

                        }
                        while (wrongGeusses == 4)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n /    |\r\n      |\r\n=========");

                        }
                        while (wrongGeusses == 5)
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n / \\  |\r\n      |\r\n=========\r\n");

                        }
                    }
                }
            }
        }
      
    }
        
}

