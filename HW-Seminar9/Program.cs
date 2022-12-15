Console.Clear();
Console.WriteLine("Введите номер задачи: 64, 66 или 68");
double a = Convert.ToInt32(Console.ReadLine());

//Задача 64: Задайте значение N. Напишите метод, который выведет все натуральные числа в промежутке от N до 1.
if (a == 64)
{
    Console.WriteLine("Решаем задачу №64");
    Console.WriteLine("Введите n - ");
    bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
    if (!isParsedN)
    {
        Console.WriteLine("Ошибка!");
        return;
    }
    PrintNumbers(n);
}

//Задача 66: Задайте значения M и N. Напишите метод, 
//который найдёт сумму натуральных элементов в промежутке от M до N.
if (a == 66)
{
    Console.WriteLine("Решаем задачу №66");
    Console.WriteLine("Введите меньшее число m - ");
    bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
    Console.WriteLine("Введите большее число n - ");
    bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
    if (!isParsedN || !isParsedM)
    {
        Console.WriteLine("Ошибка!");
        return;
    }
    Console.WriteLine(SumNumbers(m, n));
}

//Задача 68: Напишите метод вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
if (a == 68)
{
    Console.WriteLine("Решаем задачу №68");
    Console.WriteLine("Введите неотрицательное число n - ");
    bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
    Console.WriteLine("Введите неотрицательное число m - ");
    bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
    if (!isParsedN || !isParsedM)
    {
        Console.WriteLine("Ошибка!");
        return;
    }
    int result = AckermanFunction(n, m);
    Console.WriteLine(result);
}

//метод - выводит числа от N до 1.
void PrintNumbers(int num)
{
    Console.Write(num + " ");
    if (num > 1)
    {
        PrintNumbers(num - 1);
    }
}

//метод - выводит сумму чисел от M до N
int SumNumbers(int minValue, int maxValue)
{
    if (minValue > maxValue)
    {
        return 0;
    }
    return minValue + SumNumbers(minValue + 1, maxValue);
}

//метод - вычисление функции Акермана
int AckermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return AckermanFunction(n - 1, 1);
    if (n > 0 && m > 0) return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
    return AckermanFunction(n, m);
}