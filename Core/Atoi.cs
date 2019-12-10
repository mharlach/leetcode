namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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

            var charList = new char[] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var parseChars = parseString.ToArray();
            var resultChars = new List<char>();
            for (int i = 0; i < parseChars.Length; i++)
            {
                var p = parseChars[i];
                if (charList.Contains(p))
                {
                    resultChars.Add(p);
                }
                else if(i == 0 && p == '-')
                {
                    resultChars.Add(p);
                }
                else if(i == 0 && p == '+')
                {
                    // do nothing
                }
                else
                {
                    break;
                }
            }
            parseString = new string(resultChars.ToArray());

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