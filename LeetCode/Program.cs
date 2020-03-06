using LeetCode.Problems;
using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var cNames = new CtorNames();
            var cName = "abbzccc";
            var mName = "babzzcz";
            var x = cNames.constructorNames(cName, mName);

            Console.WriteLine($"Name validity: {x}");
        }
    }
}