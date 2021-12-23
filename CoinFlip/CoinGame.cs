using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlippingGame
{
    public class CoinGame
    {
        Player[] players = new Player[2];
        Coin theCoin = new Coin();
        public CoinGame(string player1, string player2)
        {
            players[0] = new Player(player1);
            players[1] = new Player(player2);
        }
        public void StartGame()
        {
            //choose random player
            int randIndex = RandomValue.getRandValue();
            string playersPick= players[randIndex].getRandCoinOption();
            int opponentIndex = randIndex == 0 ? 1 : 0;
            players[opponentIndex].setCoinOption(playersPick);
            //flip a coint
            string winningFlip = theCoin.getCoinOption();
            players[0].didPlayerWin(winningFlip);
            players[1].didPlayerWin(winningFlip);
        }
    }
}
