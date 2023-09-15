using AutoMapper;
using SportManagementSystem.Common.VModels;
using SportManagementSystem.Data.DbModels;

namespace SportManagementSystem.Common.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Employee, EmployeeVM>().ReverseMap();   
        }
    }
}
