using System.ComponentModel.DataAnnotations;

namespace Firstmvcapp.Models
{
    public class Emptable
    {
        [Key]
        public int eno { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3,ErrorMessage = "name must be 3 and 20")]
        public string name { get; set; } = string.Empty;
        [Required]
        [Range(1000,500000)]
        public decimal salary { get; set; }
        [StringLength(20)]
        [MinLength(3,ErrorMessage ="city must be between 3 and 20 char")]
        public string city { get; set; } =string.Empty;
    }
}
