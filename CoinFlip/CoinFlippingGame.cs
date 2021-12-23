using System;
using System.Threading;

namespace CoinFlippingGame
{
    class CoinFlippingGame
    {
        static void Main(string[] args)
        {
            string userResponse = string.Empty;
            CoinGame theCoinGame = new CoinGame("Samy", "Bill");
            do
            {
                theCoinGame.StartGame();
                Thread.Sleep(800);
                Console.WriteLine("Do you want to play the game again");
                userResponse = Console.ReadLine();

            } while (userResponse.StartsWith("y")||userResponse.StartsWith("Y"));
            Console.WriteLine("Exited");
        }
    }
}
