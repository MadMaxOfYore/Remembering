using System;

namespace SelfStudy.ConsoleEntryEvaluation.Condition
{
    public class GenericTestCondition : ITestCondition
    {
        private readonly Func<string, bool> testConditionEvaluator;

        public GenericTestCondition(Func<string, bool> testConditionEvaluator)
        {
            this.testConditionEvaluator = testConditionEvaluator;
        }

        public bool IsMetByEntry(string commandLineEntry)
        {
            return testConditionEvaluator(commandLineEntry);
        }
    }
}