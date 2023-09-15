using System;
using System.Collections.Generic;
using System.Text;

namespace SportManagementSystem.Data.DbModels
{
    public class RoleAssignViewModel
    {
        public string RoleId { get; set; }
        public string Name { get; set; }
        public bool  Exists { get; set; }
    }
}
