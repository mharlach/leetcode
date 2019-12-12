namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            string builder = "";
            var romanChars = new string[] { "M","CM", "D","CD","C","XC","L","XL", "X","IX","V","IV","I" };
            var numbers = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };


            int current = 0;
            do
            {
                if (num >= numbers[current])
                {
                    num = num - numbers[current];
                    builder += romanChars[current];
                }
                else
                {
                    current += 1;
                }
            } while (num > 0);

            return builder;

        }
    }
}