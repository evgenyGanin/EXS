Console.Clear();
// //Сумма 2х чисел
int num1 = 37;
int num2 = 45;
System.Console.WriteLine(num1 + num2);

//Сумма 2х чисел через промежуточную переменную
int num1 = 3;
int num2 = 52;
int result = num1 + num2; //дополнительный промежуточный контейнер
System.Console.WriteLine(result);

//Сумма 2х СЛУЧАЙНЫХ ЧИСЕЛ через промежуточную переменную
int num1 = new Random().Next(1, 10);
Console.WriteLine(num1);
int num2 = new Random().Next(1, 10);
Console.WriteLine(num2);
int result = num1 + num2; //дополнительный промежуточный контейнер
Console.WriteLine(result);


//Test
int num1 = new Random().Next(1, 10);
Console.WriteLine(num1);
int num2 = new Random().Next(1, 10);
Console.WriteLine(num2);
int num3 = new Random().Next(1, 10);
Console.WriteLine(num3);
int result = num2;
// int result = (num1 + num2 + num3) - (num1 + num3); //дополнительный промежуточный контейнер
Console.WriteLine(result);
