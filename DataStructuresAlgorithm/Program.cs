using System;
namespace DataStructuresAlgorithm
{
    public class Program
    {
        static string searchFilePath = @"E:\Bridgelabz\DataStructuresAlgorithm\DataStructuresAlgorithm\DataStructuresAlgorithm\Files\Search.txt";
        public static void Main(string[] args)
        {
            Console.WriteLine("Data Structure\n");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter choice \n1.BinarySearch \n2.Anagram\n3.Replace String\n4.");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch search = new BinarySearch();
                        search.ReadTextFileAndSearch(searchFilePath);
                        break;
                    case 2:
                        Anagram anagram = new Anagram();
                        anagram.checkAnagram();
                        break;
                    case 3:
                        ReplaceString replace = new ReplaceString();
                        replace.StringReplace();
                        break;
                        
                }
            }
        }
    }
}