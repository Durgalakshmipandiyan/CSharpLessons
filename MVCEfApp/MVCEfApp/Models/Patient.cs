using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCEfApp.Models
{
    public class Patient
    {
        [Key]
        [Column("patientno")]
        public int Id { get; set; }

        [Required]
        [StringLength(20)] //nvarchar
        [MinLength(3, ErrorMessage = "Name must be between 3 to 20 chars")]
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        [Column(TypeName = "numeric(18,0")]
        public decimal PhoneNumber { get; set; }
    }
}
