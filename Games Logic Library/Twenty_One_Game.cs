using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Games_Logic_Library {
    public class Twenty_One_Game {


        private static CardPile cardPile;
        private static Hand[] hands = new Hand[2];
        private static int[] totalPoints = new int[2];
        private static int[] numOfGamesWon = new int[2];
        private static int numOfUserAcesWithValueOne;
        public const int PLAYER = 0;
        public const int DEALER = 1;

        /// <summary>
        /// Sets up the game 
        /// </summary>
        public static void SetUpGame() {
            
            cardPile = new CardPile(true);
            cardPile.Shuffle();
            for (int i = 0; i < hands.Length; i++) {
                hands[i] = new Hand();
                totalPoints[i] = 0;
                numOfGamesWon[i] = 0;
            }
            numOfUserAcesWithValueOne = 0;
        }
        /// <summary>
        /// Deal a card to int who 
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static Card DealOneCardTo(int who) {

            
            Card dealtCard = cardPile.DealOneCard();
            hands[who].Add(dealtCard);
            totalPoints[who] = CalculateHandTotal(who);
            return dealtCard;
            
            // Returns card  
        }



        /// <summary>
        /// Calclate the hand of who, ie player or house
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static int CalculateHandTotal(int who) {
            Hand currenthand = hands[who];
            int total = 0;

            foreach (Card card in currenthand) {
                if (card.GetFaceValue() <= FaceValue.Ten) {
                    total += (int)card.GetFaceValue() + 2;
                } else if (card.GetFaceValue() <= FaceValue.King) {
                    total += 10;
                } else if (card.GetFaceValue() == FaceValue.Ace) {
                    total += 11;
                }
                totalPoints[who] = total;
            }
            if (who == PLAYER) {
                
                totalPoints[0] = totalPoints[0] - (numOfUserAcesWithValueOne * 10);
                
                return totalPoints[who];
            } else {
                return totalPoints[who];
            }
        }


        /// <summary>
        /// Plays for dealer calling calculatehand funcation stop at 17
        /// </summary>
        public static void PlayForDealer() {
            bool enddeal = false;

            if (GetTotalPoints(DEALER) >= 17) {
                enddeal = true;
            }
            while (!enddeal) {
                DealOneCardTo(DEALER);
                CalculateHandTotal(DEALER);
                GetTotalPoints(DEALER);
                if(GetTotalPoints(DEALER)>= 17) {
                    enddeal = true;
                }
            }

        }

        /// <summary>
        /// Returns a hand of who 
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static Hand GetHand(int who) {
            return hands[who];
        }

        /// <summary>
        /// Returns the totalpoints from calulate funcation 
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static int GetTotalPoints(int who) {
            return totalPoints[who];
        }

        /// <summary>
        /// number of game won who 
        /// </summary>
        /// <param name="who"></param>
        /// <returns></returns>
        public static int GetNumOfGamesWon(int who) {
            return numOfGamesWon[who];
        }

        /// <summary>
        /// Returns the number of aces
        /// </summary>
        /// <returns></returns>
        public static int GetNumOfUserAcesWithValueOne() {
            return numOfUserAcesWithValueOne += 1;
        }

    }

}

