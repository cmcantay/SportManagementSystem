using AutoMapper;
using SportManagementSystem.BusinessEngine.Contracts;
using SportManagementSystem.Common.ConstantsModels;
using SportManagementSystem.Common.ResultModels;
using SportManagementSystem.Common.VModels;
using SportManagementSystem.Data.Contracts;
using SportManagementSystem.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SportManagementSystem.BusinessEngine.Implementaion
{
    public class EmployeeBusinessEngine : IEmployeeBusinessEngine
    {
        #region Variables
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public EmployeeBusinessEngine(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion

        #region CustomMethods

        public Result<List<EmployeeVM>> GetAllEmployee()
        {
            var data = _unitOfWork.employeeRepository.GetAll();
            if (data != null)
            {
                List<EmployeeVM> listData = new List<EmployeeVM>();
                foreach (var item in data)
                {
                    listData.Add(new EmployeeVM
                    {
                        DateOfBirth = item.DateOfBirth,
                        Email = item.Email,
                        FirstName = item.FirstName,
                        Id = item.Id,
                        LastName = item.LastName,
                        PhoneNumber = item.PhoneNumber,
                        TaxId = item.TaxId,
                        UserName = item.UserName
                    });
                }
                return new Result<List<EmployeeVM>>(true, ResultConstant.RecordFound, listData);

            }
            return new Result<List<EmployeeVM>>(false, ResultConstant.RecordNotFound);
        }

    
        #endregion
    }
}
