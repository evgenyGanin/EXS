// Задача 15: 
// Напишите программу, которая принимает на вход 
// цифру, обозначающую день недели, и проверяет, является ли 
// этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
System.Console.WriteLine("Введи цифру, обозначающую день недели");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 6)
{
    System.Console.WriteLine("Ура, это рабочий день!");
}
else if (day == 6 || day == 7)
{
    System.Console.WriteLine("Увы, этот день выходной...");
}
else
{
    System.Console.WriteLine("Такого дня недели нет, введите другое число");
}