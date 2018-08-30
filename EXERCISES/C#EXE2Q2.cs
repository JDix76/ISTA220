using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        

        static void Main(string[] args)
        {


            int start = 0;
            int end = 10;
            int sum = 0;
            get_sum(start, end, sum);
            int scoreval = Convert.ToInt32(Console.ReadLine());
        }

        private static void get_sum(int start, int end, int sum)
        {

            start = start + 1;
            if (start == 1)
            {
                //Tell user to input the scores
                Console.WriteLine($"Please type in 10 test scores");
                
            }

            int userinput = Convert.ToInt32(Console.ReadLine());


            sum = sum + userinput;
            if (start < end)
                get_sum(start, end, sum);
            else Console.WriteLine($"The average of the all 10 test scores is: {sum/10}");


        }
           
    }

        




}
