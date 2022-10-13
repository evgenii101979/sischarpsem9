// Задача 67: Напишите программу, которая будет принимать на вход 
//число и возвращать сумму его цифр с помощью рекурсии.
//453 -> 12
//45 -> 9


System.Console.WriteLine("Введите число N ");
int num = Convert.ToInt32(Console.ReadLine());


int result = sum_of_digit(num);
Console.WriteLine("Сумма цифр в " + num + " равна " + result);

int sum_of_digit(int n)
{
    if (n == 0)
        return 0;

    return (n % 10 + sum_of_digit(n / 10));
}