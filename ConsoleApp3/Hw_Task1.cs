using System;

// hw task 1
public class Hw_Task1
{
    public Dictionary<string, (int, int, int)> RgbColors = new Dictionary<string, (int, int, int)>
    {
        { "Red", (255, 0, 0) },
        { "Orange", (255, 165, 0) },
        { "Yellow", (255, 255, 0) },
        { "Green", (0, 255, 0) },
        { "Blue", (0, 0, 255) },
    };

    public (int, int, int) GetRgb(string color)
    {
        if (RgbColors.ContainsKey(color))
        {
            return RgbColors[color];
        }
        else
        {
            throw new Exception($"There is no such color: {color}");
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("[INFO] The program started well");
    }
}
