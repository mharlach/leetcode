namespace Core
{
    using System;
    using System.Collections.Generic;

    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            var valuesByChar = new Dictionary<char, int>{
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000}
            };

            int result = 0;

            var charArray = s.ToCharArray();
            int lastValue = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                var c = charArray[i];
                var cVal = valuesByChar[c];

                result += cVal;

                if(lastValue > 0 && cVal > lastValue)
                {
                    result -= 2*lastValue;
                }
                
                lastValue = cVal;

            }

            return result;

        }
    }
}