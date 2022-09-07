using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(
                nameof(Student.Std),
                nameof(Student.Div),
                nameof(Student.Rollno)
                );

            builder.HasData(
                new Student
                {
                    Std = 8,
                    Div = 'A',
                    Rollno = 47,
                    Name = "John",
                    Address = "CA"
                },
                new Student
                {
                    Std = 7,
                    Div = 'B',
                    Rollno = 12,
                    Name = "Amber Heard",
                    Address = "FL"
                },
                new Student
                {
                    Std = 4,
                    Div = 'C',
                    Rollno = 1,
                    Name = "Camile",
                    Address = "NY"
                });
        }
    }
}
