using System.Collections.Generic;

namespace ConsoleApplication3
{
    interface ICommand
    {
        string Execute(IList<string> parameters);
    }
}
