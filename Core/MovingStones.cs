namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MovingStones
    {
        public int[] NumMoveStones(int a, int b, int c)
        {
            int[] stones = new int[] { a, b, c };
            stones = stones.OrderBy(x => x).ToArray();
            var diff = stones.Last() - stones.Min();
            var maxMoves = diff - 2;
            if (maxMoves > 0)
            {
                int minMoves = 1;
                if (stones[1] - stones[0] > 2 && stones[2] - stones[1] > 2)
                {
                    minMoves = 2;
                }

                return new int[] { minMoves, maxMoves };
            }
            else
            {
                return new int[] { 0, 0 };
            }
        }
    }
}