using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm
{
    public class InsertionSort
    {
        public void Isort()
        {
            Console.WriteLine("Enter number of strings");
            int l =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the strings");
            string[] arr = new string[l];
            for(int i=0;i<l;i++)
            {
                arr[i] = Console.ReadLine();
            }
            for (int i = 1; i < arr.Length; i++)
            {
                string key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
