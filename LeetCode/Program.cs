using LeetCode.Problems;
using System;

namespace LeetCode
{
    class  Program
    {
        static void Main(string[] args)
        {
            var strFromBinTree = new StringFromBinTree();
            
            var root = new TreeNode(1);
            var rL = new TreeNode(2);
            var rR = new TreeNode(3);

            root.left = rL;
            root.right = rR;

            rL.left = null;
            rL.right = new TreeNode(4);

            var x = strFromBinTree.Tree2Str(root);
 
            Console.WriteLine($"Name validity: {x}");
        }
    }
}