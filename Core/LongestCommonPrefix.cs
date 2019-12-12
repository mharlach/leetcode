using System;
using System.Collections.Generic;

namespace Core
{
    public class LongestCommonPrefix
    {
        public string Go(string[] strs)
        {

            if (strs.Length > 1)
            {
                var prefix = new List<char>(strs[0].ToCharArray());
                for (int i = 1; i < strs.Length; i++)
                {
                    var s = strs[i];
                    if (s.Length > prefix.Count)
                    {
                        s = s.Substring(0, prefix.Count);
                    }
                    else if (prefix.Count > s.Length)
                    {
                        prefix.RemoveRange(s.Length, prefix.Count - s.Length);
                    }

                    var sChars = s.ToCharArray();
                    for (int x = 0; x < sChars.Length; x++)
                    {
                        if (prefix[x] != sChars[x])
                        {
                            prefix.RemoveRange(x, prefix.Count - x);
                            break;
                        }
                    }

                    if (prefix.Count == 0)
                    {
                        return "";
                    }
                }

                return new string(prefix.ToArray());
            }
            else if (strs.Length == 1)
            {
                return strs[0];
            }
            else
            {
                return string.Empty;
            }
        }
    }
}