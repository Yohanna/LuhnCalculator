using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luhn_Calculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            inputMaskedTextBox.Clear();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = inputMaskedTextBox.Text;
        }
    }
}
