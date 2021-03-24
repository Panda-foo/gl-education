using CalculatorDatabase.Entities;
using CalculatorLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorLibrary
{
    public class SimpleCalculator : ISimpleCalculator
    {
        public IDebugReport DebugReportResult;

        public SimpleCalculator(IDebugReport debugReportResult)
        {
            DebugReportResult = debugReportResult;
        }

        public int Add(int start, int amount)
        {
            int result;

            checked
            {
                result = start + amount;
                string message = $"Calculator called Add method. Start: {start}, Amount: {amount}, Result: {result}.";

                DebugReportResult.ReportResult(message);
                DebugReportResult.WriteToDatabase(new AdditionResult { Start = start, Amount = amount, Result = result, Message = message });
            }

            return result;
        }

        public float Divide(int start, int by)
        {
            // Not checking for overflow as inputs are constrained to ints, 
            // so shouldn't overflow a floats range of values.
            float result =  (float)start / (float)by;
            string message = $"Calculator called Divide method. Start: {start}, By: {by}, Result: {result}.";

            DebugReportResult.ReportResult(message);
            DebugReportResult.WriteToDatabase(new DivisionResult { Start = start, By = by, Result = result, Message = message });

            return result;
        }

        public int Multiply(int start, int by)
        {
            int result;

            checked
            {
                result = start * by;
                string message = $"Calculator called Multiply method. Start: {start}, By: {by}, Result: {result}.";

                DebugReportResult.ReportResult(message);
                DebugReportResult.WriteToDatabase(new MultiplicationResult { Start = start, By = by, Result = result, Message = message });
            }

            return result;
        }

        public int Subtract(int start, int amount)
        {
            int result;

            checked
            {
                result = start - amount;
                string message = $"Calculator called Subtract method. Start: {start}, Amount: {amount}, Result: {result}.";

                DebugReportResult.ReportResult(message);
                DebugReportResult.WriteToDatabase(new SubtractionResult { Start = start, Amount = amount, Result = result, Message = message });
            }

            return result;         
        }

        public int GetPrimeNumber(int index)
        {
            if (index <= 0)
                throw new CalculatorException("Chosen prime number index must be > 0.");

            // 2 is the first prime number, so add to start.
            List<int> primes = new List<int>
            {
                2
            };

            // Now need to define a method for generating prime numbers,
            // We can stop when we reach the index count,
            // We can ignore even numbers as they're divisible by 2,
            // We can check up to the square root of the number for factors,
            // We can use prime numbers as factors to check as non-prime numbers have factors of primes. e.g. if 4 is factor so is 2.
            int potentialPrime = 3;

            while (primes.Count < index)
            {
                // Lets determine potentialPrime is prime until a factor is found.
                bool isPrime = true;
                int factorLimit = (int)Math.Sqrt(potentialPrime);

                for (int i = 0; i < primes.Count; i++)
                {
                    if (primes[i] > factorLimit)
                        break;

                    // If no remainder, then number is factor so potential is not a prime.
                    if (potentialPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    primes.Add(potentialPrime);

                potentialPrime += 2;
            }

            int result = primes.ElementAt(index - 1);
            string message = $"Calculator called Get Prime method. Prime at Position: {index}, Result: {result}.";

            DebugReportResult.ReportResult(message);
            DebugReportResult.WriteToDatabase(new PrimeResult { Index = index, Result = result, Message = message });

            return result;
        }
    }
}
