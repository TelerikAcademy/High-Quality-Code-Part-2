using System.Collections.Generic;

namespace ProjectManager.Commands.Contracts
{
    public interface ICommand
    {
        string Execute(IList<string> parameters);
    }
}
