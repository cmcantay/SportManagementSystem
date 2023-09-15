using SportManagementSystem.Common.ResultModels;
using SportManagementSystem.Common.VModels;
using System.Collections.Generic;

namespace SportManagementSystem.BusinessEngine.Contracts
{
    public interface IEmployeeBusinessEngine
    {
        Result<List<EmployeeVM>> GetAllEmployee();
        }
}
