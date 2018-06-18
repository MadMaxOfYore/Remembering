namespace SelfStudy.ConsoleEntryEvaluation.Evaluation.Base
{
    public abstract class ConsoleEntryEvaluationStepHandler : IConsoleEntryEvaluationHandler
    {
        private IConsoleEntryEvaluationHandler successor;

        public void SetSuccessor(IConsoleEntryEvaluationHandler nextSuccessor)
        {
            this.successor = nextSuccessor;
        }

        protected void ExecuteNextHandler(EntryEvaluationContext evaluationContext)
        {
            this.successor?.HandleEntryEvaluation(evaluationContext);
        }

        public abstract void HandleEntryEvaluation(EntryEvaluationContext evaluationContext);
    }
}