namespace SelfStudy.ConsoleEntryEvaluation.Scenario.Base
{
    public interface ITestScenarioState
    {
        void MarkComplete(ITestScenarioStateContext context);
        string GetStatusMessage(ITestScenarioStateContext context);
        bool IsComplete { get; }
    }
}