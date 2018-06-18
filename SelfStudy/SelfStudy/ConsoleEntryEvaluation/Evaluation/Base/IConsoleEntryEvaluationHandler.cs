namespace SelfStudy.ConsoleEntryEvaluation.Evaluation.Base
{
    public interface IConsoleEntryEvaluationHandler
    {
        void SetSuccessor(IConsoleEntryEvaluationHandler successor);
        void HandleEntryEvaluation(EntryEvaluationContext evaluationContext);
    }
}