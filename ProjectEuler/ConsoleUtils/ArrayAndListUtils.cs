using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProjectEuler.ConsoleUtils
{
    public static class ArrayAndListUtils
    {
        public static void WriteListToConsole<T>(List<T> list)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                Console.Write("{0} ", list[i]);
            }
            Console.WriteLine();
        }



        public static void WriteArrayToConsole<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }



        // adjust for wider arrays
        public static void Write2DArrayToConsole<T>(T[,] array)
        {
            int[] columnWidths = GetWidthOfEachColumnOf2Darray(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    string blankSpace = new string(' ', columnWidths[j] - array[i, j].ToString().Length + 3);
                    if (typeof(T) == typeof(string))
                    {
                        Console.Write(array[i, j] + blankSpace);
                    }
                    else if (typeof(T) == typeof(int))
                    {
                        Console.Write(blankSpace + array[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
        


        private static int[] GetWidthOfEachColumnOf2Darray<T>(T[,] array)
        {
            int[] columnWidths = Enumerable.Repeat(0, array.GetLength(1)).ToArray();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    columnWidths[j] = (columnWidths[j] < array[i, j].ToString().Length) ?
                        array[i, j].ToString().Length : columnWidths[j];
                }
            }

            return columnWidths;
        }
    }
}
