using System;
using SelfStudy.ConsoleEntryEvaluation.Condition;
using SelfStudy.ConsoleEntryEvaluation.Evaluation.Base;
using SelfStudy.ConsoleEntryEvaluation.Evaluation.ConditionalHandler;
using SelfStudy.ConsoleEntryEvaluation.Scenario;
using SelfStudy.ConsoleEntryEvaluation.Scenario.ScenarioBuilder;

namespace SelfStudy.ConsoleEntryEvaluation.Evaluation.HandlerBuilder
{
    public class TestScenarioEvaluationBuilder : IConditionalEvaluationHandlerBuildContext, IConsoleEntryEvaluationHandlerBuilder
    {
        private readonly TestScenario scenario;
        private readonly TestScenarioManagerBuilder managerBuilder;
        private ITestCondition condition;

        public TestScenarioEvaluationBuilder(TestScenario scenario, TestScenarioManagerBuilder managerBuilder)
        {
            this.scenario = scenario;
            this.managerBuilder = managerBuilder;
        }

        public TestScenarioManagerBuilder WithGenericCondition(Func<string, bool> evaluator)
        {
            this.condition = new GenericTestCondition(evaluator);
            return this.managerBuilder;
        }

        public IConsoleEntryEvaluationHandler Build()
        {
            return new TestConditionEvaluationStepHandler(condition, scenario);
        }
    }
}