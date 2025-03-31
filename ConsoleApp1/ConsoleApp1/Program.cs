using System;

enum DaysOfWeek
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Виберіть завдання для виконання:");
        Console.WriteLine("1. Одновимірний масив із випадковими значеннями.");
        Console.WriteLine("2. Перевірка суми елементів масиву.");
        Console.WriteLine("3. Таблиця множення.");
        Console.WriteLine("4. Двовимірний масив 5х5.");
        Console.WriteLine("5. Рахування дня за допомогою enum.");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Task1();
                break;

            case 2:
                Task2();
                break;

            case 3:
                Task3();
                break;

            case 4:
                Task4();
                break;

            case 5:
                Task5();
                break;

            default:
                Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                break;
        }
    }

    static void Task1()
    {
        Random random = new Random();
        int[] array = new int[10];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 11);
        }

        Console.WriteLine("Елементи масиву з парними індексами:");
        for (int i = 0; i < array.Length; i += 2)
        {
            Console.WriteLine($"Індекс {i}, значення: {array[i]}");
        }
    }

    static void Task2()
    {
        int[] array = { -3, 2, 5, 7, -2, 6, 0, 8, -1, 4 }; // Приклад масиву
        int sum = 0;

        foreach (var number in array)
        {
            sum += number;
        }

        Console.WriteLine($"Сума елементів масиву: {sum}");
        Console.WriteLine(sum >= 0 ? "Сума є невід'ємною." : "Сума є від'ємною.");
    }

    static void Task3()
    {
        int[,] multiplicationTable = new int[9, 9];

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                multiplicationTable[i, j] = (i + 1) * (j + 1);
            }
        }

        Console.WriteLine("Таблиця множення 9x9:");
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write($"{multiplicationTable[i, j],3} ");
            }
            Console.WriteLine();
        }
    }

    static void Task4()
    {
        Random random = new Random();
        int[,] array = new int[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = random.Next(1, 101);
            }
        }

        int max = int.MinValue, min = int.MaxValue;
        (int maxRow, int maxCol) = (0, 0);
        (int minRow, int minCol) = (0, 0);

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                    maxRow = i;
                    maxCol = j;
                }

                if (array[i, j] < min)
                {
                    min = array[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        Console.WriteLine("Максимальний елемент: " + max);
        Console.WriteLine("Координати максимального елемента: [" + maxRow + ", " + maxCol + "]");
        Console.WriteLine("Мінімальний елемент: " + min);
        Console.WriteLine("Координати мінімального елемента: [" + minRow + ", " + minCol + "]");
    }

    static void Task5()
    {
        Console.Write("Введіть кількість днів: ");
        int days = int.Parse(Console.ReadLine());

        DaysOfWeek startDay = DaysOfWeek.Monday;
        DaysOfWeek resultDay = (DaysOfWeek)((days % 7 + (int)startDay) % 7);

        Console.WriteLine($"День через {days} днів буде: {resultDay}");
    }
}
