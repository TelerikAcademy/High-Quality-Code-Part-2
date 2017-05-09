using ProjectManager.Data.Models.States;
using System.Collections.Generic;

namespace ProjectManager.Data.Models.Contracts
{
    public interface ITask
    {
        string Name { get; set; }

        IUser Owner { get; set; }

        TaskState State { get; set; }
    }
}
