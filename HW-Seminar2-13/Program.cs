// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int number13 = Convert.ToInt32(Console.ReadLine());

double newNumber = number13 / 100;
if(newNumber >= 1) 
{
    int thirdDigit = ShowThirdDigit(number13);
    Console.WriteLine(thirdDigit);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

int ShowThirdDigit(int number)
{
    while(number >=1000) number /= 10;
    int newNumber = number % 10;
    return newNumber;
}