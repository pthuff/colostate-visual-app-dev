/*
 * Project:         Assignment Set 6 - Program 15
 * Date:            October 2018
 * Modified:        Nov 14, 2018 by Paul Huff
 * Developed By:    LV
 * Class Name:      ScoreCard
 * Assumption:      The scorecard is for a specific tournament and year
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS605AS6
{
    class ScoreCard
    {
        #region "Constants"

        const string PGATour = "2018 U.S. Open Championship", CourseName = "Shinnecock Hills";

        int[] CoursePars = { 4, 3, 4, 4, 5, 4, 3, 4, 4, 4, 3, 4, 4, 4, 4, 5, 3, 4 };

        #endregion

        #region "Properties"

        public string PlayerName { get; private set; }
        public int[,] ScoresByRound { get; private set; }

        #endregion

        #region "Constructor"

        public ScoreCard(string name, int[,] scores)
        {
            PlayerName = name;

            ScoresByRound = scores;
        }

        #endregion

        #region "Methods"

        /* Complete this method to calculate and return the player's status after each hole for a given round.

           Status after hole 1 =  Score for hole 1 - Par for hole 1

           Status after holes 2 through 18 = 
            
           Status after previous hole + (Score for current hole - Par for current hole)
        */
        
        public int[] CalcStatusAfterHole(int round)
        {
            //Declare local variables
            int numHoles = ScoresByRound.GetLength(1);
            int correctRound = (round - 1);

            //Declare a one dimsensional array to store the values
            int[] scoreByHole = new int[numHoles];

            //Assign the initial value
            scoreByHole[0] = (ScoresByRound[correctRound, 0] - CoursePars[0]);

            //Loop through the rest of the holes
            for (int x = 1; x < numHoles; ++x)
            {
                scoreByHole[x] = (scoreByHole[x - 1] + (ScoresByRound[correctRound, x] - CoursePars[x]));
            }

            //Return the value
            return scoreByHole;
        }


        /* Complete this method to calculate and return the player's average score for holes of a specific par (i.e., 3, 4 or 5).

          Player's average score for holes of a specific par = 
            
          Player's total score for holes of a specific par for all 4 rounds / (Total number of holes of a specific par * number of rounds (i.e., 4))

          Note: Do not use a manual count of the number of holes of a specific par.

          Instead, write code to find the number of holes of a specific par.
        */

        public double CalcAverageScoresByPar(int par)
        {
            //Declare local variables
            int numHoles = ScoresByRound.GetLength(1);
            int numRounds = ScoresByRound.GetLength(0);
            int numPar = CoursePars.GetLength(0);
            int parCount = 0;
            double totalScore = 0;

            //Loop to find number of holes of a specific par
            for (int x = 0; x < numPar; ++x)
            {
                if (CoursePars[x] == par)
                {
                    ++parCount;
                }
            }

            //Loop to find total score for specific par
            for (int row = 0; row < numRounds; ++row)
            {
                for (int col = 0; col < numHoles; ++col)
                {
                    if (CoursePars[col] == par)
                    {
                        totalScore += ScoresByRound[row, col];
                    }
                }
            }
            //Calculate average score
            totalScore = (totalScore / (parCount * numRounds));

            //Return the value
            return totalScore;
        }

        /* Complete this method to calculate and return the player's overall performance by score type (i.e., Number of Eagles, Birdies, Pars, Bogeys and Double Bogeys)

           Number of Eagles = Count of number of times player's score is two strokes below par

           Number of Birdies = Count of number of times player's score is one stroke below par

           Number of Pars = Count of number of times player's score is equal to par

           Number of Bogeys = Count of number of times player's score is one stroke above par

           Number of Double Bogeys = Count of number of times player's score is two strokes above par
        */

        public string CalcPerformanceByScoreType()
        {
            //Declare local variables
            int eagles = 0;
            int birdies = 0;
            int pars = 0;
            int bogeys = 0;
            int dBogeys = 0;
            int numHoles = ScoresByRound.GetLength(1);
            int numRounds = ScoresByRound.GetLength(0);
            string strMessage;

            //Loop to find number of eagles, birdies, pars, bogeys, and double bogeys
            for (int row = 0; row < numRounds; ++row)
            {
                for (int col = 0; col < numHoles; ++col)
                {
                    if (ScoresByRound[row, col] == (CoursePars[col] - 2))
                    {
                        ++eagles;
                    }
                    else if (ScoresByRound[row, col] == (CoursePars[col] - 1))
                    {
                        ++birdies;
                    }
                    else if (ScoresByRound[row, col] == CoursePars[col])
                    {
                        ++pars;
                    }
                    else if (ScoresByRound[row, col] == (CoursePars[col] + 1))
                    {
                        ++bogeys;
                    }
                    else if (ScoresByRound[row, col] == (CoursePars[col] + 2))
                    {
                        ++dBogeys;
                    }
                }
            }
            //Setup string message
            strMessage = $"Eagles: {eagles} \r\nBirdies: {birdies} \r\nPars: {pars} \r\nBogeys: {bogeys} \r\nDouble Bogeys: {dBogeys}";

            //Return the string
            return strMessage;
        }

        #endregion
    }
}