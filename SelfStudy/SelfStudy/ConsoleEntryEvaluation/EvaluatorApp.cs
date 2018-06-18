using System;
using SelfStudy.ConsoleEntryEvaluation.Scenario;
using SelfStudy.ConsoleEntryEvaluation.Scenario.ScenarioBuilder;

namespace SelfStudy.ConsoleEntryEvaluation
{
    public class EvaluatorApp
    {
        private readonly TestScenarioDirector scenarioDirector;

        public EvaluatorApp(TestScenarioDirector scenarioDirector)
        {
            this.scenarioDirector = scenarioDirector;
        }

        public void Run()
        {
            Console.WriteLine("Hello. Please tell me your name.");
            string userName = Console.ReadLine();

            Console.WriteLine($"Greetings, {userName}. Please begin testing your test cases.");
            TestScenarioManager manager = scenarioDirector.ConstructManager();

            while (!manager.ScenarioIsComplete())
            {
                string commandLineEntry = Console.ReadLine();
                manager.EvaluateCommandLineEntry(commandLineEntry);
            }

            Console.WriteLine("All scenarios have been satisfied. Press any key to close the command prompt.");
            Console.ReadLine();
        }
    }
}