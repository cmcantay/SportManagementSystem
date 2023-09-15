using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace SportManagementSystem.Data.DbModels
{
    public class Payment : BaseEntity
    {
        public int UserId { get; set; }
        public decimal Amount { get; set; }
    }
}
