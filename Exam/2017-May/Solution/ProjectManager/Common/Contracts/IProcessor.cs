namespace ProjectManager.Common.Contracts
{
    public interface IProcessor
    {
        string ProcessCommand(string commandLine);
    }
}
