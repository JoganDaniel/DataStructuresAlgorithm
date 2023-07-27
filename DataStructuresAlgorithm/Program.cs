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
                Console.WriteLine("Enter choice \n1.BinarySearch \n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch search = new BinarySearch();
                        search.ReadTextFileAndSearch(searchFilePath);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}