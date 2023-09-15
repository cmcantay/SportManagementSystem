using SportManagementSystem.Data.Contracts;
using SportManagementSystem.Data.DataContext;

namespace SportManagementSystem.Data.Implementaion
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UdemySportManagementSystemContext _ctx;

        public UnitOfWork(UdemySportManagementSystemContext ctx)
        {
            _ctx = ctx;
           
            employeeRepository = new EmployeeRepository(_ctx);
          
        }

        public IEmployeeRepository employeeRepository { get; private set; }
  
        public void Save()
        {
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
