using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luhn_Calculator
{
    class Luhn
    {
        private int checkDigit;

        public int Number
        {
            get { return Number; }
            set { this.Number = Number; }
        }

        public Luhn()
        {
            this.Number = -1;
            checkDigit = -1;
        }

        public Luhn(int Number)
        {
            this.Number = Number;
            checkDigit = -1;
            Valid(Number);
        }

        public bool Valid(int Number)
        {
            //TODO
            return true;
        }

        // Return the next possible Check Digit
        public int NextCheckDigit()
        {
            //TODO
            return 0;
        }

        public int NextCheckDigit(int Number)
        {
            if (!Valid(Number))
                throw new LuhnException("Not a valid number!");

            //TODO

            return -1;
        }



    }

    class LuhnException : Exception
    {
        private string eMessage;

        public LuhnException(string message) : base(message) { }

    }



}