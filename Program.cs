using System;

namespace CodeCoverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z = 0;

            if (x > 3 && y < 6 || z == 2)
            {
                ExecuteFunctionA();
            }
            else
            {
                ExecuteFunctionB();
            }
        }

        private static void ExecuteFunctionA()
        {

        }

        private static void ExecuteFunctionB()
        {

        }
    }
}