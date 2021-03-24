using System;

namespace CalculatorLibrary
{
    /// <summary>
    /// Custom Exception class to report on exceptions occuring in calculator methods
    /// </summary>
    public class CalculatorException : Exception
    {
        public CalculatorException()
        {
        }

        public CalculatorException(string message)
        : base(message)
        {
        }

        public CalculatorException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
