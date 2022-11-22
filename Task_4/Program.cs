// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 0;

while (num2 <= num1)
{
    Console.Write($"{num2} ");
    num2 = num2 + 2;
}