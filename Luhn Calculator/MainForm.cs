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
        private Luhn luhn;

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
            if (luhn != null) // Call Reset() only if luhn is initialized
                luhn = null;

            outputLabel.Text = "";
            inputRichTextBox.Clear();
            checkDigitLabel.Text = "";
        }

        // Validates the input to make sure it contain numbers only
        private void inputRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (luhn == null) // luhn is used uninitialized
                return;

            try
            {
                luhn = new Luhn(luhn.Number.ToString() + luhn.NextCheckDigit().ToString());

                inputRichTextBox.Text = luhn.Number.ToString();
            }
            catch (LuhnException ex)
            { MessageBox.Show(ex.Message); }


        }

        private void clipboardButton_Click(object sender, EventArgs e)
        {
            if (inputRichTextBox.Text != "")
                Clipboard.SetText(inputRichTextBox.Text);
        }

        private void inputRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (inputRichTextBox.Text == "")
                return;

            bool valid = true;

            try
            {
                luhn = new Luhn(inputRichTextBox.Text);
                valid = luhn.IsValid();
            }
            catch (LuhnException ex)
            {
                MessageBox.Show(ex.Message);
                resetButton_Click(this, e);
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
    }
}
