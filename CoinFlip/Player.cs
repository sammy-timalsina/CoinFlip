using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlippingGame
{
    public class Player
    {
        //fields
        private string name;
        private string coinOption = "";
        public string[] coinValue = new string[] { "Heads", "Tails" };
        //constructor
        public Player(string name)
        {
            this.name = name;
        }
        //methods
        public string getRandCoinOption()
        {
            coinOption = coinValue[RandomValue.getRandValue()];
            return coinOption;
        }
        public void setCoinOption(string opponentFlip)
        {
            coinOption = opponentFlip == "Heads" ? "Tails" : "Heads";
        }
        public void didPlayerWin(string winningFlip)
        {
            if(coinOption==winningFlip)
            {
                Console.WriteLine(name + " won the game.");
            }
            else
            {
                Console.WriteLine(name + " lost the game.");
            }
        }
    }
}
