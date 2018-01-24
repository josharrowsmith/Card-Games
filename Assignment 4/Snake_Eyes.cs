using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Games_Logic_Library;

namespace Assignment_4 {
    public partial class Snake_Eyes : Form {
        //int tempDiceState = 0; // The Temporary state of each coin during the 'flip' animation
        int timerClickCounter; // Keeps track of the number of flip animations
        bool secondRoll = false;
        bool anotherRoll = false;
        string won = " You won!"; string lose = "Sorry you lost!"; string draw = "It was a draw!";
        string rollAgain = "Roll Dice Again"; string requiredPoints = "you need to roll {0} points";
        string pointsWon = "You get {0} points"; string pointsLost = "House gets {0} points";
        string nothing = "Nothing happened!";

        public Snake_Eyes() {

            InitializeComponent();
            Snake_Eyes_Game.SetUpGame();
            UpdateImages();


        }

        /// <summary>
        /// Updates pictureboxs
        /// </summary>
        private void UpdateImages() {
            UpdatePictureBoxImage(pictureBox1, Snake_Eyes_Game.GetDiceFaceValue(0));
            UpdatePictureBoxImage(pictureBox2, Snake_Eyes_Game.GetDiceFaceValue(1));
        }
        /// <summary>
        /// Updates the images in the picture box based on the its parameters
        /// </summary>
        private void UpdatePictureBoxImage(PictureBox whichPB, int face) {
            whichPB.Image = Images.GetDieImage(face);

        }

        /// <summary>
        /// roll dice get roll out come and checks to see if need to roll again gets points 
        /// </summary>
        private void roldice(object sender, EventArgs e) {
         
            if (!secondRoll) {
                secondRoll = Snake_Eyes_Game.FirstRoll();
                if (!secondRoll) {
                    result.Text = (Snake_Eyes_Game.GetPlayersPoints() > 0) ? won : (Snake_Eyes_Game.GetHousePoints() > 0) ? lose : draw;
                    if (Snake_Eyes_Game.GetRollTotal() == 2) {
                        dummyLabel.Text = string.Format(pointsWon, 2);
                    } else if (Snake_Eyes_Game.GetRollTotal() == 7 || Snake_Eyes_Game.GetRollTotal() == 11) {
                        dummyLabel.Text = string.Format(pointsWon, 1);
                    } else if (Snake_Eyes_Game.GetRollTotal() == 3 || Snake_Eyes_Game.GetRollTotal() == 12) {
                        dummyLabel.Text= string.Format(pointsLost, 2);
                    }
                } else {
                    result.Text = rollAgain;
                    dummyLabel.Text = string.Format(requiredPoints, Snake_Eyes_Game.GetPossiblePoints());
                }
            } else {
                anotherRoll = Snake_Eyes_Game.AnotherRoll();
                secondRoll = false;
                result.Text = (Snake_Eyes_Game.GetPlayersPoints() > 0) ? won : (Snake_Eyes_Game.GetHousePoints() > 0) ? lose : draw;
                if (!anotherRoll) {
                    dummyLabel.Text = string.Format(pointsWon, Snake_Eyes_Game.GetPossiblePoints());
                } else if (Snake_Eyes_Game.GetRollTotal() == 7) {
                    dummyLabel.Text = string.Format(pointsLost, 2);
                } else {
                    dummyLabel.Text = nothing;
                }

            }
            dummyLabel.Visible = true;
            playerScore.Text = Snake_Eyes_Game.GetPlayersPoints().ToString();
            houseScore.Text = Snake_Eyes_Game.GetHousePoints().ToString();
            playAgain.Enabled = true;
            rollDice.Enabled = false;
            Cancel.Enabled = true;

            UpdateImages();
        }






        /// <summary>
        /// Enable and disable buttons
        /// </summary>
        private void playagain(object sender, EventArgs e) {
            
            rollDice.Enabled = true;
            playAgain.Enabled = false;
            result.Text = "First Roll";
            
        }
        /// <summary>
        /// Quit the game and giving final results
        /// </summary>
        private void cancel(object sender, EventArgs e) {
            string cancel = "";

            if (Snake_Eyes_Game.GetHousePoints() > Snake_Eyes_Game.GetPlayersPoints()) {
                cancel = "You Lose";
            } else
                cancel = "You won";

            cancel += String.Format(" Scores:\n|  PLayer:  {0}    |   House:   {1}  |", Snake_Eyes_Game.GetPlayersPoints(), Snake_Eyes_Game.GetHousePoints());
            MessageBox.Show(cancel);

            this.Close();
        }

        /// <summary>
        /// Trying to get animations working no idea
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e) {
            
            ///tempDiceState = 1;
            if (timerClickCounter == 10) {
                Snake_Eyes_Game.AnotherRoll();
                
                timer1.Stop();
            } else {
                timerClickCounter++;
            }


        }
    }
}
