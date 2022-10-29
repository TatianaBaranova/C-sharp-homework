Console.Clear();
Console.WriteLine("Введите номер задачи: 19, 21 или 23");
int z = Convert.ToInt32(Console.ReadLine());

//задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
if (z == 19)
{
    Console.WriteLine("Введите пятизначное число: ");
    int number19 = Convert.ToInt32(Console.ReadLine());

    int[] numberA = GetArray(number19);
    int[] numberB = GetArr1(number19);

    if (numberA[0] == numberB[0] & numberA[1] == numberB[1])
    {
        Console.WriteLine("Yes, palindrome");
    }
    else
    {
        Console.WriteLine("No");
    }

    int[] GetArr1(int number1)
    {
        int length1 = GetLengthNumber(number1);
        int[] array1 = new int[length1];
        for (int i = length1 - 1; i >= 0; i--)
        {
            array1[i] = number1 % 10;
            number1 /= 10;
        }
        return array1;
    }

    int[] GetArray(int number)
    {
        int length = GetLengthNumber(number);
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = number % 10;
            number /= 10;
        }
        return array;
    }

    int GetLengthNumber(int number1)
    {
        int count = 0;
        while (number1 > 0)
        {
            number1 /= 10;
            count++;
        }
        return count;
    }
}

//задача 21
//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
if (z == 21)
{
    double Distance3d(int xa, int ya, int za, int xb, int yb, int zb)
    {
        double dist3D = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
        return dist3D;
    }

    Console.WriteLine("Введите 3D координаты первой точки: ");
    bool isParsedXA = int.TryParse(Console.ReadLine(), out int xA);
    bool isParsedYA = int.TryParse(Console.ReadLine(), out int yA);
    bool isParsedZA = int.TryParse(Console.ReadLine(), out int zA);

    Console.WriteLine("Введите 3D координаты второй точки: ");
    bool isParsedXB = int.TryParse(Console.ReadLine(), out int xB);
    bool isParsedYB = int.TryParse(Console.ReadLine(), out int yB);
    bool isParsedZB = int.TryParse(Console.ReadLine(), out int zB);

    if (!isParsedXA || !isParsedXB || !isParsedZA || !isParsedXB || !isParsedYB || !isParsedZB)
    {
        Console.WriteLine("Ошибка! Не верно введены координаты");
        return;
    }

    double distanceDot = Distance3d(xA, yA, zA, xB, yB, zB);
    Console.WriteLine($"Расстояние между точками в пространстве {distanceDot}");
}

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
if (z == 23)
{
    Console.WriteLine("Введите число: ");
    bool isParsedN = int.TryParse(Console.ReadLine(), out int N);
    if (!isParsedN)
    {
        Console.WriteLine("Ошибка! Это не число!");
        return;
    }
    int[] result23 = GetTableOfCubes(N);
    PrintArray(result23);

    int[] GetTableOfCubes(int n)
    {
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (i + 1) * (i + 1) * (i + 1);
        }
        return array;
    }

    void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
}

