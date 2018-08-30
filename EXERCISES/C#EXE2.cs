using System;

namespace sum2ten
{

    class Program
    {
        static void Main(string[] args)
        {
            char grade = 'z';


            //Ask the user for score input
            Console.WriteLine("Please input your score:");


            //Assign a letter grade to the average of the score
            int userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput > 90)

            {
                grade = 'A';
            }

            else if (userinput >= 80 && userinput < 90)
            {
                grade = 'B';
            }

            else if (userinput >= 70 && userinput < 80)
            {
                grade = 'C';
            }

            else if (userinput >= 60 && userinput < 70)
            {
                grade = 'D';
            }

            else
            {
                grade = 'F';
            }
            Console.WriteLine($"Your grade is:{grade}");






        }

    }
}

       






