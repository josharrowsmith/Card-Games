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
using Low_Level_Objects_Library;




namespace Assignment_4 {
    public partial class Twenty_One : Form
    {
        int playerscore = 0;
        int hosuescore = 0;

        public Twenty_One() {
            InitializeComponent();
            

        }
        // <summary>
        /// Depending on which hand and table to use, displays cards
        /// </summary>
        /// <param name="hand"></param>
        /// <param name="tableLayoutPanel"></param>
        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel) {
            tableLayoutPanel.Controls.Clear(); 
            foreach (Card card in hand) {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Margin = new Padding(0);
                pictureBox.Image = Images.GetCardImage(card);
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }// End DisplayGuiHand

        /// <summary>
        /// Deals 2 card for plays and Deaker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {

            Two_Up_Game.SetUpGame();
            hit.Enabled = true;
            stand.Enabled = true;
            Twenty_One_Game.SetUpGame();
            busted1.Visible = false;
            busted2.Visible = false;
            Twenty_One_Game.DealOneCardTo(Twenty_One_Game.DEALER);
            Twenty_One_Game.DealOneCardTo(Twenty_One_Game.DEALER);
            Twenty_One_Game.DealOneCardTo(Twenty_One_Game.PLAYER);
            Twenty_One_Game.DealOneCardTo(Twenty_One_Game.PLAYER);
            hit.Enabled = true;
            stand.Enabled = true;

            Hand HandForPlayer = Twenty_One_Game.GetHand(Twenty_One_Game.PLAYER);
            Hand HandForDealer = Twenty_One_Game.GetHand(Twenty_One_Game.DEALER);
            Twenty_One_Game.CalculateHandTotal(Twenty_One_Game.PLAYER);
            ppoints.Text = String.Format("{0}", Twenty_One_Game.GetTotalPoints(Twenty_One_Game.PLAYER));
            hpoints.Text = String.Format("{0}", Twenty_One_Game.CalculateHandTotal(Twenty_One_Game.DEALER));
            DisplayGuiHand(HandForDealer, tableLayoutPanel1);
            DisplayGuiHand(HandForPlayer, tableLayoutPanel2);
            

        }
        
       
        /// <summary>
        /// Checked if dealer or player have busted
        /// </summary>
        private void checkAce() {
            Card card = Twenty_One_Game.DealOneCardTo(Twenty_One_Game.PLAYER);
            //Twenty_One_Game.CalculateHandTotal(Twenty_One_Game.0);
            if (card.GetFaceValue().Equals(FaceValue.Ace)) {
                DialogResult dialogResult = MessageBox.Show("Count Ace as one?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    Twenty_One_Game.GetNumOfUserAcesWithValueOne();
                }
            }
        }
        

        /// <summary>
        /// Deals one card to player and plays for dealer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e) {
            Hand newCardPlayer = Twenty_One_Game.GetHand(Twenty_One_Game.PLAYER);
            checkAce();
            Twenty_One_Game.PlayForDealer();
            DisplayGuiHand(newCardPlayer, tableLayoutPanel2);
            ppoints.Text = String.Format("{0}", Twenty_One_Game.CalculateHandTotal(Twenty_One_Game.PLAYER));

            /// <summary>
            /// Checked if dealer or player have busted and who won
            /// </summary>
            if (Twenty_One_Game.GetTotalPoints(Twenty_One_Game.DEALER) > 16 &&
                (Twenty_One_Game.GetTotalPoints(Twenty_One_Game.DEALER) > (Twenty_One_Game.GetTotalPoints(Twenty_One_Game.PLAYER)) &&
                (Twenty_One_Game.GetTotalPoints(Twenty_One_Game.PLAYER)) < 22)) {
                hosuescore++;
                endScoreH.Text = hosuescore.ToString();
            } else if (Twenty_One_Game.GetTotalPoints(Twenty_One_Game.PLAYER) > 17 &&
                (Twenty_One_Game.GetTotalPoints(Twenty_One_Game.PLAYER) > (Twenty_One_Game.GetTotalPoints(Twenty_One_Game.DEALER)) &&
                (Twenty_One_Game.GetTotalPoints(Twenty_One_Game.PLAYER)) < 22)){
                playerscore++;
                endScoreP.Text = playerscore.ToString();
            }

            if (Twenty_One_Game.GetTotalPoints(Twenty_One_Game.PLAYER) > 21) {
                busted2.Visible = true;
                hit.Enabled = false;
                stand.Enabled = false;
                if(stand.Enabled == false) {
                    hosuescore++;
                    endScoreH.Text = hosuescore.ToString();

                }
            }
            if (Twenty_One_Game.GetTotalPoints(Twenty_One_Game.DEALER) > 21) {
                hpoints.Visible = true;
                hit.Enabled = false;
                stand.Enabled = false;
                if (stand.Enabled == false) {
                    hosuescore++;
                    endScoreH.Text = hosuescore.ToString();

                }
            }


        }


        /// <summary>
        /// Plays again for dealer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e) {

            Hand HandForDealer = Twenty_One_Game.GetHand(Twenty_One_Game.DEALER);
            Twenty_One_Game.PlayForDealer();
            hpoints.Text = String.Format("{0}", Twenty_One_Game.CalculateHandTotal(Twenty_One_Game.DEALER));
            DisplayGuiHand(HandForDealer, tableLayoutPanel1);
            //Buested();

        }
        /// <summary>
        /// Cancel button shows final score
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e) {
            string cancel = "";

            cancel += String.Format(" Scores:\n|  PLayer:  {0}    |   House:   {1}  |", playerscore, hosuescore);
            MessageBox.Show(cancel);

            this.Close();
        }

    }
}



