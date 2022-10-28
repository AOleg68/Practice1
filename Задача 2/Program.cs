//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int a = new Random().Next(1, 30);
Console.Write ("a = ");
Console.WriteLine (a);

int b = new Random().Next(1, 30);
Console.Write ("b = ");
Console.WriteLine (b);

int c = new Random().Next(1, 30);
Console.Write ("c = ");
Console.WriteLine (c);

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write ("max = ");
Console.WriteLine (max);
