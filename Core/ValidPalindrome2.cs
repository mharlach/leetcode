namespace Core.ValidPalindrome2
{
    public class Solution
    {
        public bool ValidPalindrome(string s)
        {
            var sLength = s.Length;
            if (sLength < 2)
            {
                return true;
            }

            int half = (sLength + 1) / 2;

            for (int i = 0; i < half; i++)
            {
                if (s[i] != s[sLength - 1 - i])
                {
                    var subS = s.Substring(i, sLength - (2 * i));
                    var subLeft = subS.Substring(0, subS.Length - 1);
                    var subRight = subS.Substring(1);

                    if (subLeft.Length == 1 || subRight.Length == 1)
                    {
                        return true;
                    }

                    var checkList = new[] { subLeft, subRight };
                    foreach (var item in checkList)
                    {
                        bool isValid = true; 
                        half = (item.Length + 1) / 2;
                        for (int n = 0; n < half; n++)
                        {
                            if (item[n] != item[item.Length - 1 - n])
                            {
                                isValid = false;
                                break;
                            }
                        }

                        if (isValid == true)
                            return isValid;
                    }

                    return false;
                }
            }

            return true;
        }
    }
}