namespace Core
{
    using System;
    using System.Collections.Generic;

    public class ZigZag
    {
        public string Convert(string s, int numRows)
        {
            var tbl = new char?[numRows, s.Length];
            int i = 0;
            int j = 0;
            bool down = true;
            foreach (var c in s.ToCharArray())
            {
                tbl[j,i] = c;
                if (down)
                {
                    j += 1;
                    if (j == numRows)
                    {
                        down = false;
                        j -= 2;
                        i += 1;
                    }
                }
                else
                {
                    j -= 1;
                    if (j == 0)
                    {
                        down = true;
                        i += 1;
                        j = 0;
                    }
                }
            }

            var resultChars = new List<char>();
            for (int y = 0; y < tbl.GetLength(0); y++)
            {
                for (int x = 0; x < tbl.GetLength(1); x++)
                {
                    if (tbl[y, x] != null)
                    {
                        resultChars.Add(tbl[y, x].Value);
                    }
                }
            }

            var result = new string(resultChars.ToArray());

            return result;
        }
    }
}