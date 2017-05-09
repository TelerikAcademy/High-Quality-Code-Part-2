namespace ProjectManager.Common.Contracts
{
    public interface ILogger
    {
        void Info(object msg);

        void Error(object msg);

        void Fatal(object msg);
    }
}
