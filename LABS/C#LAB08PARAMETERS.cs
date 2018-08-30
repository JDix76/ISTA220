﻿--AUTHOR: JAMES DIX
--DATE: 30 AUG 2018
--SUBJECT: C#LAB08
#region using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int i = 0;
            Console.WriteLine(i);
            Pass.Value(i);
            Console.WriteLine(i);

            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);

            int j = 0;
            Console.WriteLine(j);
            Pass.Value1(ref j);
            Console.WriteLine(j);
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

using System;

namespace Parameters
{
    class Pass
    {
        public static void Value(ref int param)
        {
            param = 42;
        }

        public static void Reference(WrappedInt param)
        {
            param.Number = 42;
        }
    }
}

namespace Parameters
{
    class WrappedInt
    {
        public int Number;
    }
}




