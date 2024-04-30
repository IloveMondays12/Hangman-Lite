namespace Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            string secretWord, guessLetter, wordSelectionMethod;
            int wrongGeusses, players = 0, playerOneScore, playerTwoScore;
            bool menu = false, validNum = false, menuSelection = false;
            List <string> wordBank = new List<string>();
            wordBank.Add("TUMID");
            wordBank.Add("FILIGREE");
            wordBank.Add("RUBIC");
            wordBank.Add("INTEMPERANCE");
            wordBank.Add("NARCISSIST");
            wordBank.Add("TAUTOLOGY");
            wordBank.Add("UXORIOUS");
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
                    OnePlayer();
                }
                if (players == 2)
                {
                    TwoPlayers();
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