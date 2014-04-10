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
            checkDigitLabel.Text = "";
        }

        // Validates the input to make sure it contain numbers only
        private void inputTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //TODO fix -> Check button mush be clicked first so the number get stored in Luhn object
        private void nextButton_Click(object sender, EventArgs e)
        {
        }

        private void inputTextbox_TextChanged(object sender, EventArgs e)
        {
            bool valid = true;

            long x;

            if (!(Int64.TryParse(inputTextbox.Text, out x)))
                outputLabel.Text = "Enter a smaller number";

            try
            {
                luhn = new Luhn(x);
                valid = luhn.IsValid();
            }
            catch (LuhnException ex)
            {
                testLabel.Text = ex.Message;
            }

            if (valid)
            {
                outputLabel.ForeColor = System.Drawing.Color.Green;
                outputLabel.Text = "Valid";
            }
            else
            {
                outputLabel.ForeColor = System.Drawing.Color.Red;
                outputLabel.Text = "Invalid";
            }

            checkDigitLabel.Text = luhn.NextCheckDigit().ToString();
        }

        private void clipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(inputTextbox.Text);
        }
    }
}
