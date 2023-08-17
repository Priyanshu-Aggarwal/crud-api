using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Api_Project.Models
{
    public class Author
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength:20)]
        public string Name { get; set; }
                
        public string Email { get; set; }

       // [Column(TypeName = "Date")]
        public DateTime CreatedAt { get; set; }
         

        public List<Book> Books { get; set; }     // One to Many  
    }
}
