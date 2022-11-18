Console.Clear();
Console.WriteLine("Введите номер задачи: 34, 36 или 38");
int z = Convert.ToInt32(Console.ReadLine());

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
if (z == 34)
{
    Console.WriteLine("Решаем задачу №34");
    int[] numbers = new int[10];
    FillArray(numbers);
    PrintArray(numbers);
    int result = CountEvenNumbers(numbers);
    Console.WriteLine($"Количество четных чисел: {result}");
}

//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
if (z == 36)
{
    Console.WriteLine("Решаем задачу №36");
    int[] numbers = new int[10];
    FillArrayLight(numbers);
    PrintArray(numbers);
    int sum = SumEvenPositionNumbers(numbers);
    Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
}

//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
if (z == 38)
{
    Console.WriteLine("Решаем задачу №38");
    int[] numbers = new int[10];
    FillArray(numbers);
    PrintArray(numbers);
    int max = MaxNumber(numbers);
    Console.WriteLine($"Максимальный элемент: {max}");
    int min = MinNumber(numbers);
    Console.WriteLine($"Минимальный элемент: {min}");
    int diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементом: {diff}");
}

//метод - подсчет четных чисел в массиве
int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

//метод - сумма элементов, стоящих на нечетных позициях
int SumEvenPositionNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+= 2)
    {
        sum += array[i];
    }
    return sum;
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

//метод - заполнение массива трехзначными числами
void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100,1000);
    }
}

//метод - заполнение массива до 10
void FillArrayLight(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0,10);
    }
}

//метод - нахождение максимального элемента массива
int MaxNumber(int [] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

//метод - нахождение минимального элемента массива
int MinNumber(int [] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}
