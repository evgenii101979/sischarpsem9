// Задача 68: Задайте значения M и N. Напишите программу, 
//которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.

//M = 28; N = 7 -> 7

Console.Clear();
System.Console.WriteLine("наибольший общий делитель (НОД) M и N чисел с помощью рекурсии\n");
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
// int NOD = recNum(M, N);
recNum(M, N);
void recNum(int M, int N)
{
    if (M > N)
    {
        M=M%N;
    }
    else
    {
        N=N%M;
    }
    if(M!=0 && N!=0)
    {
        recNum(M,N);
    }
    else
    {
        System.Console.WriteLine("NOD " + (M+N).ToString());
    }
}

