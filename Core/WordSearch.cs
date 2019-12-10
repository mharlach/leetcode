namespace Core
{
    using System;
    using System.Collections.Generic;

    public class WordSearch
    {
        public bool Exist(char[][] board, string word)
        {
            var wordArray = word.ToCharArray();
            var startingPoints = new List<string>();

            char searchChar = wordArray[0];
            bool found = false;
            do
            {
                var position = FindNextStartPosition(board, startingPoints, searchChar, 0, 0);
                if (position.x > -1)
                {
                    if (wordArray.Length > 1)
                    {
                        startingPoints.Add($"{position.y},{position.x }");
                        var used = new List<string>();
                        used.Add($"{position.y},{position.x }");
                        found = Search(board, wordArray, used, position.x, position.y, 1);
                    }
                    else
                    {
                        found = true;
                    }
                }
                else
                {
                    break;
                }
            } while (found == false);

            return found; 
        }

        public (int x, int y) FindNextStartPosition(char[][] board, List<string> used, char searchChar, int startX, int startY)
        {
            int x, y;
            for (y = startY; y < board.Length; y++)
            {
                for (x = startX; x < board[y].Length; x++)
                {
                    var boardLetter = board[y][x];
                    if (boardLetter == searchChar && used.Contains($"{y},{x}") == false)
                    {
                        return (x, y);
                    }
                }
            }

            return (-1, -1);
        }



        public bool Search(char[][] board, char[] wordArray, List<string> used, int x, int y, int searchIndex)
        {
            var usedCopy = used.ConvertAll(b=>b);

            bool found = false;
            int tmpX = x;
            int tmpY = y - 1;
            if (tmpY > -1 && usedCopy.Contains($"{tmpY},{tmpX}") == false)
            {
                // search above
                found = SubSearch(board, wordArray, searchIndex, usedCopy, tmpX, tmpY);
            }

            tmpX = x + 1;
            tmpY = y;
            if (found == false && tmpX < board[tmpY].Length && usedCopy.Contains($"{tmpY},{tmpX}") == false)
            {
                // search right
                found = SubSearch(board, wordArray, searchIndex, usedCopy, tmpX, tmpY);
            }

            tmpX = x;
            tmpY = y + 1;
            if (found == false && tmpY < board.Length && usedCopy.Contains($"{tmpY},{tmpX}") == false)
            {
                // search below
                found = SubSearch(board, wordArray, searchIndex, usedCopy, tmpX, tmpY);
            }

            tmpX = x - 1;
            tmpY = y;
            if (found == false && tmpX > -1 && usedCopy.Contains($"{tmpY},{tmpX}") == false)
            {
                // search left
                found = SubSearch(board, wordArray, searchIndex, usedCopy, tmpX, tmpY);
            }

            return found;

        }

        private bool SubSearch(char[][] board, char[] wordArray, int searchIndex, List<string> used, int tmpX, int tmpY)
        {
            var usedCopy = used.ConvertAll(b=>b);
            var searchChar = board[tmpY][tmpX];
            if (searchChar == wordArray[searchIndex])
            {
                usedCopy.Add($"{tmpY},{tmpX}");
                if (searchIndex == wordArray.Length - 1)
                {
                    return true;
                }
                else
                {
                    return Search(board, wordArray, usedCopy, tmpX, tmpY, searchIndex + 1);
                }

            }

            return false;
        }
    }
}