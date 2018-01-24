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
    public partial class Which_Card_Game : Form {
        public Which_Card_Game() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Would you like to quit", "Quit ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                //do something
            } else if (dialogResult == DialogResult.No) {
                //do something else
            }
            this.Close();
        }

        

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e) {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;


            if (selectedItem.ToString() == "Twenty_one") {
                Form GameForm7 = new Twenty_One();
                GameForm7.Show();

            } else if (selectedItem.ToString() == "Crazy_Eights") {
                Form GameForm8 = new Crazy_Eights();
                GameForm8.Show();

            }
        }
    }
}
