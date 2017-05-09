using ProjectManager.Data.Models.States;
using System;
using System.Collections.Generic;

namespace ProjectManager.Data.Models.Contracts
{
    public interface IProject
    {
        string Name { get; set; }

        DateTime StartingDate { get; set; }

        DateTime EndingDate { get; set; }

        ProjectState State { get; set; }

        IList<IUser> Users { get; set; }

        IList<ITask> Tasks { get; set; }
    }
}
