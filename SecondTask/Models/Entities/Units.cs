using System.ComponentModel.DataAnnotations;

namespace SecondTask.Models.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
    }

}
