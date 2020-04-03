using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace GitBrachChange.Models
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext( DbContextOptions options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
