using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems1_20
{
    public static class Problem1_MultiplesOf3And5
    {
        public static int MultiplesOf3And5()
        {
            int total = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 ==0))
                {
                    total += i;
                }
            }
            return total;
        }
    }
}
