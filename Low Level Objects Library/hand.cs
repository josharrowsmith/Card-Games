using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Low_Level_Objects_Library {
    public class Hand : IEnumerable {
        private List<Card> hand;


        /// <summary>
        /// Initialises Empty Hand
        /// </summary
        public Hand() {
            hand = new List<Card>();
            

        }

        /// <summary>
        /// Starts the hand from a list of cards
        /// </summary>
        /// <param name="cards"></param>
        public Hand(List<Card> cards) {
            hand = cards;


        }
        /// <returns>Gets the count of cards</returns>
        public int GetCount() {
            return hand.Count;
        }

        /// <returns>Card index</returns>
        public Card GetCard(int index) {
            return hand[index];
        }

        /// <summary>
        /// Adds a card to the hand
        /// </summary>
        public void Add(Card card) {
            hand.Add(card);
        }

        /// <summary>
        /// Checks if the  Card is in the hand
        /// </summary>
        /// <param name="card"></param>
        /// <returns>the card</returns>

        public bool Contains(Card card) {
            if (hand.Contains(card)) {
                return true;
            } else {
                return false;
            }
        }
        /// <summary>
        /// Removes card from the hand
        /// </summary>
        /// <param name="card"></param>
        /// <returns>True if the card could be removed</returns>

        public bool Remove(Card card) {
            if (hand.Contains(card)) {
                hand.Remove(card);
                return true;
            } else {
                return false;
            }
        }
        /// <summary>
        /// Removes the card at the specified index in the list Hand
        /// </summary>
        /// <param name="index"></param>

        public void RemoveAt(int index) {
            hand.RemoveAt(index);
        }
        /// <summary>
        /// Sorts the cards in the hand
        /// </summary>
        public void Sort() {
            hand.Sort();
        }

        public IEnumerator GetEnumerator() {
            return hand.GetEnumerator();
        }
    
    }
}
