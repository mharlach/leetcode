public class LongestPalindromeQuestion
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrWhiteSpace(s) == false)
        {
            var c1 = LongestPalindrome(s, 2);
            if(c1.Length == s.Length)
            {
                return c1;
            }
            var c2 = LongestPalindrome(s, 3);

            return c1.Length > c2.Length ? c1 : c2;
        }
        else
        {
            return s;
        }
    }

    public string LongestPalindrome(string s, int z)
    {
        string best = s.Substring(0, 1);
        if (s.Length >= z)
        {
            int start = 0;
            do
            {
                var check = s.Substring(start, z);
                if (IsPalindrome(check))
                {
                    check = ExpandSearch(s, check, start, z);
                    if (best.Length < check.Length)
                    {
                        best = check;
                    }
                }

                start += 1;
            } while (start + z <= s.Length);
        }

        return best;
    }

    public string ExpandSearch(string s, string best, int start, int length)
    {
        start -= 1;
        length += 2;
        while (start >= 0 && start + length <= s.Length)
        {
            var check = s.Substring(start, length);
            if (IsPalindrome(check))
            {
                if(check.Length> best.Length)
                {
                    best = check;
                }
            }
            else
            {
                break;
            }

            start -= 1;
            length += 2;
        }

        return best;
    }

    public bool IsPalindrome(string s)
    {
        var cList = s.ToCharArray();
        int lowIndex = 0;
        int highIndex = cList.Length - 1;
        do
        {
            if (cList[lowIndex] != cList[highIndex])
            {
                return false;
            }
            lowIndex += 1;
            highIndex -= 1;
        } while (highIndex - lowIndex > -1);

        return true;
    }
}