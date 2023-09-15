using System;

namespace SportManagementSystem.Data.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository employeeRepository { get; }
        void Save();
    }
}
