using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть перший масив слів, розділених пробілами:");
        string[] arr1 = Console.ReadLine().Split(' ');

        Console.WriteLine("Введіть другий масив слів, розділених пробілами:");
        string[] arr2 = Console.ReadLine().Split(' ');

        int leftCount = 0;
        int minLength = Math.Min(arr1.Length, arr2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (arr1[i] == arr2[i])
                leftCount++;
            else
                break;
        }

        int rightCount = 0;
        for (int i = 1; i <= minLength; i++)
        {
            if (arr1[arr1.Length - i] == arr2[arr2.Length - i])
                rightCount++;
            else
                break;
        }

        if (leftCount >= rightCount)
        {
            Console.WriteLine($"{leftCount} Найбільший спільний кінець є ліворуч.");
            for (int i = 0; i < leftCount; i++)
            {
                Console.WriteLine(arr1[i]);
            }
        }
        else
        {
            Console.WriteLine($"{rightCount} Найбільший спільний кінець є праворуч.");
            for (int i = 1; i <= rightCount; i++)
            {
                Console.WriteLine(arr1[arr1.Length - i]);
            }
        }
    }
}
