using SelfStudy.ConsoleEntryEvaluation.Scenario;

namespace SelfStudy.ConsoleEntryEvaluation.Evaluation
{
    public class EntryEvaluationContext
    {
        public string CommandLineEntry { get; }
        public TestScenarioManager TestScenarioManager { get;}

        public EntryEvaluationContext(string commandLineEntry, TestScenarioManager testScenarioManager)
        {
            CommandLineEntry = commandLineEntry;
            TestScenarioManager = testScenarioManager;
        }
    }
}