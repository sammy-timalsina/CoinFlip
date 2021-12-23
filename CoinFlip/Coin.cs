using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlippingGame
{
    public class Coin
    {
        private string coinOption = "";
        public string[] coinValue = new string[] { "Heads", "Tails" };
        public Coin()
        {
            coinOption = coinValue[RandomValue.getRandValue()];
        }
        public string getCoinOption()
        {
            return coinOption;
        }
    }
}
