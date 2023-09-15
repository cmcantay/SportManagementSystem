using System;
using System.Collections.Generic;
using System.Text;

namespace SportManagementSystem.Data.DbModels
{
    public class Activity : BaseEntity
    {
        public int TypeId{ get; set; }
        public DateTime Date { get; set; }
        public string Definitions { get; set; }
        public int UserId { get; set; }
    }
}
