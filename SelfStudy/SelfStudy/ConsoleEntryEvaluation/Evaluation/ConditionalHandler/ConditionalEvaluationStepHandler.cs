using SelfStudy.ConsoleEntryEvaluation.Condition;
using SelfStudy.ConsoleEntryEvaluation.Evaluation.Base;

namespace SelfStudy.ConsoleEntryEvaluation.Evaluation.ConditionalHandler
{
    public abstract class ConditionalEvaluationStepHandler : ConsoleEntryEvaluationStepHandler
    {
        private readonly ITestCondition condition;

        protected ConditionalEvaluationStepHandler(ITestCondition condition)
        {
            this.condition = condition;
        }

        public override void HandleEntryEvaluation(EntryEvaluationContext evaluationContext)
        {
            if (condition.IsMetByEntry(evaluationContext.CommandLineEntry))
            {
                ExecuteStep(evaluationContext);
                return;
            }

            ExecuteNextHandler(evaluationContext);
        }

        protected abstract void ExecuteStep(EntryEvaluationContext evaluationContext);
    }
}