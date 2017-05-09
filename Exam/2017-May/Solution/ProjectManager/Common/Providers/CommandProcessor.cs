using Bytes2you.Validation;
using ProjectManager.Commands.Contracts;
using ProjectManager.Commands.Factories;
using ProjectManager.Common.Contracts;
using ProjectManager.Common.Exceptions;
using System.Linq;

namespace ProjectManager.Common.Providers
{
    public class CommandProcessor : IProcessor
    {
        private static CommandProcessor instance;

        private ICommandsFactory factory;

        public CommandProcessor(ICommandsFactory factory)
        {
            this.factory = factory ?? new CommandsFactory(null, null);
        }

        // Singleton design pattern
        public static IProcessor Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CommandProcessor(null);
                }

                return instance;
            }
        }

        public ICommandsFactory CommandsFactory
        {
            get
            {
                return this.factory;
            }

            set
            {
                Guard.WhenArgument(value, "CommandProcessor CommandsFactory").IsNull().Throw();
                this.factory = value;
            }
        }

        public string ProcessCommand(string commandLine)
        {
            if (string.IsNullOrWhiteSpace(commandLine))
            {
                throw new UserValidationException("No command has been provided!");
            }

            var commandName = commandLine.Split(' ')[0];
            var commandParameters = commandLine
                .Split(' ')
                .Skip(1)
                .ToList();

            var command = this.CommandsFactory.CreateCommandFromString(commandName);
            var executionResult = command.Execute(commandParameters);

            return executionResult;
        }
    }
}
