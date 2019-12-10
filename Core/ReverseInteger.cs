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
                var resultQueue = new Queue<int>();
                do
                {
                    var a = x / 10;
                    var b = a * 10;
                    var diff = x - b;

                    resultQueue.Enqueue(diff);
                    x = a;
                } while (x > 0);

                do
                {
                    var count = resultQueue.Count;
                    var pow = Math.Pow(10, count - 1);
                    var v = pow * resultQueue.Dequeue();
                    if (v > (double)int.MaxValue)
                    {
                        return 0;
                    }
                    
                    result += (int)v;
                } while (resultQueue.Count > 0);

                if (negative)
                {
                    result = -1 * result;
                }
            }
            return result;
        }

        public int Go2(int x)
        {
            int result = 0;
            if (x != 0 && x > int.MinValue && x < int.MaxValue)
            {
                bool negative = x > -1 ? false : true;
                x = Math.Abs(x);
                do
                {
                    var a = x / 10;
                    var b = a * 10;
                    var diff = x - b;
                    var digits = Math.Floor(Math.Log10(x) + 1);
                    var add = Math.Pow(10,digits-1) * diff;
                    if(add > (double)int.MaxValue || add+(double)result >(double)int.MaxValue)
                    {
                        return 0;
                    }

                    result += (int)add;
                    x = x/10;

                }while(x >0);

                if (negative)
                {
                    result = -1 * result;
                }
            }
            return result;
        }

    }
}