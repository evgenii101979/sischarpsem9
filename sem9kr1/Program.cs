// Задача 63: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от 1 до N с помощью рекурсии
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

System.Console.WriteLine("Числа в промежутке от 1 до N с помощью рекурсии\n");
System.Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
outputRec(N);
void outputRec(int i)
{
    i--;
    if (i > 0)
    {
        outputRec(i);
    }
    System.Console.Write(" " + (i + 1));
}
