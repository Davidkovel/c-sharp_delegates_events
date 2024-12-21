using System;

public class Hw_Task3
{
    public Func<int[], int> ArrayCalculation = numbers =>
    {
        if (numbers == null)
        {
            throw new ArgumentNullException("The array is null");
        }

        int count = numbers.Count(x => x % 7 == 0);
        return count;
    };
}
