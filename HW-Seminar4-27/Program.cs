// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int a);

if(!isParsed)
{
    Console.WriteLine("Некорректный ввод");
    return;
}
int sum = SumDigit(a);
Console.WriteLine(sum);

int SumDigit(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number % 10;
        number /= 10;
    }
    return sum;
}