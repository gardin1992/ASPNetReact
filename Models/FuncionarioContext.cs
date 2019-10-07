using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_new_app.Models
{
    public class FuncionarioContext : DbContext
    {
        public FuncionarioContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<FuncionarioItem> FuncionarioItems { get; set; }
    }
}
