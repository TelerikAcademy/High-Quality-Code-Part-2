using ProjectManager.Commands.Abstracts;
using ProjectManager.Commands.Contracts;
using ProjectManager.Data;
using ProjectManager.Data.Factories;
using System.Collections.Generic;

namespace ProjectManager.Commands.Creational
{
    public sealed class CreateTaskCommand : CreationalCommand, ICommand
    {
        public CreateTaskCommand(IDatabase database, IModelsFactory factory) 
            : base(database, factory, 4)
        {
        }

        public override string Execute(IList<string> parameters)
        {
            this.ValidateParameters(parameters);

            var projectId = int.Parse(parameters[0]);
            var project = this.Database.Projects[projectId];

            var ownerId = int.Parse(parameters[1]);
            var owner = project.Users[ownerId];

            var task = this.Factory.CreateTask(owner, parameters[2], parameters[3]);
            project.Tasks.Add(task);

            return "Successfully created a new task!";
        }
    }
}
