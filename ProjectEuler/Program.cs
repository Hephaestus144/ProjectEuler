using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler.Problems1_20;
using ProjectEuler.ConsoleUtils;



namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> x = new List<int> { 1, 2, 3, 4, 5 };
            int[,] y = { { 121, 2, 3324, 4 }, { 5, 642, 7, 84242 } };
            string[,] z = { { "Nietzsche", "Picasso", "Descartes"},
                            { "Feynman", "Maxwell", "Laplace" },
                            { "Riemann", "Gauss", "Schopenhauer" } };
            ArrayAndListUtils.WriteListToConsole(x);
            ArrayAndListUtils.Write2DArrayToConsole(y);
            ArrayAndListUtils.Write2DArrayToConsole(z);
        }
    }
}
