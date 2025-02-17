using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LegionCommand.Models;

namespace LegionCommand.Data
{
    public class LegionCommandContext : DbContext
    {
        public LegionCommandContext (DbContextOptions<LegionCommandContext> options)
            : base(options)
        {
        }

        public DbSet<LegionCommand.Models.Unit> Unit { get; set; } = default!;
    }
}
