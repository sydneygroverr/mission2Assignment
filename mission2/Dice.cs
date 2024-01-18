using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2
{
    public class Dice
    {
        // declare new array to hold the percent of total rolls for each outcome
        public int[] rollPercents = new int[10];

        // create array to track roll outputs
        public int[] rollOutputs = new int[10];

        public int[] Roll(int numRolls)
        {
            // create an instance of Random
            Random random = new Random();

            int[] results = new int[11];

            for (int i = 0; i < numRolls; i++)
            {

                // includes the first number but goes until the second num/doesnt include it
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                int totalRoll = dice1 + dice2;

                results[totalRoll - 2]++;

            }
            return results;

        }

    }
}
