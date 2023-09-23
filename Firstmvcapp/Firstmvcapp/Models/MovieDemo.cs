using System.ComponentModel.DataAnnotations;

namespace Firstmvcapp.Models
{
    public class MovieDemo

    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Title must be become 3 to 30 chars")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Language must be become 3 to 15 chars")]
        public string Language { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be become 3 to 30 chars")]
        public string Hero { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be become 3 to 30 chars")]
        public string Director { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be become 3 to 30 chars")]
        public string MusicDirector { get; set; } = string.Empty;



        public DateTime ReleaseDate { get; set; }

        [Required]
        [Range(10, 200000)]
        public decimal Cost { get; set; }

        [Required]
        [Range(100, 200000)]
        public decimal Collection { get; set; }

        [StringLength(20)]
        [MinLength(4, ErrorMessage = "Review must be between 3 to 30 chars")]

    public string Review { get; set; }


    }
}
