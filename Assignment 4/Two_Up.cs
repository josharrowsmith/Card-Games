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




namespace Assignment_4
{
    public partial class Two_Up : Form
    {
        bool temp = false; // The Temporary state of each coin during the 'flip' animation
        int timerClickCounter; // Keeps track of the number of flip animations

        /// <summary>
        /// Initialises class variables and initilises the default coin images
        /// </summary>
        public Two_Up() {
            InitializeComponent();
            Two_Up_Game.SetUpGame();
            UpdateImages();

        }


        /// <summary>
        /// Updates the images in the picture box based on the its parameters
        /// specifying which box to affect and if the coin is heads or not.
        /// </summary>
        private void UpdatePictureBoxImage(PictureBox whichPB, bool isHeads) {
            whichPB.Image = Images.GetCoinImage(isHeads);
        }// end UpdatePictureBoxImage

        /// <summary>
        /// Updates the pictureboxs
        /// </summary>
        private void UpdateImages() {
            UpdatePictureBoxImage(pictureBox1, Two_Up_Game.IsHeads(1));
            UpdatePictureBoxImage(pictureBox2, Two_Up_Game.IsHeads(2));
        }


        /// <summary>
        /// Updates Scores
        /// </summary>
        private void UpdateScores() {
            playerScore.Text = Two_Up_Game.GetPlayersScore().ToString();
            computerScore.Text = Two_Up_Game.GetComputersScore().ToString();
        }

        /// <summary>
        /// Reset form hides label
        /// </summary>
        private void ResetForm() {
            Two_Up_Game.SetUpGame();
            UpdateScores();
            label1.Visible = false;
        }

        /// <summary>
        /// Enables throw coin button, Updates score and pictureboxs, starts timer
        /// </summary>
        private void button1_Click_1(object sender, EventArgs e) {
            throwButton.Enabled = false;
            playAgain.Visible = true;
            playAgain.Enabled = true;
            UpdateScores();
            UpdateImages();
            timer1.Start();
            timerClickCounter = 0;
            
        }

        /// <summary>
        /// Close button
        /// </summary>
        private void button3_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// Enable buttons 2 and disable 
        /// </summary>
        private void button2_Click(object sender, EventArgs e) {
            playAgain.Enabled = true;
            playAgain.Enabled = false;
            playAgain.Visible = false;
            throwButton.Enabled = true;
        }



        private void label3_Click(object sender, EventArgs e) {

        }
        

        /// <summary>
        /// creates the delay for the coin flip animation 
        /// calls toss coin funcation
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e) {
            UpdatePictureBoxImage(pictureBox1, temp);
            UpdatePictureBoxImage(pictureBox2, !temp);
            temp = !temp;
            if (timerClickCounter == 10) {
                Two_Up_Game.TossCoins();
                label1.Text = Two_Up_Game.TossOutcome();
                UpdateScores();
                UpdateImages();
                timer1.Stop();
            } else {
                timerClickCounter++;
                label1.Visible = true;
            }
        }
        // End of Timer





    }
}
