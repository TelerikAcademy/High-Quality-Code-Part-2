using Bytes2you.Validation;
using ProjectManager.Commands.Contracts;
using ProjectManager.Data;
using ProjectManager.Data.Factories;

namespace ProjectManager.Commands.Abstracts
{
    public abstract class CreationalCommand : Command, ICommand
    {
        protected readonly IModelsFactory Factory;

        public CreationalCommand(IDatabase database, IModelsFactory factory, uint parameterCount) 
            : base(database, parameterCount)
        {
            Guard.WhenArgument(factory, "CreateProjectCommand ModelsFactory").IsNull().Throw();
            this.Factory = factory;
        }
    }
}
