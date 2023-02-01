using Microsoft.EntityFrameworkCore;
using SistemaWebMisRecetas1.Models;

namespace SistemaWebMisRecetas1.Data
{
    public class DBDesayunoContext:DbContext
    {
        
            public DBDesayunoContext(DbContextOptions<DBDesayunoContext> options) : base(options) { }



            public DbSet<Receta> Recetas { get; set; }



        
    }
}
