using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CleaneArch.Domain.Models;

namespace CleaneArch.Infra.Data.Context
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Course> Courses { get; set;}
    }
}
