using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            string secretWord, guessLetter, wordSelectionMethod = "",geussletters, geussingLetter;
            int wrongGeusses, players = 0, playerOneScore = -1, playerTwoScore = -1;
            bool menu = false, validNum = false, menuSelection = false, letterContains, fullWordGeussed = false;
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
                Console.Clear();
                wrongGeusses = 0;
                secretWord = "";
                if (players == 2 && playerOneScore == -1)
                {
                
                }
                else
                {
                 wordSelectionMethod = "";
                }
                
                validNum = false;
                if (players == 0 || players == 1)
                {
                    Console.WriteLine("Welcome to HANGMAN, where you are sent to try and save the stickman before he is drawn. \nHow many teams will be playing in your game today?");
                    Console.WriteLine("1 or 2? :");
                    while (validNum == false)
                    {
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
                if (players == 1)
                {
                    secretWord = wordBank[generator.Next(0, wordBank.Count)].ToUpper();
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
                        if (playerTwoScore == -1)
                        {
                            Console.WriteLine("Secret word for player two:");
                        }
                        else if (playerOneScore == -1)
                        {
                            Console.WriteLine("Secret word for player One:");
                        }
                        secretWord = wordBank[generator.Next(0, wordBank.Count)].ToUpper();
                        wordBank.Remove(secretWord);
                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            Console.Write("* ");
                            Thread.Sleep(100);
                        }
                    }
                    if (wordSelectionMethod == "1")
                    {
                        if (playerTwoScore == -1)
                        {
                            Console.WriteLine("Secret word for player two:");
                        }
                        else if (playerOneScore == -1)
                        {
                            Console.WriteLine("Secret word for player One:");
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.White;
                        secretWord = Console.ReadLine().Trim().ToUpper();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        

                        if (secretWord == "" || !Regex.IsMatch(secretWord, @"^[a-zA-Z]+$"))
                        {
                            Console.WriteLine("Looks like you may have forgotten to enter a word, you will be kicked out now loser. \nPress enter to continue");
                            secretWord = "";
                            menu = true;
                            Console.ReadLine();
                        }
                    }
                }
                    if (secretWord != "")
                    {
                        geussletters = "";
                        while (wrongGeusses <= 5)
                        {
                            Console.Clear();
                            geussingLetter = "";
                            Console.WriteLine();
                            Console.WriteLine();
                            DrawHangman(wrongGeusses);
                            Console.WriteLine("Target Word:");
                            fullWordGeussed = true;
                            for (int i = 0; i < secretWord.Length;i++)
                            {
                                if (geussletters.ToUpper().Contains(secretWord[i]))
                                {
                                    Console.Write($"{secretWord[i]} ");
                                }
                                else
                                {
                                    Console.Write("_ ");
                                fullWordGeussed = false;
                                }
                            }
                            Console.WriteLine(" \nGeussed letters:");
                            for (int i = 0;i < geussletters.Length;i++)
                            {
                            Console.Write(geussletters.ToUpper()[i] + ", ");
                            }
                        if (fullWordGeussed == true)
                        {
                            break;
                        }
                        
                            Console.WriteLine("\nWhat letter would you like to geuss next (please press enter when your done):");
                            geussingLetter = null;
                            while (geussingLetter == null)
                            {
                                geussingLetter = Console.ReadLine().Trim();
                            
                                if (geussingLetter.Length != 1 || !Regex.IsMatch(geussingLetter, @"^[a-zA-Z]+$"))
                                {
                                    Console.WriteLine("Your geuss was invalid please try another again (one letter only)...");
                                    Thread.Sleep(1500);
                                    geussingLetter = null;
                                }
                                else
                                {
                                if (!geussletters.Contains(geussingLetter))
                                {
                                    geussletters = geussletters + geussingLetter;
                                    if (!secretWord.Contains(geussingLetter.ToUpper()))
                                    {
                                        wrongGeusses++;
                                    }
                                }
                                    
                                }
                            }
                        }
                    
                      
                    }
                Console.Clear();
                if (fullWordGeussed == true)
                {
                    Console.WriteLine($"Crongratulations! you've geussed the word \nWord: {secretWord}");
                    if (players == 2 && playerTwoScore == -1)
                    {
                        Console.WriteLine($"PLAYER TWO SCORE:{wrongGeusses}");
                        playerTwoScore = wrongGeusses;
                    }
                    else if (players == 2 && playerOneScore == -1)
                    {
                        Console.WriteLine($"PLAYER ONE SCORE: {wrongGeusses}");
                        Console.WriteLine($"PLAYER TWO SCORE:{playerTwoScore}");
                        if (wrongGeusses > playerTwoScore)
                        {
                            Console.WriteLine("\nPlayer one wins!");
                        }
                        else if (wrongGeusses == playerTwoScore)
                        {
                            Console.WriteLine("\nIt's a tie!");
                        }
                        else
                        {
                            Console.WriteLine("Player two wins!");
                        }
                        menu = true;
                    }
                }
                else if (wrongGeusses == 6)
                {
                    Console.WriteLine($"Looks like you've run out of geusses, better luck next time!\nWord: {secretWord}");
                    if (players == 2 && playerTwoScore == -1)
                    {
                        Console.WriteLine($"PLAYER TWO SCORE:{wrongGeusses}");
                        playerTwoScore = wrongGeusses;
                    }
                    else if (players == 2 && playerOneScore == -1)
                    {
                        Console.WriteLine($"PLAYER ONE SCORE: {wrongGeusses}");
                        Console.WriteLine($"PLAYER TWO SCORE:{playerTwoScore}");
                        if (wrongGeusses > playerTwoScore)
                        {
                            Console.WriteLine("\nPlayer one wins!");
                        }
                        else if (wrongGeusses == playerTwoScore)
                        {
                            Console.WriteLine("\nIt's a tie!");
                        }
                        else
                        {
                            Console.WriteLine("Player two wins!");
                        }
                        menu = true;
                    }
                }
                else
                {
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Please press 'enter' to continue");
                Console.ReadLine();
            }
            
        }

        public static void DrawHangman(int wrongGuesses)
        {
            switch (wrongGuesses)
            {
                case 0:
                    Console.WriteLine("  +---+\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n=========");

                    break;
                case 1:
                    Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n      |\r\n      |\r\n      |\r\n=========");
                    
                    break;
                case 2:
                    Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n  |   |\r\n      |\r\n      |\r\n=========\r\n");

                    break;
                case 3:
                    Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n      |\r\n      |\r\n=========");

                    break;
                case 4:
                    Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n /    |\r\n      |\r\n=========");

                    break;
                    case 5:
                    Console.WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n / \\  |\r\n      |\r\n=========\r\n");

                    break;





            }
        }
      
    }
        
}

