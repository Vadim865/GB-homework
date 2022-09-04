// Задача 38: 
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] a = {3, 7, 22, 2, 78};
double diff = 0;
double  max = 0;
double  min = 2;  

for (int i = 0; i < a.Length; i++)
Console.WriteLine(a[i]  );

for (int i = 0; i < a.Length; i++)
{ 
   if (a[i] > max)  max = a[i];
   if (a[i] < min)  min = a[i];
}

Console.WriteLine("число max " +  max);
Console.WriteLine("число min " +  min);

 diff = (max - min);

{
 Console.WriteLine("разницу между максимальным и минимальным {0}", diff);
}
