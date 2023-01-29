// -----ДОМАШНЕЕ ЗАДАНИЕ-----------------------------------------
// Задача №21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстоние между ними в 3D пространстве
// Проверка:
// А (3,6,8);В(2,1,-7),->15.84
// А (7,-5,0);В(1,-1,9),->11.53
//Точка А = (x1,y1,z1)
//Точка В = (х2,у2,z2)
//кв.корень из (x2-x1)2+(y2-y1)2+(z2-z1)2
//Ох уж этот Пифагор!!!

// Console.Clear();

// double[] dotA = new double[3];
// double[] dotB = new double[3];
// System.Console.WriteLine("Введите x1 для A: ");//x1+
// dotA[0] = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите y1 для A: ");//y1
// dotA[1] = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите z1 для A: ");//z1
// dotA[2] = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите x1 для B: ");//x2+
// dotB[0] = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите y1 для B: ");//y2
// dotB[1] = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите z1 для B: ");//z2
// dotB[2] = Convert.ToInt32(Console.ReadLine());

// double distance = Math.Sqrt((Math.Pow(dotB[0] - dotA[0], 2)) + (Math.Pow(dotB[1] - dotA[1], 2))+ (Math.Pow(dotB[2] - dotA[2], 2)));
// System.Console.WriteLine(distance);
// ----------ЗАДАЧА 3-------------------------------------------------------- 
System.Console.WriteLine("Введите любое число:");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Вы ввели число: {a}");
for (int i = 1; i <= a; i++)
{
    System.Console.WriteLine($"Куб числа {i} = {i}x{i}x{i} = {i*i*i}, ");
}

// double[] coordsA = new double[3];
// double[] coordsB = new double[3];
// System.Console.WriteLine("Введите координату Х1 точки А: ");
// coordsA[0] = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y1 точки А: ");
// coordsA[1] = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координатy Z1 точки А: ");
// coordsA[2] = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите координату X2 точки B: ");
// coordsA[0] = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y2 точки B: ");
// coordsA[0] = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату Z2 точки B: ");
// coordsA[0] = Convert.ToInt32(Console.ReadLine());

// double S = Math.Sqrt(Math.Pow(coordsA[1] - coordsB[1], 2) + Math.Pow(coordsA[0] - coordsB[0], 2) + Math.Pow(coordsA[0] = coordsB[0], 2));

// System.Console.WriteLine(S);


// -------------------Задача на рандом массив и скобки-----------------------------------
// Console.Clear();
// // int[] array = new int[8];||задает численность массива
// int[] array = { 34234, 234234, 3423, 34, 53, 63 };//вводит определенные числа массива
// Random rand = new Random();
// System.Console.WriteLine("[" + string.Join(", ", array) + "]");//вывод значений массива

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(0, 100);//присвоение случайных значений индексам массива
//     // System.Console.Write(array[i] + " ");
// }
// System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// // System.Console.WriteLine(array);||выводит тип форматирования массива


// -------------------Задача на координаты на оси-----------------------------------

// Console.Clear();

// System.Console.WriteLine("Введите номер четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string[] array = { "x>0,y>0", "x<0,y<0", "x>0,y<0", "x<0,y>0", "введено некорректное число" };
// switch (num)
// {
//     case 1:
//         System.Console.WriteLine(array[0]);
//         break;
//     case 2:
//         System.Console.WriteLine(array[3]);
//         break;
//     case 3:
//         System.Console.WriteLine(array[1]);
//         break;
//     case 4:
//         System.Console.WriteLine(array[2]);
//         break;
//     default:
//         System.Console.WriteLine(array[4]);
//         break;

// }




// // -------------------Точки координат на оси-----------------------------------
// int[] massive = new int[2];
// System.Console.WriteLine("Введите Х: ");
// massive[0] = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите Y: ");
// massive[1] = Convert.ToInt32(Console.ReadLine());

// if (massive[0] > 0 && massive[1] > 0)
// {
//     System.Console.WriteLine("Номер четверти = 1");
// }
// else if (massive[0] < 0 && massive[1] > 0)
// {
//     System.Console.WriteLine("Номер четверти = 2");
// }
// else if (massive[0] < 0 && massive[1] < 0)
// {
//     System.Console.WriteLine("Номер четверти = 3");
// }
// else if (massive[0] > 0 && massive[1] < 0)
// {
//     System.Console.WriteLine("Номер четверти = 4");
// }
// else
// {
//     System.Console.WriteLine("Точка вне координат");
// }
// ----------------------------Задачи--------------------------------------
// int x = 7;
// int y = 2;

// if (x > y)//?
// {
//     System.Console.WriteLine(x + y);
// }
// else//:
// {
//     System.Console.WriteLine(x * y);
// }
// ------------------------Тернарные операторы------------------------------------------
// int z = x > y ? (x + y) : (x * y);
// System.Console.WriteLine(z);
// ----------------------------Массивы--------------------------------------
// Console.Clear();
// int[] array = { 1, 2, 3, 4, 5 };//Массив
// array[3] = 12;//Запись значения в массив
// System.Console.WriteLine(array[2]);//Вывод значения из элемента массива
// -----------------------------MAX--------------------------------------------------
// Console.Clear();
// int Max(int ar1, int ar2, int ar3)
// {
//     int res = ar1;
//     if (ar2 > res) res = ar2;
//     if (ar3 > res) res = ar3;
//     return res;
// }

// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };//Массив

// int R = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );
// System.Console.WriteLine(R);
// // -------------------------ARRAY--------------------------------------------------
// Console.Clear();
// int[] mass = { 1, 12, 31, 4, 15, 16, 17, 18 };//инициация массива

// int num = mass.Length;//н элементов
// int find = 17;//искомый элемент

// int ind = 0;//установка счетчика на ноль

// while (ind < num)//пока индекс меньше нум
// {
//     if (mass[ind] == find)
//     {
//         System.Console.WriteLine(ind);
//         break;
//     }
//     ind++;
// }
// --------------------------VOID-------------------------------------------- -
// void fillMassiv(int[] box)//наименование метода+название метода ("контент")
// {
//     int dlina = box.Length;
//     int ind = 0;
//     while (ind < dlina)
//     {
//         box[ind] = new Random().Next(1, 10);
//         ind++;
//     }
// }
// void printMassiv(int[] openbox)
// {
//     int kolvo = openbox.Length;
//     int posizia = 0;
//     while (posizia < kolvo)
//     {
//         System.Console.WriteLine(openbox[posizia]);
//         posizia++;
//     }
// }
// int[] massiv = new int[10];

// fillMassiv(massiv);
// printMassiv(massiv);
// ?? Балуюсь:-------------------------------------------------------------
// Console.Clear();
// System.Console.Write("Введите три числа (1): ");
// int ar1 = Convert.ToInt32(System.Console.ReadLine());
// System.Console.Write("Введите три числа (2): ");
// int ar2 = Convert.ToInt32(System.Console.ReadLine());
// System.Console.Write("Введите три числа (3): ");
// int ar3 = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine($"{ar1} + {ar2} + {ar3} = {ar1 + ar2 + ar3}");
