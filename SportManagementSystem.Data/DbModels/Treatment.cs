using System;
using System.Collections.Generic;
using System.Text;

namespace SportManagementSystem.Data.DbModels
{
    public class Treatment : BaseEntity
    {
        public int UserId { get; set; }
        public string Disability { get; set; }
        public string Explanation { get; set; }
    }
}
