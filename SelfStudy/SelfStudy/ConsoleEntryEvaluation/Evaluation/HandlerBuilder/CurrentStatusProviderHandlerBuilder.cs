using System;
using SelfStudy.ConsoleEntryEvaluation.Condition;
using SelfStudy.ConsoleEntryEvaluation.Evaluation.Base;
using SelfStudy.ConsoleEntryEvaluation.Evaluation.ConditionalHandler;
using SelfStudy.ConsoleEntryEvaluation.Scenario.ScenarioBuilder;

namespace SelfStudy.ConsoleEntryEvaluation.Evaluation.HandlerBuilder
{
    public class CurrentStatusProviderHandlerBuilder : IConsoleEntryEvaluationHandlerBuilder, IConditionalEvaluationHandlerBuildContext
    {
        private readonly TestScenarioManagerBuilder manager;
        private ITestCondition condition;

        public CurrentStatusProviderHandlerBuilder(TestScenarioManagerBuilder manager)
        {
            this.manager = manager;
        }

        public TestScenarioManagerBuilder WithGenericCondition(Func<string, bool> evaluator)
        {
            condition = new GenericTestCondition(evaluator);
            return this.manager;
        }

        public IConsoleEntryEvaluationHandler Build()
        {
            return new CurrentStatusProviderHandler(condition);
        }
    }
}
