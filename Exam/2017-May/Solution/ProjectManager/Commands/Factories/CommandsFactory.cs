using ProjectManager.Commands.Contracts;
using ProjectManager.Commands.Creational;
using ProjectManager.Commands.Listing;
using ProjectManager.Common.Exceptions;
using ProjectManager.Common.Providers;
using ProjectManager.Data;
using ProjectManager.Data.Factories;

namespace ProjectManager.Commands.Factories
{
    public class CommandsFactory : ICommandsFactory
    {
        private readonly IDatabase database;
        private readonly IModelsFactory factory;

        public CommandsFactory(IDatabase database, IModelsFactory factory)
        {
            this.database = database ?? new Database();
            this.factory = factory ?? new ModelsFactory(new Validator());
        }

        public ICommand CreateCommandFromString(string commandName)
        {
            switch (commandName.ToLower())
            {
                case "createproject":
                    return this.CreateProjectCommand();
                case "createuser":
                    return this.CreateUserCommand();
                case "createtask":
                    return this.CreateTaskCommand();
                case "listprojects":
                    return this.ListProjectCommand();
                case "listprojectdetails":
                    return this.ListProjectDetailsCommand();
                default:
                    throw new UserValidationException("The passed command is not valid!");
            }
        }
        
        public ICommand CreateProjectCommand()
        {
            return new CreateProjectCommand(this.database, this.factory);
        }

        public ICommand CreateUserCommand()
        {
            return new CreateUserCommand(this.database, this.factory);
        }

        public ICommand CreateTaskCommand()
        {
            return new CreateTaskCommand(this.database, this.factory);
        }

        public ICommand ListProjectCommand()
        {
            return new ListProjectsCommand(this.database);
        }

        public ICommand ListProjectDetailsCommand()
        {
            return new ListProjectDetailsCommand(this.database);
        }
    }
}
