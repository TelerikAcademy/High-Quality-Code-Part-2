using ProjectManager.Commands.Abstracts;
using ProjectManager.Commands.Contracts;
using ProjectManager.Data;
using System.Collections.Generic;

namespace ProjectManager.Commands.Listing
{
    public sealed class ListProjectDetailsCommand : Command, ICommand
    {
        public ListProjectDetailsCommand(IDatabase database) 
            : base(database, 1)
        {
        }

        public override string Execute(IList<string> parameters)
        {
            this.ValidateParameters(parameters);

            var projectId = int.Parse(parameters[0]);
            var project = this.Database.Projects[projectId];

            return project.ToString();
        }
    }
}
