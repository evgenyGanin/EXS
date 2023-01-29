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
    if (a[0]==a[4] && a[1]==a[3])
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
// Console.Clear();
// System.Console.WriteLine("Введите пятизначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a > 9999 && a < 100000)
// {
//     System.Console.WriteLine("+");
// }
// else
// {
//     System.Console.WriteLine("-");
// }
//Пытался сделать решение через int a = Convert.ToInt32(Console.ReadLine()), 
// и даже выстраивалась адекватная проверка на пятизначность. Но дальнейшее 
// решение не принимало переход на индексацию массивов.

// ------------------------------------------------------------
// string numFive = Console.ReadLine();
// int numArr = numFive.Length;
// if (numFive == 5)

// {
//     if (numFive[0]==numFive[4] && numFive[1]==numFive[3])
//     {
//         System.Console.WriteLine("yessssssssssss poly");
//     }
//     else
//     {
//         System.Console.WriteLine("nea");
//     }
// }
// else
// {
//     System.Console.WriteLine("no poly");
// }
    // if (numArr > 9999 && numArr < 100000)
    // {
    //     System.Console.WriteLine("+");
    // }
// System.Console.WriteLine("Введи число 12345: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     if (a > 9999 && a < 100000)
//     {
//         Console.WriteLine($"Число {a} пятизначное");
//     }
//     else
//     {
//         Console.WriteLine($"Число {a} НЕ пятизначное");
//     }

// switch(a)
// {
//     case 1:
//     System.Console.WriteLine(array[0]==array[4]);
//     break;
// }

// if (a[1]==a[5]&&a[2]==a[4])
// {
//     System.Console.WriteLine($"Введенное пятизначное число {a} - это полиндром");
// }
// else
// {
//     System.Console.WriteLine($"Введенное пятизначное число {a} не является полиндромом");
// }


























// Console.Clear();

// System.Console.WriteLine("Введите пятизначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a > 9999 && a < 100000)
// {
// System.Console.WriteLine($"Число {a} пятизначное");
// }
// else
// {
//     System.Console.WriteLine($"Число {a} не пятизначное");
// }