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
            for (int i = 1; i <= 10; i++)
            {
                listBoxResult.Items.Add(i); // add i to listbox items
            }
        }

        /// <summary>
        /// Øvelse 2
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i=+2)
            {
                listBoxResult.Items.Add(i); // add i to listbox items
            }
        }

        /// <summary>
        /// Øvelse 3
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Øvelse 4
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Øvelse 5
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Øvelse 6
        /// </summary>
        private void button6_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Øvelse 7
        /// </summary>
        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
