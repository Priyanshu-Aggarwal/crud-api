namespace Web_Api_Project.DTO
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime? CreateAt { get; set; }

        public  List<BookDTO> bookDTOs { get; set; }
    }
}
