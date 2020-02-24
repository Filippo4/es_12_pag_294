using ordinamento;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grandezza = {1000,2000,3000,4000,5000,6000,7000,8000,9000,10000,30000,50000,100000,150000,200000,};
            using (StreamWriter sw = new StreamWriter("file.csv", false, Encoding.UTF8))
            {
                sw.WriteLine("Algoritmo;Dimensione;Tempo");
                foreach (int dim in grandezza)
                {
                    Console.WriteLine(dim);
                    int[] array = new int[dim];
                    Random r = new Random();
                    for (int x = 0; x < dim; x++)
                    {
                        array[x] = r.Next(0, 100);
                    }
                    Stopwatch s = new Stopwatch();
                    s.Restart();
                    BubbleSort.sort(Copia(array));
                    s.Stop();
                    long temp = s.ElapsedMilliseconds;
                    sw.WriteLine($"BubbleSort;{dim};{temp}");

                    s.Restart();
                    InsertSort.Sort(Copia(array));
                    s.Stop();
                    temp = s.ElapsedMilliseconds;
                    sw.WriteLine($"InsertionSort;{dim};{temp}");

                    s.Restart();
                    InsertSort.Sort(Copia(array));
                    s.Stop();
                    temp = s.ElapsedMilliseconds;
                    sw.WriteLine($"SelectionSort;{dim};{temp}");

                  
                    s.Restart();
                    Array.Sort(Copia(array));
                    s.Stop();
                    temp = s.ElapsedMilliseconds;
                    sw.WriteLine($"ArraySort;{dim};{temp}");

                    s.Restart();
                    MergeSort.Sort(Copia(array));
                    s.Stop();
                    temp = s.ElapsedMilliseconds;
                    sw.WriteLine($"MergeSort;{dim};{temp}");
                }
                sw.Flush();
            }
            
        }
        public static int[] Copia(int[]array)
            {
            int[] array2 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            return array2;
        }
    }
}
