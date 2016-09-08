using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldBlog.Models
{
    [Table("Persons")]
    public class Person
     {
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int ExperienceId { get; set; }
        public virtual Experience Experience { get; set; }
    }
}