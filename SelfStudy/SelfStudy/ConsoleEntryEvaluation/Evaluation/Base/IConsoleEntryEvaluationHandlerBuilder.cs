using System;
using SelfStudy.ConsoleEntryEvaluation.Scenario.ScenarioBuilder;

namespace SelfStudy.ConsoleEntryEvaluation.Evaluation.Base
{
    public interface IConsoleEntryEvaluationHandlerBuilder
    {
        TestScenarioManagerBuilder WithGenericCondition(Func<string, bool> evaluator);
        IConsoleEntryEvaluationHandler Build();
    }
}