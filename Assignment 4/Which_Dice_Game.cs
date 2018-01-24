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
    public partial class Which_Dice_Game : Form {
        public Which_Dice_Game() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Would you like to quit", "Quit ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                this.Close();
            } else if (dialogResult == DialogResult.No) {
               
            }
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

            
            if(selectedItem.ToString() == "Snake Eyes") {
                Form GameForm4 = new Snake_Eyes();
                GameForm4.Show();
            
            }
            else if(selectedItem.ToString() == "Ship Captain and Crew") {
                Form GameForm5 = new Ship_Captain_Crew();
                GameForm5.Show();

            }

        }
    }
}
