using SelfStudy.ConsoleEntryEvaluation.Scenario.Base;

namespace SelfStudy.ConsoleEntryEvaluation.Scenario.ScenarioState
{
    public class IncompleteTestScenarioState : ITestScenarioState
    {
        public void MarkComplete(ITestScenarioStateContext context)
        {
            ITestScenarioState completedState = new CompletedTestScenarioState();
            context.SetState(completedState);
        }

        public string GetStatusMessage(ITestScenarioStateContext context)
        {
            return $"{context.ScenarioName} is not yet complete.";
        }

        public bool IsComplete => false;
    }
}