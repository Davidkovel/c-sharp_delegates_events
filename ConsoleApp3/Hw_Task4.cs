public class Hw_Task4
{
    public Func<int[], int> CountPositiveNumbers = array =>
    {
        int count = array.Count(n => n > 0);
        return count;
    };
}

