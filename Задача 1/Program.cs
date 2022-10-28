//Задача: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a = new Random().Next(1, 30);
Console.Write ("a = ");
Console.WriteLine (a);

int b = new Random().Next(1, 30);
Console.Write ("b = ");
Console.WriteLine (b);

int max = a;
int min = b;

if (b > max) max = b;
if (a < max) min = a;

Console.Write ("max = ");
Console.WriteLine (max);


Console.Write ("min = ");
Console.WriteLine (min);