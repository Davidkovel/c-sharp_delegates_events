// lab task 7
namespace AnonymousMethod7Test
{
    public class Lab_Task7
    {
        public Func<int[], int[]> FindOddNumbers = array =>
        {
            var oddNumberLst = new List<int>();

            foreach (var number in array)
            {
                if (number % 2 != 0)
                {
                    oddNumberLst.Add(number);
                }
            }

            return oddNumberLst.ToArray();
        };
    }
}
