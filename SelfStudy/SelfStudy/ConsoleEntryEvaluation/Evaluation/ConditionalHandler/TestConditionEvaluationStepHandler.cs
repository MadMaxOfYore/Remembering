using SelfStudy.ConsoleEntryEvaluation.Condition;
using SelfStudy.ConsoleEntryEvaluation.Scenario;

namespace SelfStudy.ConsoleEntryEvaluation.Evaluation.ConditionalHandler
{
    public class TestConditionEvaluationStepHandler : ConditionalEvaluationStepHandler
    {
        private readonly TestScenario testScenario;

        public TestConditionEvaluationStepHandler(ITestCondition testCondition, TestScenario testScenario) : base(testCondition)
        {
            this.testScenario = testScenario;
        }

        protected override void ExecuteStep(EntryEvaluationContext evaluationContext)
        {
            testScenario.Complete();
        }
    }
}