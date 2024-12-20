using prueba_redarbor_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace prueba_redarbor_backend.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<UsuariosModel> Usuarios { get; set; }
    }
}
