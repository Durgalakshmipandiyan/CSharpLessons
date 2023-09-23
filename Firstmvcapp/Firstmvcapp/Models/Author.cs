using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Firstmvcapp.Models
{
    public class Author
    {
        [Key] //square brackets are annotations . fields are decorated they are meta data.
              //book id, cost, author are all properties of book class. for each of them adding constraints which is called validators
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorID { set; get; }
        public String AuthorName { set; get; }

        public DateTime Dob { set; get; }
        public int BooksPublished { set; get; }
        public string Royalty { set; get; }

    }
}
