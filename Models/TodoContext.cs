using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> opt) : base(opt)
        { }

        public DbSet<TodoItem> TodoItems { get; set; }
    }

}