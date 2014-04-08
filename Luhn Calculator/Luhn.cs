using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luhn_Calculator
{
    class Luhn
    {
        public int checkDigit { get; private set; }
        public long Number { get; set; }

        #region Constructors
        public Luhn()
        {
            Number = -1;
            checkDigit = -1;
        }

        public Luhn(long Number)
        {
            if (Number < 0)
                throw new LuhnException("Luhn Algorithm can't be applied on a negative number!");

            this.Number = Number;
            checkDigit = -1;
        }
        #endregion

        #region IsValid
        /// <summary>
        ///  Returns a bool value indicating whether the value Number is valid based on Luhn Algorithm.
        /// </summary>
        public bool IsValid(long Number)
        {
            int len = (int)Math.Floor(Math.Log10(Number) + 1);

            List<int> numberList = new List<int>();

            while (Number > 0)
            {
                numberList.Add((int)(Number % 10));  // nums are added in reverse order since we need to loop from the right most number      
                Number /= 10;
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
        /// Returns a bool value indicating whether the property value Number which had been initialized with the object is valid or not based on Luhn Algorithm.
        /// </summary>
        public bool IsValid()
        {
            if (Number == -1)
                throw new LuhnException("Initialize the object or set the Number property first before checking for validity");

            long num = Number;
            int len = (int)Math.Floor(Math.Log10(num) + 1);


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
        #endregion

        #region NextCheckDigit
        /// <summary>
        /// Return the next possible Check Digit 
        /// </summary> 
        public int NextCheckDigit()
        {
            if (Number < 0)
                throw new LuhnException("Please initialize the object before getting the Next Check Digit!");

            long num = Number;

            int len = (int)Math.Floor(Math.Log10(num) + 1);

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

        /// <summary>
        /// Return the next possible Check Digit 
        /// </summary>
        public int NextCheckDigit(long Number)
        {
            if (Number < 0)
                throw new LuhnException("Number must be positive");

            int len = (int)Math.Floor(Math.Log10(Number) + 1);

            List<int> numberList = new List<int>();

            while (Number > 0)
            {
                numberList.Add((int)(Number % 10));  // nums are added in reverse order since we need to loop from the right most number      
                Number /= 10;
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
    }


    class LuhnException : Exception
    {
        public LuhnException(string message) : base(message) { }

    }
}
