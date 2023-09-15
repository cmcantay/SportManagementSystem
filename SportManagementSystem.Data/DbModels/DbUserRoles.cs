using System;
using System.Collections.Generic;
using System.Text;

namespace SportManagementSystem.Data.DbModels
{
    public class DbUserRoles : BaseEntity
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
