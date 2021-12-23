using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlippingGame
{
    public static class RandomValue
    {
        public static int getRandValue()
        {
            int min = 0;
            int max = 1;
            Random random = new Random();
            double randNum = random.NextDouble() * (max - min) + min;
            int randIndex = randNum < 0.5 ? 0 : 1;
            return randIndex;
        }
    }
}
