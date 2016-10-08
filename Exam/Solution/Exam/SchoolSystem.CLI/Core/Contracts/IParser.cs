using System.Collections.Generic;

using SchoolSystem.Cli.Core.Commands.Contracts;

namespace SchoolSystem.Cli.Core.Contracts
{
    /// <summary>
    /// Interface for a Parser provider
    /// </summary>
    public interface IParser
    {
        /// <summary>
        /// Parses a command from string to derivable of ICommand.
        /// </summary>
        /// <param name="fullCommand">The command to parse.</param>
        /// <returns>Returns new instance of the given command.</returns>
        ICommand ParseCommand(string fullCommand);

        /// <summary>
        /// Parses the parameters of a command.
        /// </summary>
        /// <param name="fullCommand">The command to parse.</param>
        /// <returns>Returns an IList<string> collection of parameters.</returns>
        IList<string> ParseParameters(string fullCommand);
    }
}
