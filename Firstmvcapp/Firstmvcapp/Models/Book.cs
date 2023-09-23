using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations; //used for adding annotations

namespace Firstmvcapp.Models
{
    public class Book
    {
        [Key] //square brackets are annotations . fields are decorated they are meta data.
              //book id, cost, author are all properties of book class. for each of them adding constraints which is called validators
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { set; get; }
        [StringLength(25, ErrorMessage = "Title must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "Title must have at least 3 chars")]
        [Required(ErrorMessage = "Title is Required")]
        public String Title { set; get; }
        [Range(50, 10000, ErrorMessage = "Cost must be between 50 and 10000")]
        public float Cost { set; get; }
        [StringLength(25, ErrorMessage = "Name must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "Name must have at least 3 chars")]
        [Required(ErrorMessage = "Name is Required")]
        public String AuthorName { set; get; }
    }
}
