namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LetterCombinations
    {
        public IList<string> Go(string digits)
        {
            var keyList = new Dictionary<char, char[]>{
                {'2', new char[]{'a','b','c'}},
                {'3', new char[]{'d','e','f'}},
                {'4', new char[]{'g','h','i'}},
                {'5', new char[]{'j','k','l'}},
                {'6', new char[]{'m','n','o'}},
                {'7', new char[]{'p','q','r','s'}},
                {'8', new char[]{'t','u','v'}},
                {'9', new char[]{'w','x','y','z'}},
            };

            var digitArray = digits.ToCharArray();
            var keyChoices = new List<char[]>();
            var totalResults = 1;
            var sizes = new int[digitArray.Length];
            int h = 0;
            foreach (var d in digitArray)
            {
                if (keyList.ContainsKey(d))
                {
                    var digitChars = keyList[d];
                    keyChoices.Add(digitChars);
                    totalResults = totalResults * digitChars.Length;
                    sizes[h] = digitChars.Length;
                    h += 1;
                }
            }
            var results = new List<string>();
            if (keyChoices.Count > 0)
            {

                var indexes = new int[keyChoices.Count];
                for (int i = 0; i < totalResults; i++)
                {
                    var builder = new char[keyChoices.Count];
                    for (int n = keyChoices.Count; n-- > 0;)
                    {
                        var currentIndex = indexes[n];
                        builder[n] = keyChoices[n][currentIndex];
                    }
                    results.Add(new string(builder));
                    UpdateIndexes(indexes, sizes);
                }

            }
            return results;
        }

        public void UpdateIndexes(int[] indexes, int[] sizes)
        {
            var last = indexes.Length - 1;

            indexes[last] += 1;
            bool shift = false;
            if (indexes[last] >= sizes[last])
            {
                indexes[last] = 0;
                shift = true;
            }
            if (indexes.Length > 1 && shift == true)
            {
                int i = last - 1;
                do
                {
                    indexes[i] += 1;
                    if (indexes[i] >= sizes[i])
                    {
                        indexes[i] = 0;
                    }
                    else
                    {
                        shift = false;
                    }
                    i -= 1;
                } while (i > -1 && shift == true);
            }
        }
    }
}