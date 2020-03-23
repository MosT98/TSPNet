using System;

namespace lab1
{
    class Program
    {
        static void Main()
        {
            Problem1 a = new Problem1();
            a.OnMultipleOfTenReached += new Problem1.EventRaiser(MultipleOfTenReached);

            int iAnswer = a.Add(4, 3);
            Console.WriteLine("iAnswer = {0}", iAnswer);
            iAnswer = a.Add(4, 6);
            Console.WriteLine("iAnswer = {0}", iAnswer);
            iAnswer = a.Add(12, 12);
            Console.WriteLine("iAnswer = {0}", iAnswer);
            iAnswer = a.Add(10, 10);
            Console.WriteLine("iAnswer = {0}", iAnswer);
        }

        static void MultipleOfTenReached()
        {
            Console.WriteLine("Multiple of ten reached!");
        }

        
    }
}
