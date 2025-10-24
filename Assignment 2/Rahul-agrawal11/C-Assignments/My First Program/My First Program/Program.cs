
using System;
using System.Runtime.InteropServices;

internal class Program
{
    static void Main(string[] args)
    {
        TotalSum();
        Average();
        LargestElement();
        CountGender();
        Reverse();
        Multiplication();
        SearchElement();
        SecondLargest();
        RemoveDuplicates();
        CommonElements();

        Console.WriteLine("All Questions completed.");
    }
    static void TotalSum()
    {
        int[] transactions = { 200, -150, 340, 500, -100 };
        int totalSum = 0;
        foreach (int transaction in transactions)
        {
            totalSum += transaction;
        }
        Console.WriteLine("Total sum of transactions: " + totalSum);
    }

    static void Average()
    {
        float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
        float total = 0;
        foreach (float score in scores)
        {
            total += score;
        }
        float average = total / scores.Length;
        Console.WriteLine("Average score: " + average);
    }
    static void LargestElement()
    {
        int[] prices = { 1500, 2300, 999, 3200, 1750 };
        int largest = prices[0];
        foreach (int price in prices)
        {
            if (price > largest)
            {
                largest = price;
            }
        }
        Console.WriteLine("Largest element: " + largest);
    }

    static void CountGender()
    {
        int[] participantCodes = { 102, 215, 324, 453, 536 };
        int maleCount = 0;
        int femaleCount = 0;
        foreach (int code in participantCodes)
        {
            if (code % 2 == 0)
            {
                maleCount++;
            }
            else
            {
                femaleCount++;
            }
        }
        Console.Write("Number of Male: " + maleCount);
        Console.WriteLine(",  Number of Female: " + femaleCount);
    }
    static void Reverse()
    {
        int[] searchHistory = { 101, 202, 303, 404, 505 };
        Console.Write("Search history in reverse order: ");
        for (int i = searchHistory.Length - 1; i >= 0; i--)
        {
            Console.Write(searchHistory[i] + " ");
        }
        Console.WriteLine();
    }

    static void Multiplication()
    {
        int[] numbers = { 2, 3, 4, 5 };
        int product = 3;
        foreach (int number in numbers)
        {
            product *= number;
        }
        Console.WriteLine("Product of numbers: " + product);
    }

    static void SearchElement()
    {
        int[] elements = { 101, 203, 304, 405, 506 };
        int searchValue = 304;
        bool found = false;
        int i = 0;
        foreach (int element in elements)
        {
            i++;
            if (element == searchValue)
            {
                found = true;
                break;
            }
        }
        if (found)
        {
            Console.WriteLine("Element " + searchValue + " found in the array.");
            Console.WriteLine("Index: " + (i - 1));
        }
        else
        {
            Console.WriteLine("Element " + searchValue + " not found in the array.");
        }
    }

    static void SecondLargest()
    {
        int[] numbers = { 56, 78, 89, 45, 67 };
        int largest = int.MinValue;
        int secondLargest = int.MinValue;
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                secondLargest = largest;
                largest = number;
            }
            else if (number > secondLargest && number < largest)
            {
                secondLargest = number;
            }
        }
        Console.WriteLine("Second largest element: " + secondLargest);
    }

    static void RemoveDuplicates()
    {
        int[] numbers = { 102, 215, 102, 324, 215 };
        int[] uniqueNumbers = new int[numbers.Length];
        int index = 0;
        foreach (int number in numbers)
        {
            bool isDuplicate = false;
            for (int j = 0; j < index; j++)
            {
                if (uniqueNumbers[j] == number)
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                uniqueNumbers[index++] = number;
            }
        }
        Console.Write("Unique numbers: ");
        for (int i = 0; i < index; i++)
        {
            Console.Write(uniqueNumbers[i] + " ");
        }
        Console.WriteLine();
    }

    static void CommonElements()
    {
        int[] dataset1 = { 1, 2, 3, 4, 5 };
        int[] dataset2 = { 3, 4, 5, 6, 7 };

        Console.Write("Common Elements are: ");
        for (int i = 0; i < dataset1.Length; i++)
        {
            for (int j = 0; j < dataset2.Length; j++)
            {
                if (dataset1[i] == dataset2[j])
                {
                    Console.Write(dataset1[i] + " ");
                } 
            }
        }
        Console.WriteLine();
    }
}
