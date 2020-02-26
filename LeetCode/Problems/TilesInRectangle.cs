using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class TilesInRectangle
    {
        public int TilingRectangle(int n, int m)
        {
            if (n == m)
            {
                return 1;
            }

            int currentInt = n * m;
            var count = 0;
            var toAdd = 0;
          

            if (currentInt % 2 != 0)
            {
                do
                {
                    currentInt++;
                } while (currentInt % 2 != 0);
                toAdd = 1;
            }

            do
            {
                currentInt = currentInt / 2;
                count++;
            } while (currentInt >= 1);
            return toAdd == 0? count : count - toAdd;

          
        }
    }
}
