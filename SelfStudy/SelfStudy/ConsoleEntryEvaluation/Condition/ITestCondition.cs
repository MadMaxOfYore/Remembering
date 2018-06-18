namespace SelfStudy.ConsoleEntryEvaluation.Condition
{
    public interface ITestCondition
    {
        bool IsMetByEntry(string commandLineEntry);
    }
}