//Задача №23
//Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
Console.Clear();
System.Console.WriteLine("Введите любое число:");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Вы ввели число: {a}");
for (int i = 1; i <= a; i++)
{
    System.Console.WriteLine($"Куб числа {i} = {i}x{i}x{i} = {i*i*i}, ");
}
