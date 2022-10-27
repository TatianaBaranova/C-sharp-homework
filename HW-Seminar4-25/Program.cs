//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.WriteLine("Введите 2 числа: ");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);
if (!isParsedA | !isParsedB)
{
    Console.WriteLine("Некорректный ввод");
    return;
}
if(a < 1 | b < 1)
{
    Console.WriteLine("0");
    return;
}

int result = GetMultiply(a, b);
Console.WriteLine(result);

int GetMultiply (int number1, int number2)
{
    int multipl = 1;
    for(int i = 1; i <= number2; i++)
    {
        multipl *= number1;
    }
    return multipl;
}