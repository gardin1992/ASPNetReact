using Microsoft.EntityFrameworkCore;

namespace my_new_app.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<FuncionarioItem> FuncionarioItems { get; set; }
    }
}
