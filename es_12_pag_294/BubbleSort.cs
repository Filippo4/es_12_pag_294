using System;

namespace ordinamento
{
    public class BubbleSort
    {
        public static void sort(int[] array)
        {
            
            int temp;
            bool scambi = false;
            do
            {
                scambi = false;
                for (int y = 0; y < array.Length-1; y++)
                {
                    if (array[y] > array[y + 1])
                    {
                        temp = array[y];
                        array[y] = array[y + 1];
                        array[y + 1] = temp;
                        scambi = true;
                    }
                }
            } while (scambi == true);
        }
    }
}
