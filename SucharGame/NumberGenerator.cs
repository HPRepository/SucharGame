using System;
using System.Collections.Generic;
using System.Text;

namespace SucharGame
{
    public class NumberGenerator
    {
        private static NumberGenerator myInstance;
        private static Random myRandom;

        private NumberGenerator()
        {
            myRandom = new Random();
        }
        public static NumberGenerator GetInstance()
        {
            if (myInstance == null) myInstance = new NumberGenerator();

            return myInstance;

        }

        public int GenerateValue(int min, int max)
        {
            if (min >= max) return max;

            return myRandom.Next(min, max + 1);

        }

    }
}
