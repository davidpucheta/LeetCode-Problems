using System.Collections;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class UnivaluedBinaryTree
    {
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }

            var toReturn = false;
            var value = root.val;
            var nodeQueue = new Queue<TreeNode>();
            nodeQueue.Enqueue(root);

            while (nodeQueue.Count > 0)
            {
                var tempNode = nodeQueue.Dequeue();

                if (tempNode.val != value)
                {
                    return false;
                }

                toReturn = true;

                if (tempNode.left != null)
                {
                    nodeQueue.Enqueue(tempNode.left);
                }

                if (tempNode.right != null)
                {
                    nodeQueue.Enqueue(tempNode.right);
                }
            }

            return toReturn;
        }
    }
}