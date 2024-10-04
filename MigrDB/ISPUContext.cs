using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MigrDB
{
    internal class ISPUContext: DbContext
    {
        public ISPUContext() : base("ISPUCS") { }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Cathedras> Cathedras { get; set; }
    }
}
