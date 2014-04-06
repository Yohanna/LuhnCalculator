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
    public partial class MainForm : Form
    {
        public MainForm()
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
            inputTextbox.Clear();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = inputTextbox.Text;

            Luhn test;
            
            
        }

        // Validates the input to make sure it contain numbers only
        private void inputTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
