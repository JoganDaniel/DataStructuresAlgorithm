using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm
{
    public class BubbleSort
    {
        public void Bubble()
        {
            Console.WriteLine("Enter length");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numbers");
            int[] arr = new int[l];
            for (int i = 0; i < l; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < l - 1; i++)
            {
                for (int j = 0; j < l - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted numbers");
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
