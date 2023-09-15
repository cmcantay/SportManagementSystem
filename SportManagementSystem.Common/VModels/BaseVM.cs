using System.ComponentModel.DataAnnotations;

namespace SportManagementSystem.Common.VModels
{
    public class BaseVM
    {
        [Key]
        public int Id { get; set; }
    }
}
