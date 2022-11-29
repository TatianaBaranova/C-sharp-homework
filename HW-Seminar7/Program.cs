Console.Clear();
Console.WriteLine("Введите номер задачи: 47, 50 или 52");
double z = Convert.ToInt32(Console.ReadLine());

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
if (z == 47)
{
    Console.WriteLine("Решаем задачу №47");
    Console.WriteLine("Введите m - ");
    bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
    Console.WriteLine("Введите n - ");
    bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
    if (!isParsedM || !isParsedN)
    {
        Console.WriteLine("Некорректный ввод!");
        return;
    }

    double[,] array = CreateRandom2DArray(m, n);
    Print2DArray(array);
}

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//возвращает значение этого элемента или же указание, что такого элемента нет.
if (z == 50)
{
    Console.WriteLine("Решаем задачу №50");
    Console.WriteLine("Введите m - ");
    bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
    Console.WriteLine("Введите n - ");
    bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
    if (!isParsedM || !isParsedN)
    {
        Console.WriteLine("Ошибка!");
        return;
    }

    int[,] array = CreateRandom2DArray1(m, n);
    Print2DArray1(array);

    Console.WriteLine("Введите номер строки - ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца - ");
    int column = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(CheckPosition(row, column, array));

}

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
if (z == 52)
{
    Console.WriteLine("Решаем задачу №52");
    Console.WriteLine("Введите m - ");
    bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
    Console.WriteLine("Введите n - ");
    bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
    if (!isParsedM || !isParsedN)
    {
        Console.WriteLine("Ошибка!");
        return;
    }

    int[,] array = CreateRandom2DArray1(m, n);
    Print2DArray1(array);
    CountAveragePerColumn(array);
}

//метод - задает массив случайных вещественных чисел
double[,] CreateRandom2DArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(-10,10)/10.0;
        }
    }
    return array;
}

//метод - выводит 2D массив на экран
void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//метод - проверяет есть ли позиция с заданным индексом в массиве
bool CheckPosition(int i, int j, int[,] array)
{
    if (i <= array.GetLength(0)-1 & j <= array.GetLength(1)-1)
    {
        Console.WriteLine($"значение элемента {array.GetValue(i,j)}");
        return true;
    }
    return false;
}

//метод - создает массив int
int[,] CreateRandom2DArray1(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1,10);
        }
    }
    return array;
}

//метод - выводит массив int
void Print2DArray1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//метод - расчет среднего арифметического по столбцам
double[] CountAveragePerColumn(int[,] array)
{
    double[] avg = new double[array.GetLength(0)];
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summa = 0;
        int k = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summa += array[i,j];
        }
        Console.WriteLine(summa);
        avg[k] = summa/array.GetLength(0);
        Console.WriteLine($"Среднее арифметическое столбца "+(j+1)+" равно "+avg[k]);
        k++;
    }
    return avg;
}