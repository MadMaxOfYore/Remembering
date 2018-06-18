using System.Collections.Generic;
using SelfStudy.ConsoleEntryEvaluation.Evaluation;
using SelfStudy.ConsoleEntryEvaluation.Evaluation.Base;
using SelfStudy.ConsoleEntryEvaluation.Evaluation.HandlerBuilder;
using SelfStudy.ConsoleEntryEvaluation.Scenario.Base;

namespace SelfStudy.ConsoleEntryEvaluation.Scenario.ScenarioBuilder
{
    public class TestScenarioManagerBuilder
    {
        private readonly Queue<IConsoleEntryEvaluationHandlerBuilder> evaluationStepBuilders;
        private readonly ITestScenarioManagerBuildContext manager;

        public TestScenarioManagerBuilder()
        {
            evaluationStepBuilders = new Queue<IConsoleEntryEvaluationHandlerBuilder>();

            this.manager = new TestScenarioManager();
        }

        public IConditionalEvaluationHandlerBuildContext WithScenario(string senarioName)
        {
            TestScenario scenario = new TestScenario(senarioName);
            this.manager.AppendTestScenario(scenario);

            TestScenarioEvaluationBuilder evaluationBuilder = new TestScenarioEvaluationBuilder(scenario, this);
            this.evaluationStepBuilders.Enqueue(evaluationBuilder);

            return evaluationBuilder;
        }

        public IConditionalEvaluationHandlerBuildContext WithStatusProviderHandler()
        {
            CurrentStatusProviderHandlerBuilder builder = new CurrentStatusProviderHandlerBuilder(this);
            this.evaluationStepBuilders.Enqueue(builder);

            return builder;
        }

        public TestScenarioManager Build()
        {
            IConsoleEntryEvaluationHandler evaluationHandler = BuildHandlerChain();
            this.manager.InstallEvaluationHandler(evaluationHandler);

            return (TestScenarioManager) this.manager;
        }

        private IConsoleEntryEvaluationHandler BuildHandlerChain()
        {
            IConsoleEntryEvaluationHandler rootEvaluationHandler = null;
            IConsoleEntryEvaluationHandler lastEvaluationHandler = null;

            do
            {
                IConsoleEntryEvaluationHandlerBuilder evaluationBuilder = evaluationStepBuilders.Dequeue();
                IConsoleEntryEvaluationHandler evaluationStepHandler = evaluationBuilder.Build();

                if (rootEvaluationHandler == null)
                {
                    rootEvaluationHandler = evaluationStepHandler;
                    lastEvaluationHandler = evaluationStepHandler;
                    continue;
                }

                lastEvaluationHandler.SetSuccessor(evaluationStepHandler);
                lastEvaluationHandler = evaluationStepHandler;
            } while (evaluationStepBuilders.Count > 0);

            UnhandledTestConditionStepHandler unhandledConditionHandler = new UnhandledTestConditionStepHandler();
            lastEvaluationHandler.SetSuccessor(unhandledConditionHandler);

            return rootEvaluationHandler;
        }
    }
}