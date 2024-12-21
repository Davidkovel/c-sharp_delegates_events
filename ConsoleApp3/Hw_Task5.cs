public class Hw_Task5
{
    public Func<int[], int[]> GetUniqueNegativeNumbers = array =>
    {
        var uniqueNegatives = new HashSet<int>();

        foreach (var number in array)
        {
            if (number < 0)
            {
                uniqueNegatives.Add(number);
            }
        }

        return uniqueNegatives.ToArray();
    };
}

