using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoTeam3.Models;

namespace ContosoTeam3.Data
{
    public class ContosoTeam3Context : DbContext
    {
        public ContosoTeam3Context (DbContextOptions<ContosoTeam3Context> options)
            : base(options)
        {
        }

        public DbSet<ContosoTeam3.Models.Session> Session { get; set; } = default!;
    }
}
