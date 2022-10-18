//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for(int a = 1; a <= number; a ++)
if(a%2 == 0)
Console.WriteLine(a);