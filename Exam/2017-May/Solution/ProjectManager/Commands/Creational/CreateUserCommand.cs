using ProjectManager.Commands.Abstracts;
using ProjectManager.Commands.Contracts;
using ProjectManager.Common.Exceptions;
using ProjectManager.Data;
using ProjectManager.Data.Factories;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManager.Commands.Creational
{
    public sealed class CreateUserCommand : CreationalCommand, ICommand
    {
        public CreateUserCommand(IDatabase database, IModelsFactory factory) 
            : base(database, factory, 3)
        {
        }

        public override string Execute(IList<string> parameters)
        {
            this.ValidateParameters(parameters);

            var projectId = int.Parse(parameters[0]);
            var project = this.Database.Projects[projectId];

            if (project.Users.Any() && project.Users.Any(x => x.Username == parameters[1]))
            {
                throw new UserValidationException("A user with that username already exists!");
            }

            var user = this.Factory.CreateUser(parameters[1], parameters[2]);
            project.Users.Add(user);

            return "Successfully created a new user!";
        }
    }
}
