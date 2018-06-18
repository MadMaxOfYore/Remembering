namespace SelfStudy.ConsoleEntryEvaluation.Scenario.ScenarioBuilder
{
    public class TestScenarioDirector
    {
        public TestScenarioManager ConstructManager()
        {
            TestScenarioManagerBuilder builder = new TestScenarioManagerBuilder();

            return builder
                .WithScenario("Test Scenario 1").WithGenericCondition(entry => entry == "1")
                .WithScenario("Test Scenario 2").WithGenericCondition(entry => entry == "2")
                .WithScenario("Test Scenario 3").WithGenericCondition(entry => entry == "3")
                .WithStatusProviderHandler().WithGenericCondition(entry => entry == "4")
                .Build();
        }
    }
}