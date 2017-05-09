using ProjectManager.Models;
using System.Collections.Generic;

namespace ProjectManager.Data
{
    // You are not allowed to modify this interface (except to add documentation)
    public interface IDatabase
    {
        IList<IProject> Projects { get; }
    }
}
