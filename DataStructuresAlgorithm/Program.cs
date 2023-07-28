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
                Console.WriteLine("Enter choice \n1.BinarySearch \n2.Anagram\n3.Replace String\n4.Insertion sort\n5.Bubble Sort\n6.Prime 0-1000\n7.Prime and palindrome\n8.Merge Sort");
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
                    case 4:
                        InsertionSort sort = new InsertionSort();
                        sort.Isort();
                        break;
                    case 5:
                        BubbleSort bubble = new BubbleSort();
                        bubble.Bubble();
                        break;
                    case 6:
                        PrimeNumber number = new PrimeNumber();
                        number.Prime1000();
                        break;
                    case 7:
                        PrimeAndPalindrome primeAndPalindrome = new PrimeAndPalindrome();
                        primeAndPalindrome.CheckPrimeAndPalin();
                        break;
                    

                }
            }
        }
    }
}