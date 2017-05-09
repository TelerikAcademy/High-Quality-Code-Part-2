using ProjectManager.Data.Models.Contracts;

namespace ProjectManager.Data.Factories
{
    public interface IModelsFactory
    {
        IProject CreateProject(string name, string startingDate, string endingDate, string state);

        ITask CreateTask(IUser owner, string name, string state);

        IUser CreateUser(string username, string email);
    }
}
