using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Api_Project.Models
{
    public class Book
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        public string Title { get; set; }

        public string Description { get; set; }

        public int AuthorID { get; set; }       // Foreign Key

    
        public Author Author { get; set; }
    }
}
