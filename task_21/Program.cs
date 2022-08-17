// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
//(A (3,6,8); B (2,1,-7), -> 15.84)

// Формула вычисления расстояния между двумя точками в пространстве
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
Console.WriteLine("Введите координату x1 первой точки: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1 первой точки: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z1 первой точки: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x2 первой точки: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2 первой точки: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2 первой точки: ");
double z2 = Convert.ToInt32(Console.ReadLine());

// double length = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));

double length = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow( y2 - y1, 2) + Math.Pow( z2 - z1, 2));
Console.WriteLine(length);