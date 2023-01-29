// Задача №21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстоние между ними в 3D пространстве
// Проверка:
// А (3,6,8);В(2,1,-7),->15.84
// А (7,-5,0);В(1,-1,9),->11.53
//Точка А = (x1,y1,z1)
//Точка В = (х2,у2,z2)
//кв.корень из (x2-x1)2+(y2-y1)2+(z2-z1)2
//Ох уж этот Пифагор!!!

Console.Clear();

double[] dotA = new double[3];
double[] dotB = new double[3];
System.Console.WriteLine("Введите x1 для A: ");//x1+
dotA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите y1 для A: ");//y1
dotA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите z1 для A: ");//z1
dotA[2] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите x1 для B: ");//x2+
dotB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите y1 для B: ");//y2
dotB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите z1 для B: ");//z2
dotB[2] = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt((Math.Pow(dotB[0] - dotA[0], 2)) + (Math.Pow(dotB[1] - dotA[1], 2))+ (Math.Pow(dotB[2] - dotA[2], 2)));
System.Console.WriteLine(distance);
