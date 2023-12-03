using AspNet_Api_ModeloBase.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNet_Api_ModeloBase.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts) 
        { 
        
        }

        public DbSet<Filme> Filmes { get; set; }
    }
}
