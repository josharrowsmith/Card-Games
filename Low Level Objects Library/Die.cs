using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Low_Level_Objects_Library {
    public class Die {
        private static Random randomNumber = new Random();

        private const int SIX_SIDED = 6;
        private const int DEFAULT_FACE_VALUE = 1;
        private const int MIN_NUMBER = 3;

        private int numFaces; //number of sides on die
        private int faceValue; // which side is showing

        /// <summary>
        /// Initialises class variables
        /// </summary>
        public Die() {
            numFaces = SIX_SIDED;
            faceValue = DEFAULT_FACE_VALUE;
        }

        /// <summary>
        /// Overloaded Method for Die, allows determination of the number of faces that the die will have
        /// </summary>
        /// <param name="faces">Int determining the number of faces on the die</param>
        public Die(int faces) {
            if (faces >= MIN_NUMBER) {
                numFaces = faces;
            } else {
                numFaces = SIX_SIDED;
            }
            RollDie();
        }

        /// <summary>
        /// Generates a random number based on the number of faces on the die
        /// </summary>
        public void RollDie() {
            faceValue = randomNumber.Next(1, numFaces + 1);
        } // end RollDie

        /// <returns>The value on the face of the die</returns>
        public int GetFaceValue() {
            return faceValue;
        } //end GetFaceValue


    }//end class Die
}
