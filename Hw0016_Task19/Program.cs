//Задача №19
//Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 - нет
// 12821 - да
// 23432 - да

// a - введенное число
// b - длина введенного числа
Console.Clear();
System.Console.WriteLine("Введите пятизначное число: ");

string a = Console.ReadLine();
int b = a.Length;
if (b == 5)
{
    if (a[0] == a[4] && a[1] == a[3])
    {
        System.Console.WriteLine($"Число {a} пятизначное; а так же является палиндром. То есть читается одинаково в любом направлении. От др.-греч. 'palin' - 'назад' и 'dromos' - 'бег, движение'.");
    }
    else
    {
        System.Console.WriteLine($"Введенное вами число {a} пятизначное, но не полиндром. Попробуйте ввести: 12321");
    }
}
else
{
    System.Console.WriteLine("Введенное вами число не пятизначное. Пятизначное это: 12345");
}