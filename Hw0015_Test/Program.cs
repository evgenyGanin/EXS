//ТЕСТОВОЕ СОВМЕЩЕНИЕ 2х ЗАДАЧ

Console.Clear();

Random R = new Random();
int NumR = R.Next(1, 1000);
System.Console.WriteLine($"Сгененированно число: {NumR}");
string NumT = NumR.ToString();
if (NumR > 1 && NumR < 100)
{
    System.Console.WriteLine("У данного числа нет третей цифры. Сгенерируйте другое число...");
    // System.Console.WriteLine($"Третья цифра числа {NumR} - {NumT[2]}");
}
else
{
    // System.Console.WriteLine("У данного числа нет третей цифры, введите другое...");
    System.Console.WriteLine($"Третья цифра числа {NumR} это {NumT[2]}");
}
// // -------------------------------------------------------
System.Console.WriteLine($"Введите цифру {NumT[2]}, чтобы проверить - рабочим ли будет день недели, равный значению {NumT[2]} ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 6)
{
    System.Console.WriteLine("Это день рабочий. Удачи!");
}
else if (day == 6 || day == 7)
{
    System.Console.WriteLine("Этот день рабочим явно не будет!");
}
else
{
    System.Console.WriteLine("Такого дня недели нет. Введите другое число");
}