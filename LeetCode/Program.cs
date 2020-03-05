using LeetCode.Problems;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var treeNode = new TreeNode(3);
            treeNode.left = new TreeNode(9);
            treeNode.right = new TreeNode(20);

           



            var levelOrder = new BinaryTreeLevelOrder();
            levelOrder.LevelOrder(treeNode);
        }
    }
}