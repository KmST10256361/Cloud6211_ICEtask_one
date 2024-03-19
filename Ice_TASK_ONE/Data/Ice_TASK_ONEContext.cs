using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ice_TASK_ONE.Models;

namespace Ice_TASK_ONE.Data
{
    public class Ice_TASK_ONEContext : DbContext
    {
        public Ice_TASK_ONEContext (DbContextOptions<Ice_TASK_ONEContext> options)
            : base(options)
        {
        }

        public DbSet<Ice_TASK_ONE.Models.Game> Game { get; set; } = default!;
    }
}
