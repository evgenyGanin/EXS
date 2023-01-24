// ЗАДАЧА № 10: 
// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру 
// этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
System.Console.WriteLine("Введите трехзначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num > 99 && Num < 1000 )//|| Num < -99 && Num > -1000)
{
    System.Console.WriteLine($"Верно! Число {Num} является трехзначным."); 
    string target = Num.ToString();
Console.WriteLine($"Второй цифрой трехзначного числа {Num} будет - {target[1]}");
}
else
{
    System.Console.WriteLine($"Не верно! Число {Num} не является трехзначным. Введите другое число!");
}
