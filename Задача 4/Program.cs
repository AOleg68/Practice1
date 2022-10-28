//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

int N = new Random().Next(1,30);
Console.Write ("Ввводное число:  ");
Console.WriteLine (N);
if (N % 2 == 0) 
{
        while (N > 1)
        {
            Console.Write ("Четные числа от 1 до N:   ");
            Console.WriteLine (N);
            N = N - 2;
        }
        
}
else
{
        while (N > 1)
        {
            Console.Write ("Четные числа от 1 до N:   ");
            Console.WriteLine (N - 1);
            N = N - 2;
        }
        
}



