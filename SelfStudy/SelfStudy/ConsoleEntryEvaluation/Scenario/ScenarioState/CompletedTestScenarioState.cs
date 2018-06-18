using System;
using SelfStudy.ConsoleEntryEvaluation.Scenario.Base;

namespace SelfStudy.ConsoleEntryEvaluation.Scenario.ScenarioState
{
    public class CompletedTestScenarioState : ITestScenarioState
    {
        public void MarkComplete(ITestScenarioStateContext context)
        {
            Console.WriteLine("This scenario has already been completed.");
        }

        public string GetStatusMessage(ITestScenarioStateContext context)
        {
            return $"{context.ScenarioName} is complete.";
        }

        public bool IsComplete => true;
    }
}