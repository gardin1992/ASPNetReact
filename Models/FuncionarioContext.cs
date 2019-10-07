using Microsoft.EntityFrameworkCore;

namespace my_new_app.Models
{
    public class FuncionarioContext : DbContext
    {
        public FuncionarioContext(DbContextOptions<FuncionarioContext> options)
           : base(options)
        {
        }
        public DbSet<FuncionarioItem> FuncionarioItems { get; set; }
    }
}
