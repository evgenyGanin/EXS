﻿// // ЗАДАЧА 8: Напишите программу, которая на вход принимает число (N),
// // а на выходе показывает все четные числа от 1 до N.
// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8
Console.Clear();
Console.Write("Введите любое число: ");//Запрос числа
int N = Convert.ToInt32(Console.ReadLine());//Ввод числа
Console.Write($"Все четные числа от 1 до {N}: ");
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    Console.Write(i + " ");
}
