using System;
using System.Text;

namespace pr18
{
    class q18
    {
        protected static void example1()
        {        
            Console.WriteLine("_Example 1_");
            StringBuilder s1 = new StringBuilder("Hello World!");
            s1.Append("What a beautiful day.");
            Console.WriteLine(s1);
        }        
                 
                 
        protected static void example2()
        {
            Console.WriteLine("_Example 2_");
            StringBuilder MyInt = new StringBuilder("Your total is ");
            MyInt.AppendFormat("{0:C} ", MyInt);
            Console.WriteLine(MyInt);
        }


        protected static void example3()
        {
            Console.WriteLine("_Example 3_");
            StringBuilder s3 = new StringBuilder("Hello World!");
            s3.Insert(6, "Beautiful ");
            Console.WriteLine(s3);
        }


        protected static void example4()
        {
            Console.WriteLine("_Example 4_");
            StringBuilder myStringBuilder = new StringBuilder("Hello World!");
            myStringBuilder.Remove(5, 7);
            Console.WriteLine(myStringBuilder);
        }


        protected static void example5()
        {
            Console.WriteLine("_Example 5_");
            StringBuilder myStringBuilder = new StringBuilder("Hello World!");
            myStringBuilder.Replace('!', '?');
            Console.WriteLine(myStringBuilder);
        }


        protected static void example6()
        {
            StringBuilder sb = new StringBuilder();
            bool flag = true;
            string[] spellings = { "recieve", "receeve", "receive" };
            sb.AppendFormat("Which of the following spellings is {0}: ", flag);
            sb.AppendLine();

            for (int i=0; i<=spellings.GetUpperBound(0); i++) {
                sb.AppendFormat("    {0}.  {1}", i, spellings[i]);
                sb.AppendLine();
            }
            sb.AppendLine();
            Console.WriteLine(sb.ToString());
        }


        // main method
        static void Main(string[] args)
        {
            example1();
            Console.WriteLine();
            example2();
            Console.WriteLine();
            example3();
            Console.WriteLine();
            example4();
            Console.WriteLine();
            example5();
            Console.WriteLine();
            example6();
        }
    }
}