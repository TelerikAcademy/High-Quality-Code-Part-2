using ProjectManager.Commands.Abstracts;
using ProjectManager.Commands.Contracts;
using ProjectManager.Common.Exceptions;
using ProjectManager.Data;
using ProjectManager.Data.Factories;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManager.Commands.Creational
{
    public sealed class CreateProjectCommand : CreationalCommand, ICommand
    {
        public CreateProjectCommand(IDatabase database, IModelsFactory factory)
            : base(database, factory, 4)
        {
        }

        public override string Execute(IList<string> parameters)
        {
            this.ValidateParameters(parameters);

            if (this.Database.Projects.Any(x => x.Name == parameters[0]))
            {
                throw new UserValidationException("A project with that name already exists!");
            }

            var project = this.Factory.CreateProject(parameters[0], parameters[1], parameters[2], parameters[3]);
            this.Database.Projects.Add(project);

            return "Successfully created a new project!";
        }
    }
}
