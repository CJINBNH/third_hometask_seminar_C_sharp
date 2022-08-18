// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N (3 -> 1, 8, 27)

Console.Clear();
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] result = new int[10];
int count = 1;
while (count <= N)
{
    for (int i = 0; i < N; i++)
    {
        int cube = Convert.ToInt32(Math.Pow(count, 3));
        result[i] = cube;
        count++;
        Console.WriteLine(result[i]);
    }
}