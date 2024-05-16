using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DropdownFromDatabase.Model
{
    public class Technology
    {
        [Key]
        public int Id { get; set; }
        [Column("TechName")]
        public string TechnologyName { get; set; }
    }
}
