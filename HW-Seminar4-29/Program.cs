// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введите размер массива: ");
bool isParsedS = int.TryParse(Console.ReadLine(), out int s);
Console.WriteLine("Введите левую границу массива: ");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
Console.WriteLine("Введите правую границу массива: ");
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);

if(!isParsedA | !isParsedB | !isParsedS)
{
    Console.WriteLine("Некорректный ввод: ");
    return;
}

int[] array1 = GetRandomArray(s, a, b);
PrintArray(array1);

int[] GetRandomArray(int size, int leftb, int rightb)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftb, rightb + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}
