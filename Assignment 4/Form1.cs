using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                Form GameForm1 = new Two_Up();
                GameForm1.Show();
            }
            if (radioButton2.Checked) {
                Form GameForm2 = new Which_Dice_Game();
                GameForm2.Show();
            }
            if(radioButton3.Checked) {
                Form GameForm3 = new Which_Card_Game();
                GameForm3.Show();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

           /* if ((radioButton2.Checked)) {
                button1.Visible = true;
            } else {
                button1.Visible = false;
            }
            */
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            
           if(radioButton1.Checked) {
                button1.Visible = true;
            }
           else {
                button1.Visible = false;

            }
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            if (radioButton2.Checked) {
                button1.Visible = true;
            } else {
                button1.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            if (radioButton3.Checked) {
                button1.Visible = true;
            } else {
                button1.Visible = false;
            }
        }
    }
}
