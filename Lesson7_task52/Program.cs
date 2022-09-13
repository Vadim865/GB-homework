// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());

//static Random rnd = new Random();
//static void Main(string[] args)
//int[,] array = new int[a, b];

 
//for (int i = 0; i < array.GetLength(0); i++)


//for (int i=0;i<array;i++){
  // for (int j=0;j<array;j++) {
    //   a[i,j]=i*j+1;
      // Console.Write(a[i,j]+ " ");
   //}
   //Console.Write(a[i,j]+ " ");
//}
using System.Linq;
 
namespace ConsoleApplication1{

    class Program
    {
        const int N = 5;
        const int M = 6; 
 
        static Random rnd = new Random();
 
        static void Main(string[] args)
        {
            int[,] matrix = new int[N, M]; 
 
            
            for (int i = 0; i < N; i++)
                matrix.SetRow(Enumerable.Range(0, M).Select(x => x = rnd.Next(-10, 20)).ToArray(), i);
            
            
            for (int i = 0; i < N; i++)
                Console.WriteLine(string.Join("\t", matrix.GetRow(i)));
 
            
            var result = Enumerable.Range(0, M).Select(x => matrix.GetColumn(x).Sum() / M);
 
            
            Console.WriteLine();
            Console.WriteLine(string.Join("\t", result));
 
            Console.ReadKey(true);
        }
        }    }