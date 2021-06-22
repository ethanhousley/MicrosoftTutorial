using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace MicrosoftTutorial.Models
{
    public class ConnectionDBClass:DbContext
    {
        public ConnectionDBClass(DbContextOptions<ConnectionDBClass> options) : base(options)
        {

        }

        public DbSet<Person> PrimaryUser { get; set; }
    }
}
