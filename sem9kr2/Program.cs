// Задача 65: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N с помощью рекурсии
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 5, 6, 7, 8"

System.Console.WriteLine("натуральные числа в промежутке от M до N с помощью рекурсии\n");
System.Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число M ");
int M = Convert.ToInt32(Console.ReadLine());
between_M_and_N();
void between_M_and_N(int from, int to)
{
    if (from == to) Console.Write(from);
    
    else
    {
        Console.Write(from + " ");
        between_M_and_N(from + 1, to);
    }
}

