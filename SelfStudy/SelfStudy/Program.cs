using SelfStudy.ConsoleEntryEvaluation;
using SelfStudy.ConsoleEntryEvaluation.Scenario.ScenarioBuilder;

namespace SelfStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            TestScenarioDirector scenarioDirector = new TestScenarioDirector();
            EvaluatorApp app = new EvaluatorApp(scenarioDirector);
            app.Run();
        }
    }
}
