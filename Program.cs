// Домашняя работа 3. Базовые алгоритмы. Продолжение.

// Задача 1(19)
// Напишите пр-му, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Palindrom(string number)
{
    if(number[0] == number[4] || number[1] == number[3])
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Input number: ");
string number = Convert.ToString(Console.ReadLine());
bool result = Palindrom(number);
Console.WriteLine(result);
*/
// Задача 2(21)
// Напишите пр-му, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDistance (double xA, double yA, double zA, double xB, double yB, double zB)
{
    double distance = Math.Sqrt(Math.Pow(xA - xB ,2) + Math.Pow(yA - yB ,2) + Math.Pow(zA - zB ,2));
    return distance;
}
Console.WriteLine("Input first x: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input first y: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input first z: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input second x: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input second y: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input second z: ");
double zB = Convert.ToDouble(Console.ReadLine());

double dist = Math.Round(FindDistance(xA, yA, zA, xB, yB, zB));
Console.WriteLine($"Distance = {dist}");
*/

// Задача 3(23)
// Напишите пр-му, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
/*
void TabCube (int N)
{
    int result = 1;
    while (result <= N)
    {
        Console.Write(Math.Pow(result, 3) + " ");
        result++;
    }
}
Console.WriteLine($"Input N: ");
int N = Convert.ToInt32(Console.ReadLine());

TabCube(N);
*/