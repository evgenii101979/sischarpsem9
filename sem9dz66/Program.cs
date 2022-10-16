// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

Console.Clear();
System.Console.WriteLine("сумма натуральных элементов в промежутке от M до N с помощью рекурсии\n");
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

sumNum(M, N);
int sumNum(int M, int N)
{
    int sum =0;
    for (int i = N; i <= M; i++) sum+=i;
    System.Console.WriteLine(sum);
    return sum;
}
