using SelfStudy.ConsoleEntryEvaluation.Condition;

namespace SelfStudy.ConsoleEntryEvaluation.Evaluation.ConditionalHandler
{
    public class CurrentStatusProviderHandler : ConditionalEvaluationStepHandler
    {
        public CurrentStatusProviderHandler(ITestCondition condition) : base(condition)
        {
        }

        protected override void ExecuteStep(EntryEvaluationContext evaluationContext)
        {
            evaluationContext.TestScenarioManager.PrintCurrentStatusToConsole();
        }
    }
}