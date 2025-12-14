using System;

class InsertionSort
{
    static void Main()
    {
        int[] grades = { 85, 72, 90, 68, 74, 95, 60, 88, 79, 83 };

        for (int i = 1; i < grades.Length; i++)
        {
            int current = grades[i];
            int j = i - 1;

            while (j >= 0 && grades[j] > current)
            {
                grades[j + 1] = grades[j];
                j--;
            }
            grades[j + 1] = current;
        }

        Console.WriteLine("Sorted grades:");
        foreach (int g in grades)
            Console.Write(g + " ");
    }
}

