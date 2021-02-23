using System;
using System.Collections.Generic;
using System.Text;

namespace AbilityScoreTester
{
    class AbilityScoreCalculator
    {
        public int rollResult = 14;
        public double divideBy = 1.75;
        public int addAmount = 2;
        public int minimum = 3;
        public int score;


        public void CalculateAbilityScore()
        {
            //Divide the roll result by the DivideBy field
            double divided = rollResult / divideBy;

            //Add AddAmount to the result of that division
            int added = addAmount + (int)divided;

            //If the result is too small use minimum value, else the score will equal the original added amount
            if (added < minimum)
            {
                score = minimum;
            }
            else
            {
                score = added;
            }
        }



    }
}
