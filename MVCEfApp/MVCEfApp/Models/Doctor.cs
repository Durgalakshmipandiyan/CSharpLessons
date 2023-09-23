using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEfApp.Models
{
    public class Doctor
    {
        [Key]
        [Column("doctorno")] // if "doctorno" name is not specified then it will take id
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }= string.Empty;
        [Required]
        public string Speciality { get; set; } = string.Empty;
        [Required]
        public DateTime DateofBirth { get; set; }
        [Required]
        [Column(TypeName ="numeric(18,2)")]
        public decimal VisitingFres { get; set; }
        [Required]
        public long PhoneNumber { get; set; }



    }
}
