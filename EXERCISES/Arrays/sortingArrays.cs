using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            int temp = 0;

            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < C.Length; j++)
                {
                    if (C[i] < C[j])
                    {
                        temp = C[i];

                        C[i] = C[j];

                        C[j] = temp;
                    }
                }
            }
            for (int i = 0; i < C.Length; i++)
            {
                Console.Write("{0}, ", C[i]);
            }
        }
    }
}




