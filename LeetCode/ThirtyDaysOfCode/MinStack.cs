using System.Collections.Generic;

namespace LeetCode.ThirtyDaysOfCode
{
    public class MinStack
    {
        public Stack<int> NumStack;
        public Stack<int> Min;
        
        public MinStack() {
            NumStack = new Stack<int>();
            Min = new Stack<int>();
        }
    
        public void Push(int x) 
        {
            NumStack.Push(x);
            
            if (Min.Count == 0 || x <= Min.Peek() )
            {
                Min.Push(x);
            } 
        }
    
        public void Pop()
        {
            var x = NumStack.Pop();

            if (x == Min.Peek())
            {
                Min.Pop();
            }
            
        }
    
        public int Top()
        {
            return NumStack.Peek();
        }
    
        public int GetMin()
        {
            return Min.Peek();
        }
    }
}