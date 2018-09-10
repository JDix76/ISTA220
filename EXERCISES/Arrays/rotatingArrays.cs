using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_Arrays
{
    class Program
    {
        static void Main(string[] args)
      
        {
                //int[] A = { 0, 2, 4, 6, 8, 10 };
                int[] B = { 1, 3, 5, 7, 9 };
                //int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
                LeftRotation(B, B.Length, 2);
                Print(B, B.Length);
                Console.ReadLine();
        }

        private static void sort(int[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int k = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = k;                        
                    }
                }
                Console.Write($" {arr[i]}");                
            }
            Console.WriteLine("");
        }

        private static void Print(int[] b, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(b[i] + " , ");
                }
        }

         private static void LeftRotation(int[] b, int n, int k)
            {
                for (int i = 0; i < k; i++)
                {
                    int temp = b[0];
                    for (int j = 1; j < n; j++)
                    {
                        b[j - 1] = b[j];
                    }

                    b[n - 1] = temp;
                }

         }

        
    }


}
    

