using System.Collections.Generic;
using System.Linq;
using System;

namespace Core
{
    public class ThreeSum
    {
        public IList<IList<int>> Go(int[] nums)
        {
            IList<IList<int>> results = new List<IList<int>>();

            var found = false;
            for (int a = 0; a < nums.Length; a++)
            {
                found = false;
                for (int b = a + 1; b < nums.Length; b++)
                {
                    for (int c = b + 1; c < nums.Length; c++)
                    {
                        if (nums[a] + nums[b] + nums[c] == 0)
                        {
                            var x = new int[] { nums[a], nums[b], nums[c] }
                            .OrderBy(d => d)
                            .ToList();

                            if (results.Where(z => z.SequenceEqual(x)).Any() == false)
                            {
                                results.Add(x);
                                // found = true;
                                break;
                            }

                        }
                    }
                }
            }

            return (IList<IList<int>>)results;
        }
    }
}