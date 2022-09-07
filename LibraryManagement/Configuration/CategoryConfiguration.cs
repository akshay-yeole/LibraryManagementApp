using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Horror"
                },
                new Category
                {
                    Id = 2,
                    Name = "Action and Adventure"
                },
                new Category
                {
                    Id = 3,
                    Name = "Classics"
                }, new Category
                {
                    Id = 4,
                    Name = "Comic Book"
                },
                new Category
                {
                    Id = 5,
                    Name = "Detective and Mystery"
                }
            );
        }
    }
}
