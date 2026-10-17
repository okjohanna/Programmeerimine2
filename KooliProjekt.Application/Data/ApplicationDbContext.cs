using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        /* Loengu k2igus said lisatud need:
        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<User> Users { get; set; }
        */
    }
}
