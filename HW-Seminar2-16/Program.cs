// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
int weekday = Convert.ToInt32(Console.ReadLine());

bool result = CheckWeekday(weekday);

if(result)
{
    Console.WriteLine("Да, выходной");
}
else
{
    Console.WriteLine("Нет, рабочий день");
}

bool CheckWeekday(int number)
{
    int number1 = number;
    int number2 = number;
    return number1 == 6 | number2 == 7;
}
