// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int s = 4;
int [] a = new int [s];
int nechetSum = 0;

Random random = new Random ();

for (int i=0; i<s; i++)
{
Console.WriteLine(a[i] = random.Next(-100,100));
    if (a[i] % 2 != 0)

nechetSum += a[i];
}
 
{
 Console.WriteLine("Сумма нечётных чисел в массиве: {0}", nechetSum);
}