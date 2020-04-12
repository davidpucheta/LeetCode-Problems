using System;
using LeetCode.Problems;

namespace LeetCode.ThirtyDaysOfCode
{
    public class BinTreeDiameter
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            
            int ans = 1;
            depth(root, ref ans);
            return ans - 1;
        }
        
        int depth(TreeNode node, ref int refAns)
        {
            if (node == null)
                return 0;
            var L = depth(node.left, ref refAns);
            var R = depth(node.right, ref refAns);
            refAns = Math.Max(refAns, L + R + 1);
            return Math.Max(L, R) + 1;
        }
    }
}


    
