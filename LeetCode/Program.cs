using LeetCode.Problems;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {

            var minTiles = new TilesInRectangle();
            var a = minTiles.TilingRectangle(1, 2);

            Console.WriteLine($"{a}");
        }
    }
}