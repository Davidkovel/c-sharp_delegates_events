using System;

// lab task 1
namespace AnonymousMethodTest
{
    public class NumberChecker
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[info] Program started");
        }

        public Predicate<int> IsEven = delegate (int number)
        {
            return number % 2 == 0;
        };
    }

}
