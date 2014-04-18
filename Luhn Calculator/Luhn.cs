using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Luhn_Calculator
{
    class Luhn
    {
        public int checkDigit { get; private set; }
        public BigInteger Number; 

        #region Constructors
        public Luhn(string newNumber)
        {
            if (BigInteger.TryParse(newNumber, out Number) == false) 
            throw new LuhnException("\"" + newNumber + "\"" + " is not a valid number!");

            if (Number.Sign == -1)
                throw new LuhnException("Enter a positive number!");
            
            //checkDigit = 0;
        }
        #endregion

        #region isValid
        /// <summary>
        /// Returns a bool value indicating whether the property value Number which had been initialized with the object is valid or not based on Luhn Algorithm.
        /// </summary>
        public bool IsValid()
        {
            // Use another variable since its value will be lost in the while loop
            BigInteger num =  Number; 
            int len = num.ToString().Length;

            List<int> numberList = new List<int>();

            while (num > 0)
            {
                numberList.Add((int)(num % 10));  // nums are added in reverse order since we need to loop from the right most number      
                num /= 10;
            }

            for (int i = 0; i < len; i++)
            {
                if (i % 2 == 1) // i.e. every second digit
                {
                    numberList[i] = numberList[i] * 2;

                    if (numberList[i] > 9)
                        numberList[i] = numberList[i] % 10 + numberList[i] / 10;
                }
            }
            return DigitSum(numberList) % 10 == 0 ? true : false;
        }

        /// <summary>
        /// Returns the digit sum of elements in the List provided
        /// </summary>
        private int DigitSum(List<int> List)
        {
            int sum = 0;
            foreach (int i in List)
                sum += i;
            return sum;
        }
        #endregion

        #region NextCheckDigit
        /// <summary>
        /// Return the next possible Check Digit 
        /// </summary> 
        public int NextCheckDigit()
        {
            if (Number.IsZero)
                return 0;

            BigInteger num = Number;

            int len = num.ToString().Length;

            List<int> numberList = new List<int>();

            while (num > 0)
            {
                numberList.Add((int)(num % 10));  // nums are added in reverse order since we need to loop from the right most number      
                num /= 10;
            }

            for (int i = 0; i < len; i++)
            {
                if (i % 2 == 0)
                {
                    numberList[i] = numberList[i] * 2;

                    if (numberList[i] > 9)
                        numberList[i] = numberList[i] % 10 + numberList[i] / 10;
                }
            }

            return (DigitSum(numberList) * 9) % 10;
        }
        #endregion

    }

    class LuhnException : Exception
    {
        public LuhnException(string message) : base(message) { }
    }
}
