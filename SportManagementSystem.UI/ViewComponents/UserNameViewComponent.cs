﻿using AutoMapper;
using SportManagementSystem.Common.VModels;
using SportManagementSystem.Data.Contracts;
using SportManagementSystem.Data.DbModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SportManagementSystem.UI.ViewComponents
{
    public class UserNameViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public UserNameViewComponent(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var userFromDb = _uow.employeeRepository.GetFirstOrDefault(u => u.Id == claims.Value);

            var employeeToDb = _mapper.Map<Employee, EmployeeVM>(userFromDb);

            return View(employeeToDb);
        }
    }
}
