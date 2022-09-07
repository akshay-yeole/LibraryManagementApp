using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book
                {
                    Id = 1,
                    Name = "The Haunting Of Hill House",
                    Author = "Shirley Jackson",
                    CategoryId = 1,
                    CopiesAvailable = 10
                },
                new Book
                {
                    Id = 2,
                    Name = "The House Next Door",
                    Author = "Anne Rivers Siddons",
                    CategoryId = 1,
                    CopiesAvailable = 7
                },
                new Book
                {
                    Id = 3,
                    Name = "Lunar Park",
                    Author = "Shirley Jackson",
                    CategoryId = 1,
                    CopiesAvailable = 10
                },
                new Book
                {
                    Id = 4,
                    Name = "Don Quixote",
                    Author = "Miguel de Cervantes",
                    CategoryId = 1,
                    CopiesAvailable = 9
                },
                new Book
                {
                    Id = 5,
                    Name = "Ivanhoe ",
                    Author = "Walter Scott",
                    CategoryId = 2,
                    CopiesAvailable = 12
                },
                new Book
                {
                    Id = 6,
                    Name = "King Solomon's Mines",
                    Author = "Harry",
                    CategoryId = 2,
                    CopiesAvailable = 18
                },
                new Book
                {
                    Id = 7,
                    Name = "Journey to the Center of the Earth",
                    Author = "Jules Verne",
                    CategoryId = 2,
                    CopiesAvailable = 14
                },
                new Book
                {
                    Id = 8,
                    Name = "Gone Girl",
                    Author = "Gillian Flynn",
                    CategoryId = 2,
                    CopiesAvailable = 23
                },
                new Book
                {
                    Id = 9,
                    Name = "Anatomy of a Murder",
                    Author = "Robert Traver",
                    CategoryId = 2,
                    CopiesAvailable = 23
                },
                new Book
                {
                    Id = 10,
                    Name = "In Cold Blood",
                    Author = "Truman Capote",
                    CategoryId = 3,
                    CopiesAvailable = 3
                }
                );
        }
    }
}
