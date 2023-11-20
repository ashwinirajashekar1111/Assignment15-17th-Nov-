using System;

class SortingAlgorithms
{
    static void Main()
    {
        // Generate a random array
        int[] randomArray = GenerateRandomArray(10);

        Console.WriteLine("Original Array:");
        PrintArray(randomArray);

        // Apply Bubble Sort in descending order
        BubbleSortDescending(randomArray);

        Console.WriteLine("\nSorted Array:");
        PrintArray(randomArray);

        // Check if the array is sorted correctly
        Console.WriteLine("\nIs the array sorted correctly? " + IsSorted(randomArray));

        // Perform Binary Search
        int searchKey = 5;
        int index = BinarySearch(randomArray, searchKey);

        if (index != -1)
            Console.WriteLine($"\n{searchKey} found at index {index}");
        else
            Console.WriteLine($"\n{searchKey} not found in the array");
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 100); // Adjust the range as needed
        }

        return array;
    }

    static void BubbleSortDescending(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] < array[j + 1])
                {
                    // Swap elements if they are in the wrong order
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static bool IsSorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    static int BinarySearch(int[] array, int key)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == key)
                return mid;

            if (array[mid] > key)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1; // Key not found
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

