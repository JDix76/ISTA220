using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 2, 4, 6, 8, 10 };
            int[] B = { 1, 3, 5, 7, 9 };
            int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            int count = 0;
            int sum = 0;
            double mean = 0.0;

            foreach (int e in A)
            {
                count++;
                sum = e + sum;
                mean = (double)sum / count;
            }
            //foreach (int d in B)
            //{
            //    count++;
            //    sum = d + sum;
            //    mean = (double)sum / count;
            //}
            //foreach (int f in C)
            //{
            //    count++;
            //    sum = f + sum;
            //    mean = (double)sum / count;
            //}


            Console.WriteLine($"The count for Array A is: {count}");
            Console.WriteLine($"The sum for Array A is:  {sum}");
            Console.WriteLine($"The mean for Array A is {mean}");
            Console.WriteLine();

            //Console.WriteLine($"The count for Array B is: {count}");
            //Console.WriteLine($"The sum for Array B is:  {sum}");
            //Console.WriteLine($"The mean for Array B is {mean}");
            //Console.WriteLine();

            //Console.WriteLine($"The count for Array C is: {count}");
            //Console.WriteLine($"The sum for Array C is:  {sum}");
            //Console.WriteLine($"The mean for Array C is {mean}");
            //Console.WriteLine();


            Console.WriteLine("Array A is: ");
            Console.WriteLine(string.Join(" , ", A));
            Array.Reverse(A);
            Console.WriteLine("The Reverse of Array A : ");
            Console.WriteLine(string.Join(" , ", A));
            Console.WriteLine();

            Console.WriteLine("Array B is:");
            Console.WriteLine(string.Join(" , ", B));
            Array.Reverse(B);
            Console.WriteLine("The Reverse of Array B: ");
            Console.WriteLine(string.Join(" , ", B));
            Console.WriteLine();

            Console.WriteLine("Array C is:");
            Console.WriteLine(string.Join(" , ", C));
            Array.Reverse(C);
            Console.WriteLine("The Reverse of Array C: ");
            Console.WriteLine(string.Join(" , ", C));
            Console.WriteLine();

            

            







        }
    }
}
