using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm
{
    public class MergeSortAlgorithm
    {
        public void MergeArray()
        {
            Console.WriteLine("Number of words");
            int l = Convert.ToInt32(Console.ReadLine());

            string[] names = new string[l];
            for (int i = 0;i<l;i++)
            {
                names[i] = Console.ReadLine();
            }
            MergeSort(names, 0, names.Length - 1);

            Console.WriteLine("Sorted array:");
            foreach (string name in names)
            {
                Console.Write(name + " ");
            }
        }
       public void MergeSort(string[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
        }

        static void Merge(string[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            string[] leftArr = new string[n1];
            string[] rightArr = new string[n2];

            Array.Copy(arr, left, leftArr, 0, n1);
            Array.Copy(arr, mid + 1, rightArr, 0, n2);

            int i = 0, j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (leftArr[i].CompareTo(rightArr[j]) <= 0)
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }
        }
    }
}
