using System;
using System.Collections.Generic;
using System.Text;

namespace SportManagementSystem.Data.DbModels
{
    public class Athletes : BaseEntity
    {
        public int UserId { get; set; }
        public string Name { get; set; }    
        public int UniformNumber { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; set; }

    }
}
