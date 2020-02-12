//12/02/2020
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDNI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int dni =Convert.ToInt32(textBoxDNI.Text);
            char letter = functionLetter(dni);
            textBoxLettet.Text = letter.ToString();
            MessageBox.Show("done");
        }
        private char functionLetter(int dni)
        {
            char letter = 'A';

            return letter;
        }
    }
}
