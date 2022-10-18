//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
//a = 1 b = 1 -> числа равны.

Console.WriteLine("Введите 2 числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if(numberA == numberB) 
{
    Console.WriteLine("числа равны");
}
else
{
    if(numberA > max) max = numberA;
    if(numberB > max) max = numberB;
    Console.Write("max = ");
    Console.WriteLine(max);
}
