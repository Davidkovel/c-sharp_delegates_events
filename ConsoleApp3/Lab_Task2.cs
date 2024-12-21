// lab task 2
namespace AnonymousMethod2Test
{
    public class Lab_Task2
    {
        public Func<int, int> CalculateSquare = delegate (int number)
        {
            return number * number;
        };
    }
}
