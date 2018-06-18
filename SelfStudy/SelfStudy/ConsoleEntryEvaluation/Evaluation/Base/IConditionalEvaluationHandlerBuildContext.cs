using System;
using SelfStudy.ConsoleEntryEvaluation.Scenario.ScenarioBuilder;

namespace SelfStudy.ConsoleEntryEvaluation.Evaluation.Base
{
    public interface IConditionalEvaluationHandlerBuildContext
    {
        TestScenarioManagerBuilder WithGenericCondition(Func<string, bool> evaluator);
    }
}