# CustomCollection

## Summary

"Custom Collection" is a simple C# project that demonstrates a custom numerical collection with multiple mathematical operations like Sum, Average, Product, Maximum, Minimum, and Median of all elements in the collection. This numerical collection has been implemented utilizing the concept of singly linked list.

This collection can be used for any kind of numerical data type (like int, double, decimal...) since it has been made generic.

## Features

* Provides fundamental operations like Add, Remove, Contains on the collection.
* Provides mathematical operations on the collection:
  * Sum: Computes the sum of all elements.
  * Average: Computes average (mean) of all elements.
  * Product: Computes product of all elements.
  * Maximum: Finds maximum of all elements.
  * Minimum: Finds minimum of all elements.
  * Median: Retrieves the median value from the collection.

## Usage

Here is a simple usage example:

```C#
MathsOperationsCollection<int> mathsOperationsCollection = new MathsOperationsCollection<int>();
mathsOperationsCollection.Add(5);
mathsOperationsCollection.Add(4);
mathsOperationsCollection.Add(3);
mathsOperationsCollection.Add(2);
mathsOperationsCollection.Add(1);

foreach (var item in mathsOperationsCollection)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Sum: {mathsOperationsCollection.Sum()}");
Console.WriteLine($"Average: {mathsOperationsCollection.Average()}");
Console.WriteLine($"Product: {mathsOperationsCollection.Product()}");
Console.WriteLine($"Maximum: {mathsOperationsCollection.Maximum()}");
Console.WriteLine($"Minimum: {mathsOperationsCollection.Minimum()}");
Console.WriteLine($"Median: {mathsOperationsCollection.GetMedian()}");
```

## Pre-requisites

* .NET Core SDK

## How To Run

You can run the `Program.cs` in your preferred C# development environment.

## Contribution

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## Contact

This project is maintained by: `Mayank Bharadwaj`.
You can contact me at: `mayank_bharadwaj@epam.com`.
