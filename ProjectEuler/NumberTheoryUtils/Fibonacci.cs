using LinAlg = MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProjectEuler.NumberTheoryUtils
{
    public static class Fibonacci
    {
        public static List<int> GenerateFibonacciNumbersViaMatrixExponentiation(int n)
        {
            LinAlg.Matrix<int> generator 
                = LinAlg.CreateMatrix.DenseOfArray<int>(new int[,] { { 1, 1 }, 
                                                                     { 1, 0 } });
            LinAlg.Matrix<int> currentFibonacciMatrix
                = generator;

            List<int> fibonacciNumbers = new List<int>() {0, 1, 1};

            // since matrix method produces F(n+2) we only go up to n - 2
            for (int i = 1; i <= n - 2; i++)
            {
                currentFibonacciMatrix = currentFibonacciMatrix.Multiply(generator);
                fibonacciNumbers.Add(currentFibonacciMatrix[0, 0]);
            }

            return fibonacciNumbers;
        }
    }
}
