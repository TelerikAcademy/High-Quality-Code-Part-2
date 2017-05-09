using System.Collections.Generic;

namespace ProjectManager.Common.Contracts
{
    public interface IValidator
    {
        void Validate<T>(T obj) where T : class;
    }
}
