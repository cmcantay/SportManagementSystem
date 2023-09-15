using AutoMapper;
using SportManagementSystem.BusinessEngine.Implementaion;
using SportManagementSystem.Common.ConstantsModels;
using SportManagementSystem.Common.PagingListModels;
using SportManagementSystem.Common.VModels;
using SportManagementSystem.Data.Contracts;
using SportManagementSystem.Data.DbModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SportManagementSystem.UI.ViewComponents
{
    public class EmployeeListViewComponent : ViewComponent
    {
        #region Variables
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public EmployeeListViewComponent(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        #endregion

        #region CustomMethod

        /// <summary>
        /// Employee Id Ve Status ıle Is Emrı Getırme(Atanmıs)
        /// </summary>
        /// <returns></returns>
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = _uow.employeeRepository.GetAll(e => e.IsActive == true && e.IsAdmin != true).ToList();

            if (data != null)
            {
                var mappingData = _mapper.Map<List<Employee>, List<EmployeeVM>>(data);
                ViewBag.EmployeeList = mappingData;
                return View(mappingData);
            }
            return View();
        }
        #endregion
    }
}
