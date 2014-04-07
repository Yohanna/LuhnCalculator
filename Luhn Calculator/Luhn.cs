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



        public Luhn()
        {
            Number = -1;
            checkDigit = -1;
        }

        public Luhn(long Number)
        {
            if (Number < 0)
                throw new LuhnException("Number can't be negative!");

            this.Number = Number;
            checkDigit = -1;
        }


        public bool isValid(long Number)
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

        public bool isValid()
        {
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

        // Return the next possible Check Digit
        public int NextCheckDigit()
        {
            //if (!isValid(Number))
            //    throw new LuhnException("Not a valid number. Enter a valid number first to get the next valid check digit");

            if (Number < 0)
                throw new LuhnException("Please initialize the object before using it!");

            int next = 0;


            //TODO
            return 0;
        }

        public int NextCheckDigit(long Number)
        {
            //if (!isValid(Number))
            //    throw new LuhnException("Not a valid number. Enter a valid number first to get the next valid number");

            //TODO

            return -1;
        }

        public int DigitSum(List<int> List)
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
