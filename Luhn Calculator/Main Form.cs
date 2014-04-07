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
        Luhn luhn;

        public MainForm()
        {
            InitializeComponent();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutBox About = new AboutBox();
            About.ShowDialog(); // or use about.Show() to make it modeless

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            inputTextbox.Clear();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (inputTextbox.Text == "")
                return;     // TODO display an error message

            bool valid = true;

            long x;

            Int64.TryParse(inputTextbox.Text, out x);

            if (x == 0)
                return; // TODO display error message

            try
            {
                luhn = new Luhn(x);
                valid = luhn.isValid();
            }
            catch (LuhnException ex)
            {
                testLabel.Text = ex.Message;
            } 

            if(valid)
            {
                outputLabel.ForeColor = System.Drawing.Color.Green;
                outputLabel.Text = "Valid";
            }
            else
            {
                outputLabel.ForeColor = System.Drawing.Color.Red;
                outputLabel.Text = "Invalid";
            }
        }

        // Validates the input to make sure it contain numbers only
        private void inputTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
