using Microsoft.EntityFrameworkCore;
using Web_Api_Project.Models;

namespace Web_Api_Project.Seeding
{
    public static class Module3Seeding
    {
        public static void seed(ModelBuilder modelBuilder)
        {
            var Author1 = new Author() { Id = 1, Name = "TestAuthor 1" , Email = "email@gmail.com", CreatedAt = DateTime.Now};
            var Author2 = new Author() { Id = 2, Name = "TestAuthor 2",  Email = "author@gmail.com", CreatedAt = DateTime.Now };
            var Author3 = new Author() { Id = 3, Name = "TestAuthor 3", Email =  "author3@gmail.com", CreatedAt = DateTime.Now };
            var Author4 = new Author() { Id = 4, Name = "TestAuthor 4", Email =  "author4@gmail.com", CreatedAt = DateTime.Now };
            var Author5 = new Author() { Id = 5, Name = "TestAuthor 5", Email =  "author5@gmail.com", CreatedAt = DateTime.Now };
            var Author6 = new Author() { Id = 6, Name = "TestAuthor 6", Email =  "author6@gmail.com", CreatedAt = DateTime.Now };
            modelBuilder.Entity<Author>().HasData(Author1);
            modelBuilder.Entity<Author>().HasData(Author2);
            modelBuilder.Entity<Author>().HasData(Author3, Author4, Author5, Author6);

            var Book1 = new Book() { Id = 1, AuthorID = Author1.Id, Description = "TestBook Description",     Title= "TestBook"};
            var Book2 = new Book() { Id = 2, AuthorID = Author2.Id, Description = "TestBook New Description", Title = "TestBook New"  };
            var Book3 = new Book() { Id = 3, AuthorID = Author3.Id, Description = "TestBook New Description 3", Title = "TestBook New"  };
            var Book4 = new Book() { Id = 4, AuthorID = Author3.Id, Description = "TestBook New Description 4", Title = "TestBook New"  };
            var Book5 = new Book() { Id = 5, AuthorID = Author1.Id, Description = "TestBook New Description 5", Title = "TestBook New"  };
            var Book6 = new Book() { Id = 6, AuthorID = Author2.Id, Description = "TestBook New Description 6", Title = "TestBook New" };            
            modelBuilder.Entity<Book>().HasData(Book1);
            modelBuilder.Entity<Book>().HasData(Book2);
            modelBuilder.Entity<Book>().HasData(Book3, Book4, Book5, Book6);

        }
    }
}
