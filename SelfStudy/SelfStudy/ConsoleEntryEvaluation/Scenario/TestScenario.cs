using SelfStudy.ConsoleEntryEvaluation.Scenario.Base;
using SelfStudy.ConsoleEntryEvaluation.Scenario.ScenarioState;

namespace SelfStudy.ConsoleEntryEvaluation.Scenario
{
    public class TestScenario : ITestScenarioStateContext
    {
        private ITestScenarioState state;

        public string ScenarioName { get; }
        public TestScenario NextScenario { get; set; }

        public TestScenario(string scenarioName)
        {
            this.ScenarioName = scenarioName;
            this.state = new IncompleteTestScenarioState();
        }

        public void Complete()
        {
            state.MarkComplete(this);
        }

        public string GetCurrentStatusMessage()
        {
            return state.GetStatusMessage(this);
        }

        void ITestScenarioStateContext.SetState(ITestScenarioState nextState)
        {
            state = nextState;
        }

        public bool IsComplete()
        {
            return state.IsComplete;
        }
    }
}