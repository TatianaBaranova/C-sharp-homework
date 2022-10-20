// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int randomNumber10 = GetRandomNumber(100, 1000);
Console.WriteLine(randomNumber10);
int SecondNumber = ShowSecondDigit(randomNumber10);
Console.WriteLine(SecondNumber);

int GetRandomNumber(int minValue, int maxValue)
{
    Random random = new Random();
    int randomNumber = random.Next(minValue, maxValue);
    return randomNumber;
}

int ShowSecondDigit(int number)
{
    int newNumber = number % 100;
    newNumber = newNumber/10;
    return newNumber;
}