using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopsEksra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Øvelse 1
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear(); // Clears listbox
            for (int i = 1; i <= 1000; i++) // loop prints every number from 1-1000
            {
                listBoxResult.Items.Add(i); // add i to listbox items
            }
        }

        /// <summary>
        /// Øvelse 2
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear(); // Clears listbox
            for (int i = 2; i <= 1000; i += 2) // loop prints every other number from 2-1000
            {
                listBoxResult.Items.Add(i); // add i to listbox items
            }
        }

        /// <summary>
        /// Øvelse 3
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            // Variables
            string stars = "";

            listBoxResult.Items.Clear(); // Clears listbox
            for (int i = 1; i <= 50; i++) // loop adds an asterix [ * ] to the string and prints the string
            {
                stars += "*";
                listBoxResult.Items.Add(stars); // add stars to listbox items
            }
        }

        /// <summary>
        /// Øvelse 4
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear(); // Clears listbox
            for (int i = 100; i > -1; i--) // loop prints every number from 100-0
            {
                listBoxResult.Items.Add(i); // add i to listbox items
            }
        }

        /// <summary>
        /// Øvelse 5
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear(); // Clears listbox
            for (int i = 30; i <= 40; i++) // loop prints every number from 30-40
            {
                listBoxResult.Items.Add(i); // add i to listbox items
            }
        }

        /// <summary>
        /// Øvelse 6
        /// </summary>
        private void button6_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear(); // Clears listbox
            for (int i = 1; i < 15; i++) // loop prints pi with more and more decimals - max 15 decimals
            {
                listBoxResult.Items.Add(Math.Round(Math.PI, i)); // add pi rounded to listbox items with x 
            }
        }

        /// <summary>
        /// Øvelse 7
        /// </summary>
        private void button7_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear(); // Clears listbox

            // Variables
            string startSpace = "                                                    "; // space sets the first star - also used in loop
            string space = "";
            string stars = startSpace + "*";

            listBoxResult.Items.Add(stars); // adding the very first asterisk

            for (int i = 0; i < startSpace.Length; i++) // runs for the string length of [startSpace]
            {
                startSpace = startSpace.Remove(0, 1); // removes one char from the beginning of the string
                space += "  "; // adds spaces to [space]
                stars = startSpace + "*" + space + "*"; // adds asterisks to [stars], adds the altered [startSpace], adds the altered [space]

                listBoxResult.Items.Add(stars); // adds [stars] to listbox
            }

        }
    }
}
