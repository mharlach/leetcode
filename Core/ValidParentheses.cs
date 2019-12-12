using System.Collections.Generic;

namespace Core
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var openChars = new HashSet<char>(new char[] { '(', '[', '{' });
            var charSets = new Dictionary<char, char>
            {
                {'(',')'},
                {'[',']'},
                {'{','}'},
            };

            var currentStack = new Stack<char>();
            if (s.Length % 2 == 0)
            {
                var sArray = s.ToCharArray();
                foreach (var c in sArray)
                {
                    if (openChars.Contains(c))
                    {
                        currentStack.Push(c);
                    }
                    else
                    {
                        if(currentStack.Count == 0)
                        {
                            return false;
                        }
                        
                        var pop = currentStack.Pop();
                        if (c != charSets[pop])
                        {
                            return false;
                        }
                    }
                }

                if (currentStack.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return false;
            }
        }
    }
}