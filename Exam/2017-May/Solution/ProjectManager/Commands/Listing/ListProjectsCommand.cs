using ProjectManager.Commands.Abstracts;
using ProjectManager.Commands.Contracts;
using ProjectManager.Data;
using System;
using System.Collections.Generic;

namespace ProjectManager.Commands.Listing
{
    public sealed class ListProjectsCommand : Command, ICommand
    {
        public ListProjectsCommand(IDatabase database) 
            : base(database, 0)
        {
        }

        public override string Execute(IList<string> parameters)
        {
            this.ValidateParameters(parameters);

            var projects = this.Database.Projects;
            return string.Join(Environment.NewLine, projects);
        }
    }
}
