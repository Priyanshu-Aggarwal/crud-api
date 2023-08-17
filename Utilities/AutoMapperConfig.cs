using AutoMapper;
using Web_Api_Project.DTO;
using Web_Api_Project.Models;

namespace Web_Api_Project.Utilities
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig() {

            CreateMap<Author, AuthorDTO>().ForMember(dest => dest.bookDTOs, op => op.MapFrom(src => src.Books));
            CreateMap<Book, BookDTO>();

        }
    }
}
