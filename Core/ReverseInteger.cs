namespace Core
{
    using System;
    using System.Collections.Generic;

    public class ReverseInteger
    {
        public int Go(int x)
        {
            int result = 0;
            if (x != 0)
            {
                bool negative = x > -1 ? false : true;
                x = Math.Abs(x);
                do
                {
                    var pow = Convert.ToInt32(Math.Floor(Math.Log10(x)));
                    var tmp = Convert.ToInt32((Math.Pow(10, pow))) * (x % 10);
                    result += tmp;
                    x = x / 10;

                } while (x > 0);

                if (negative)
                {
                    result = -1 * result;
                }
            }
            return result;
        }


    }
}