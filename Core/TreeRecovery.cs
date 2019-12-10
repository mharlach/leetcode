namespace Core
{
    using System;
    using System.Collections.Generic;

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class TreeRecovery
    {
        public TreeNode RecoverFromPreorder(string s)
        {
            var charArray = s.ToCharArray();
            var currentChars = new List<char>();
            var depth = 0;
            bool mode = true;
            TreeNode topNode = null;
            for (int i = 0; i < charArray.Length; i++)
            {
                var c = charArray[i];
                if (char.IsNumber(c))
                {
                    currentChars.Add(c);
                }
                else
                {
                    if (currentChars.Count > 0)
                    {
                        // close out number
                        var val = Convert.ToInt32(new string(currentChars.ToArray()));
                        currentChars.Clear();
                        var node = new TreeNode(val);
                        if (topNode == null)
                        {
                            topNode = node;
                        }
                        else
                        {
                            PlaceNode(topNode, node, depth);
                        }
                        depth = 1;
                    }
                    else
                    {
                        depth += 1;
                    }
                }
            }

            return topNode;
        }

        public bool PlaceNode(TreeNode node, TreeNode newNode, int depth)
        {
            if (depth == 1)
            {
                if (node.left == null)
                {
                    node.left = newNode;
                    return true;
                }
                else if (node.right == null)
                {
                    node.right = newNode;
                    return true;
                }
                return false;
            }
            else
            {
                if(PlaceNode(node.left,newNode,depth-1))
                {
                    return true;
                }
                else
                {
                    return PlaceNode(node.right,newNode,depth-1);
                }
            }


        }

    }
}