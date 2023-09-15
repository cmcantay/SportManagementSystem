using System;
using System.Collections.Generic;
using System.Text;

namespace SportManagementSystem.Data.DbModels
{
    public class Users : BaseEntity
    {
        public string Email { get; set; }
        public bool Emailcomfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
    }
}
