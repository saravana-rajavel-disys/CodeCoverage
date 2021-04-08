using CodeCoverage.Interfaces;
using System;

namespace CodeCoverage.Classes
{
    public class Addition : IAddition
    {
        public int AddTwoIntegers(int numberOne, int numberTwo)
        {
            checked
            {
                try
                {
                    return numberOne + numberTwo;
                }
                catch (OverflowException)
                {
                    throw;
                }
            }
        }
    }
}
