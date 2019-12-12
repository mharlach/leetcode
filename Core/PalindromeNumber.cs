namespace Core
{
    public class PalindromeNumber
    {
        public bool IsPalidrome(int x)
        {
            if (x > 9)
            {
                var s = x.ToString().ToCharArray();
                int low, high;
                if (s.Length % 2 == 0)
                {
                    high = s.Length / 2;
                    low = high - 1;
                }
                else
                {
                    high = 1 + (s.Length / 2);
                    low = (s.Length / 2) - 1;
                }

                do
                {
                    if (s[low] != s[high])
                    {
                        return false;
                    }
                    low -= 1;
                    high += 1;
                } while (low > -1);

                return true;

            }
            else if (x < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}