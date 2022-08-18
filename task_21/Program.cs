// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
//(A (3,6,8); B (2,1,-7), -> 15.84)

// Формула вычисления расстояния между двумя точками в пространстве
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
Console.Clear();
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

// double length = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow( y2 - y1, 2) + Math.Pow( z2 - z1, 2));
// Console.WriteLine(length);

// добавить в решение функцию

double distance = 0;
double Length(double x1, double y1, double z1, double x2, double y2, double z2)
{
    distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow( y2 - y1, 2) + Math.Pow( z2 - z1, 2));
    return distance;
}


distance = Length(x1, y1, z1, x2, y2, z2);
Console.WriteLine(distance);