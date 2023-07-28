using System;
using UnorderedList.UnorderedList;

namespace UnorderedList
{
    public class Program
    {
        static string unorderedFilepath = @"E:\Bridgelabz\DataStructuresAlgorithm\DataStructuresAlgorithm\UnorderedList\UnorderList.txt";
        private static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.ReadFileAndPerformOperation(unorderedFilepath);
        }
    }
}