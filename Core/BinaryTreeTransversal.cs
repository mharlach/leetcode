using System.Collections.Generic;

namespace Core.BinarySearchTreeTransversal
{

    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class BSTIterator
    {
        private System.Collections.Generic.Queue<int> heap = new System.Collections.Generic.Queue<int>();

        public BSTIterator(TreeNode root)
        {
            TraverseInOrder(root);
        }

        public void TraverseInOrder(TreeNode node)
        {
            if (node != null)
            {
                TraverseInOrder(node.left, i);
                heap.Enqueue( node.val);
                // i++;
                TraverseInOrder(node.right, i);
            }
        }

        /** @return the next smallest number */
        public int Next()
        {
            return heap.Dequeue();
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return heap.Count > 0;
        }
    }
}