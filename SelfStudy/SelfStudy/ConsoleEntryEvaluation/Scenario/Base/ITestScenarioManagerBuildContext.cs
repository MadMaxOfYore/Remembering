using SelfStudy.ConsoleEntryEvaluation.Evaluation.Base;

namespace SelfStudy.ConsoleEntryEvaluation.Scenario.Base
{
    public interface ITestScenarioManagerBuildContext
    {
        void AppendTestScenario(TestScenario testScenario);
        void InstallEvaluationHandler(IConsoleEntryEvaluationHandler evaluationHandler);
    }
}