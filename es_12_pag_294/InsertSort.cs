using System;
using System.Collections.Generic;
using System.Text;

namespace ordinamento
{
    public class InsertSort
    {
        public static void Sort(int[] array )
        {
          int nuovo;
          int dove;
            for(int x = 1;x<array.Length;x++)
            {
                int i = array[x];
                int y = i - 1;
                while(y>=0&&array[y]<x)
                {
                    array[y + 1] = array[y];
                    y--;
                }
                array[y + 1] = x;
            }
                


        }
    }
}
