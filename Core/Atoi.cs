namespace Core
{
    using System;
    using System.Collections.Generic;

    public class Atoi
    {
        public int MyAtoi(string str)
        {
            str = str.TrimStart();
            var nextSpace = str.IndexOf(' ');
            string parseString;
            if (nextSpace > 0)
            {
                parseString = str.Substring(0, nextSpace);
            }
            else
            {
                parseString = str;
            }

            int result = 0;
            double fullParse;
            if (double.TryParse(parseString, out fullParse))
            {
                if (fullParse > (double)int.MaxValue)
                {
                    result = int.MaxValue;
                }
                else if (fullParse < (double)int.MinValue)
                {
                    result = int.MinValue;
                }
                else
                {
                    result = (int)fullParse;
                }
            }

            return result;
        }
    }
}