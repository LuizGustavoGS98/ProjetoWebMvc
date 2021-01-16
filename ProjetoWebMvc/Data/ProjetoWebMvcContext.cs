using Microsoft.EntityFrameworkCore;

namespace ProjetoWebMvc.Data
{
    public class ProjetoWebMvcContext : DbContext
    {
        public ProjetoWebMvcContext (DbContextOptions<ProjetoWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoWebMvc.Models.Department> Department { get; set; }
    }
}
