using SportManagementSystem.Data.Contracts;
using SportManagementSystem.Data.DataContext;
using SportManagementSystem.Data.DbModels;

namespace SportManagementSystem.Data.Implementaion
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly UdemySportManagementSystemContext _ctx;

        public EmployeeRepository(UdemySportManagementSystemContext ctx)
            : base(ctx)
        {
        }
    }
}
