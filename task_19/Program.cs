// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом (12821 -> да)

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
string numberToString = number.ToString();
int stringLength = numberToString.Length;

if (stringLength == 5)
{
    if (numberToString[0] == numberToString[4] && numberToString[1] == numberToString[3])
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}
else
{
    Console.WriteLine("Число должно быть пятизначным");
}

//не получилось добавить цикл
// if (stringLength == 5)
//     int i = 0;    
//     while (numberToString[i] == numberToString[(stringLength-1)-i] && i < 3;)
//     {
//      i++
//     }
//      Console.WriteLine($"Число {number} является палиндромом");
// } 
// if (stringLength != 5)
// {
//     Console.WriteLine("Число должно быть пятизначным");
// }