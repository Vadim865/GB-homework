// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите кординаты точек А(x1,y1,z1) и В(x2,y2,z2) начиная с x1");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите z1");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите x2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y2");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите z2");
double z2 = Convert.ToDouble(Console.ReadLine());

double n = Math.Sqrt(Math.Pow ((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));

Console.WriteLine($"Расстояние между точек А и В {n}");
