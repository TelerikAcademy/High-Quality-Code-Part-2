namespace ProjectManager.Commands.Contracts
{
    public interface ICommandsFactory
    {
        ICommand CreateCommandFromString(string commandName);

        ICommand CreateProjectCommand();

        ICommand CreateUserCommand();

        ICommand CreateTaskCommand();
                
        ICommand ListProjectCommand();

        ICommand ListProjectDetailsCommand();
    }
}
