// Задача 34: 
//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int s = 5;
int [] a = new int [s];
int chetSum = 0;

Random random = new Random ();

for (int i=0; i<s; i++)
{
Console.WriteLine(a[i] = random.Next(100,999));
    if (a[i] % 2 == 0)

chetSum += a[i];
}

 
{
 Console.Write("Сумма чётных чисел в массиве: {0}", chetSum);
    }