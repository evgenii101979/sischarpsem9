// Задача 64: Задайте значения N и M. Напишите программу, 
//которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

//M = 1; N = 5 -> 2, 4
//M = 4; N = 8 -> 4, 6, 8

Console.Clear();
System.Console.WriteLine("чётные натуральные числа в промежутке от M до N с помощью рекурсии\n");
Console.Write("Введите число M: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int M = Convert.ToInt32(Console.ReadLine());


fromMtoN(M, N);
void fromMtoN(int M, int N)
{
    if (N <= M)
    {
        if (N % 2 == 0)
        {
            System.Console.WriteLine($"{N}, ");
            N++;
            fromMtoN(M, N);
        }
        else
        {
            N++;
            fromMtoN(M, N);
        }
    }
}
