using CalculatorDatabase.Entities;
using CalculatorLibrary.Interfaces;
using System;
using System.Collections.Generic;

namespace CalculatorLibraryTests.Mocks
{
    public class MockDebugReporter : IDebugReport
    {
        public List<String> ReportedMessages = new List<string>();
        public List<CalcEntityBase> SavedEntities = new List<CalcEntityBase>();

        public void ReportResult(string message)
        {
            ReportedMessages.Add(message);
        }

        public void WriteToDatabase<T>(T entity) where T : CalcEntityBase
        {
            SavedEntities.Add(entity);
        }
    }
}
