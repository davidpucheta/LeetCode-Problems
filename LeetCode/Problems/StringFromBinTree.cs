using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    public class StringFromBinTree
    {
        public string Tree2Str(TreeNode t)
        {
            if (t == null)
            {
                return "";
            }
            
            var nodes  = new  Stack<TreeNode>();
            nodes.Push(t);
            
            var visitedNodes = new  HashSet<TreeNode>();
            var stringToReturn = "";

            while (nodes.Count > 0)
            {
                t = nodes.Peek();

                if (visitedNodes.Contains(t))
                {
                    nodes.Pop();
                    stringToReturn += ")";
                }
                else
                {
                    visitedNodes.Add(t);
                    stringToReturn += "(" + t.val;

                    if (t.left == null && t.right != null)
                        stringToReturn += "()";

                    if (t.right != null)
                        nodes.Push(t.right);
                    
                    if (t.left != null)
                        nodes.Push(t.left);
                }
            }
            
            return stringToReturn.Substring(1, stringToReturn.Length - 2);
        }
    }
}