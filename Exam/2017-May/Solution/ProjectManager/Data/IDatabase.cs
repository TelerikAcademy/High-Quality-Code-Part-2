using ProjectManager.Data.Models.Contracts;
using System.Collections.Generic;

namespace ProjectManager.Data
{
    // You are not allowed to modify this interface (not even to remove this comment)
    public interface IDatabase
    {
        IList<IProject> Projects { get; }
    }
}
