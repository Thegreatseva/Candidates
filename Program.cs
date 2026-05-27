using System;

class Program
{
    static void Main()
    {
        int countA = 0;
        int countB = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Введите голос {i} (A или B):");
            string vote = Console.ReadLine().ToUpper();

            if (vote == "A")
            {
                countA++;
            }
            else if (vote == "B")
            {
                countB++;
            }
            else
            {
                Console.WriteLine("Некорректный ввод, голос не засчитан.");
                i--; // повторяем попытку
            }
        }

        Console.WriteLine("\nРезультаты:");
        Console.WriteLine($"A: {countA}");
        Console.WriteLine($"B: {countB}");

        if (countA > countB)
        {
            Console.WriteLine("Победил кандидат A");
        }
        else if (countB > countA)
        {
            Console.WriteLine("Победил кандидат B");
        }
        else
        {
            Console.WriteLine("Ничья");
        }
    }
}
