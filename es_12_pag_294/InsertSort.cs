using System;
using System.Collections.Generic;
using System.Text;

namespace ordinamento
{
    public class InsertSort
    {
        public static void shiftR (int buco,int[] array)
        {
            int x;
            for (x = array.Length - 2; x >= buco; x--)
            {
                array[x + 1] = array[x];
            }
        }
        public static void Sort(int[] array )
        {
            int dove;
            int x;
            int nuovo;
          for (x = 0; x < array.Length; x++)
          { 
          }
        }
    }
}
