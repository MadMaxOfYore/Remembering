namespace SelfStudy.ConsoleEntryEvaluation.Scenario.Base
{
    public interface ITestScenarioStateContext
    {
        void SetState(ITestScenarioState nextState);
        string ScenarioName { get; }
    }
}