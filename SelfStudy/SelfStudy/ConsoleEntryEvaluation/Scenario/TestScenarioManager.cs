using System;
using SelfStudy.ConsoleEntryEvaluation.Evaluation;
using SelfStudy.ConsoleEntryEvaluation.Evaluation.Base;
using SelfStudy.ConsoleEntryEvaluation.Scenario.Base;

namespace SelfStudy.ConsoleEntryEvaluation.Scenario
{
    public class TestScenarioManager : ITestScenarioManagerBuildContext
    {
        private IConsoleEntryEvaluationHandler evaluationHandler;
        private TestScenario rootTestScenario;

        void ITestScenarioManagerBuildContext.AppendTestScenario(TestScenario testScenario)
        {
            if (rootTestScenario == null)
            {
                rootTestScenario = testScenario;
                return;
            }

            AppendTestScenario(rootTestScenario, testScenario);
        }

        void ITestScenarioManagerBuildContext.InstallEvaluationHandler(IConsoleEntryEvaluationHandler evaluationHandler)
        {
            this.evaluationHandler = evaluationHandler;
        }

        public void EvaluateCommandLineEntry(string commandLineEntry)
        {
            EntryEvaluationContext evaluationContext = new EntryEvaluationContext(commandLineEntry, this);
            evaluationHandler.HandleEntryEvaluation(evaluationContext);
        }

        public void PrintCurrentStatusToConsole()
        {
            PrintScenarioStatusMessage(rootTestScenario);
        }

        private static void PrintScenarioStatusMessage(TestScenario testScenario)
        {
            Console.WriteLine(testScenario.GetCurrentStatusMessage());

            if (testScenario.NextScenario != null) PrintScenarioStatusMessage(testScenario.NextScenario);
        }

        private static void AppendTestScenario(TestScenario parentTestScenario, TestScenario testScenario)
        {
            if (parentTestScenario.NextScenario != null)
            {
                AppendTestScenario(parentTestScenario.NextScenario, testScenario);
                return;
            }

            parentTestScenario.NextScenario = testScenario;
        }

        public bool ScenarioIsComplete()
        {
            return ScenarioIsComplete(this.rootTestScenario);
        }

        private static bool ScenarioIsComplete(TestScenario scenario)
        {
            return scenario.NextScenario != null 
                ? scenario.IsComplete() && ScenarioIsComplete(scenario.NextScenario)
                : scenario.IsComplete();
        }
    }
}