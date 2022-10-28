//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

int Number = new Random().Next(1, 30);


if (Number % 2 == 0)
{
    Console.Write ("Это число четное:");
    Console.WriteLine (Number);
}
else 
{
    Console.Write ("Это число нечетное:");
    Console.WriteLine (Number);
}
 