using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    class BinaryTreeLevelOrder
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var returnList = new List<IList<int>>();

            if (root == null)
            {
                return returnList;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var levelSize = queue.Count;
                var currentList = new List<int>();

                for (int i = 0; i < levelSize; i++)
                {
                    var currentNode = queue.Dequeue();
                    currentList.Add(currentNode.val);

                    if (currentNode.left != null)
                    {
                        queue.Enqueue(currentNode.left);
                    }
                    if (currentNode.right != null)
                    {
                        queue.Enqueue(currentNode.right);
                    }
                }
                returnList.Add(currentList);
            }

            return returnList;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
