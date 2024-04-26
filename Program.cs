namespace Hangman_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            string secretWord, guessLetter;
            int wrongGeusses, players;
            bool menu = false, validNum = false;
            List <string> wordBank = new List<string>(); 
            while (!menu)
            {
                Console.WriteLine("Welcome to HANGMAN, where you are sent to try and save the stickman before he is drawn. \nHow many teams will be playing in your game today?");
                Console.WriteLine("1 or 2? :");
                while (validNum = false)
                {
                    if (int.TryParse(Console.ReadLine(), out players))
                    {
                        if (players == 1)
                        {
                           Console.WriteLine("Your number will be generated shortly...");
                            Thread.Sleep(1000);
                        }
                        else if (players == 2)
                        {
                            Console.WriteLine("Would you like choose your own words or generate a random words today? \n1) Compete against each others words \n2) Test your luck with the computer's word bank");

                            
                        }
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