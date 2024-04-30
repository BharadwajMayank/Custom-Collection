using System;

namespace CustomCollection { 
class Program
{
    static void Main()
    {
            MathsOperationsCollection<int> MathsOperationsCollection = new MathsOperationsCollection<int>();

        MathsOperationsCollection.Add(5);
        MathsOperationsCollection.Add(4);
        MathsOperationsCollection.Add(3);
        MathsOperationsCollection.Add(2);
        MathsOperationsCollection.Add(1);


        foreach (var item in MathsOperationsCollection)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Sum: {MathsOperationsCollection.Sum()}");
        Console.WriteLine($"Average: {MathsOperationsCollection.Average()}");
        Console.WriteLine($"Product: {MathsOperationsCollection.Product()}");
        Console.WriteLine($"Maximum: {MathsOperationsCollection.Maximum()}");
        Console.WriteLine($"Minimum: {MathsOperationsCollection.Minimum()}");
        Console.WriteLine($"Median: {MathsOperationsCollection.GetMedian()}");

    }
}
}
