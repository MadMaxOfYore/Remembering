using System;
using SelfStudy.ConsoleEntryEvaluation.Evaluation.Base;

namespace SelfStudy.ConsoleEntryEvaluation.Evaluation
{
    public class UnhandledTestConditionStepHandler : ConsoleEntryEvaluationStepHandler
    {
        public override void HandleEntryEvaluation(EntryEvaluationContext evaluationContext)
        {
            Console.WriteLine($"{evaluationContext.CommandLineEntry} is not a recognized command.");
        }
    }
}