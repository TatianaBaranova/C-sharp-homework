Console.Clear();
Console.WriteLine("Введите номер задачи: 41 или 43");
int z = Convert.ToInt32(Console.ReadLine());

//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
if (z == 41)
{
    Console.WriteLine("Решаем задачу №41");
    Console.WriteLine("Введите количество элементов: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    int i = 0;
    while (i < length)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        i++;
    }
    PrintArray(array);
    int result = CountPositiveNumbers(array);
    Console.WriteLine($"Количество чисел больше 0: {result}");
}

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
if (z == 43)
{
    Console.WriteLine("Решаем задачу №43");
    Console.WriteLine("Введите координаты b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

    Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");
}

//метод - вывод массива
void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//метод - считает сколько числе больше 0
int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}