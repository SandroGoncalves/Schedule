using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gendar.Entity
{
    [Table("staff")]
    public class Staff
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("birth_year")]
        [Required]
        [StringLength(50)]
        public DateTime BithYear { get; set; }
        
        [Column("Register_code")]
        [Required]
        [StringLength(50)]
        public string RegisterCode { get; set; }
    }
}
