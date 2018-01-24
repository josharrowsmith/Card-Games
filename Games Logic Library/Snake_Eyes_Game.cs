using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library
{
    public static class Snake_Eyes_Game
    {

        private static int rollTotal;
        private static int playerTotal;
        private static int houseTotal;
        private static int possiblePoints;
        public static int rollCount;

        private static Die[] dice = new Die[2];

        /// <summary>
        /// Makes class variables at the beginning of a new game
        /// </summary>
        public static void SetUpGame() {
            for (int i = 0; i < dice.Length; i++) {
                dice[i] = new Die();
            }

            rollTotal = playerTotal = houseTotal = possiblePoints = rollCount = 0;
        }/// End of Setup


        /// <summary>
        /// plays the first roll adds points if numbers match 
        /// </summary>
        /// <returns>A boolean to roll again or a counter</returns>
        public static bool FirstRoll() {

            for (int i = 0; i <= 1; i++) {
                dice[i].RollDie();
            }
            rollCount++;


            int rollTotal = GetRollTotal();



            if (rollTotal == 2) {
                playerTotal += 2;
                return false;
            } else if (rollTotal == 7 || rollTotal == 11) {
                playerTotal++;
                return false;
            } else if (rollTotal == 3 || rollTotal == 12) {
                houseTotal += 2;
                return false;
            } else {
                possiblePoints = rollTotal;
                return true;

            }




        }
        /// <summary>
        /// Rolls Again Add possiable check for matching numbers
        /// </summary>
        /// <returns>A boolean for another roll</returns>
        public static bool AnotherRoll() {

            for (int i = 0; i <= 1; i++) {
                dice[i].RollDie();
            }
            rollCount++;
            possiblePoints = GetPossiblePoints();

            rollTotal = GetRollTotal();

            if (rollTotal == possiblePoints) {
                playerTotal += possiblePoints;
                return false;
            } else if (rollCount > 7 || rollTotal == 7) {
                houseTotal += 2;
                return false;
            } else {
                return true;
            }








        }

        /// <returns>Gets the face value of a dice</returns>
        public static int GetDiceFaceValue(int whichDie) {

            return dice[whichDie].GetFaceValue();

        } //End GetDiceFaceValue()

        /// <returns>Player Points</returns>
        public static int GetPlayersPoints() {

            return playerTotal;

        } //End GetPlayersPoints()

        /// <returns>House Points</returns>
        public static int GetHousePoints() {





            return houseTotal;

        } //End GetHousePoints()

        /// <returns>Get Possibale Points </returns>
        public static int GetPossiblePoints() {
            return possiblePoints;
        } // End of GetPossiblePoints Method


        /// <returns>Get Roll total by adding them together </returns>
        public static int GetRollTotal() {
            int sum = 0;
            for (int i = 0; i < dice.Length; i++) {
                sum += GetDiceFaceValue(i);
            }
            return sum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>resultstring</returns>
        private static int[] previousTotal = { 0, 0 };
        public static string GetRollOutcome() {
            if (playerTotal > previousTotal[0]) {

                String resultString = String.Format("Player gets {0} points!", playerTotal - previousTotal[0]);
                previousTotal[0] = playerTotal;
                return resultString;

            } else if (houseTotal > previousTotal[1]) {
                String resultString = String.Format("House gets {0} points!", houseTotal - previousTotal[1]);
                previousTotal[1] = houseTotal;
                return resultString;
            } else {
                return String.Format("You need to roll {0} points.", possiblePoints);
            }


        } // End of GetRollOutcome Method



    }
}
