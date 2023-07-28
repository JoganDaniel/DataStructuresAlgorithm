using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm
{
    public class PrimeAndPalindrome
    {
        public void CheckPrimeAndPalin()
        {
            List<int> list = new List<int>();
            for (int i = 2; i < 1000; i++)
            {
                int count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    list.Add(i);
                }
            }
            foreach (int i in list)
            {
                int d = 0, rev = 0, t = i;
                while(t>0)
                {
                    d = t % 10;
                    rev = rev *10 + d;
                    t = t / 10;
                }
                if(rev==i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
