using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luhn_Calculator
{
    class Luhn
    {
        public int checkDigit;
        public int Number;
       

        public Luhn()
        {
            this.Number = -1;
            checkDigit = -1;
        }

        public Luhn(int Number)
        {
            if (Number < 0)
                throw new LuhnException("Number can't be negative!");
            
            this.Number = Number;
            checkDigit = -1;
            isValid(Number);
        }

        public bool isValid(int Number)
        {
            //TODO
            return true;
        }

        // Return the next possible Check Digit
        public int NextCheckDigit()
        {
            if (!isValid(Number))
                throw new LuhnException("Not a valid number. Enter a valid number first to get the next valid number");

            if (Number < 0)
                throw new LuhnException("Number can't be negative!");

            int next=0;

            
            //TODO
            return 0;
        }

        public int NextCheckDigit(int Number)
        {
            if (!isValid(Number))
                throw new LuhnException("Not a valid number. Enter a valid number first to get the next valid number");

            //TODO

            return -1;
        }


        public int DigitSum(int Number)
        {
            int sum = 0;
            
            while(Number > 0)
            {
                sum += Number % 10;
                Number /= 10;
            }

            return sum;
        }


    }

    class LuhnException : Exception
    {
        private string eMessage;

        public LuhnException(string message) : base(message) { }

    }



}
