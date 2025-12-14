using System;

class InsertionSortExample
{
    static void Main()
    {
        int[] calificaciones = { 85, 72, 90, 68, 74, 95, 60, 88, 79, 83 };

        for (int i = 1; i < calificaciones.Length; i++)
        {
            int actual = calificaciones[i];
            int j = i - 1;

            while (j >= 0 && calificaciones[j] > actual)
            {
                calificaciones[j + 1] = calificaciones[j];
                j--;
            }
            calificaciones[j + 1] = actual;
        }

        Console.WriteLine("Calificaciones ordenadas:");
        foreach (int c in calificaciones)
            Console.Write(c + " ");
    }
}
