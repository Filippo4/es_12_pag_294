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
            int[] grandezza = {1000,2000,3000,4000,5000,6000,7000,8000,9000,10000};
            using (StreamWriter sw = new StreamWriter("file.csv", false, Encoding.UTF8))
            {
                sw.WriteLine("Algoritmo;Dimensione;Tempo");
                foreach (int dim in grandezza)
                {         
                    int[] array = new int[dim];
                    Random r = new Random();
                    for (int x = 0; x < dim; x++)
                    {
                        array[x] = r.Next(0, 100);
                    }
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    BubbleSort.sort(array);
                    s.Stop();
                    long temp = s.ElapsedMilliseconds;
                    sw.WriteLine($"BubbleSort;{dim};{temp}");

                    for (int x = 0; x < dim; x++)
                    {
                        array[x] = 0;
                        array[x] = r.Next(0, 100);
                    }
                    s.Start();
                    InsertSort.Sort(array);
                    s.Stop();
                    temp = s.ElapsedMilliseconds;
                    sw.WriteLine($"InsertionSort;{dim};{temp}");

                    for (int x = 0; x < dim; x++)
                    {
                        array[x] = 0;
                        array[x] = r.Next(0, 100);
                    }
                    s.Start();
                    InsertSort.Sort(array);
                    s.Stop();
                    temp = s.ElapsedMilliseconds;
                    sw.WriteLine($"SelectionSort;{dim};{temp}");

                    for (int x = 0; x < dim; x++)
                    {
                        array[x] = 0;
                        array[x] = r.Next(0, 100);
                    }
                    s.Start();
                    Array.Sort(array);
                    s.Stop();
                    temp = s.ElapsedMilliseconds;
                    sw.WriteLine($"ArraySort;{dim};{temp}");
                }
                sw.Flush();
            }
        }
    }
}
