using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Todo.Domain.Entities;

namespace Todo.Domain.Infra.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext([NotNullAttribute] DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<TodoItem> Todos { get; set; }
    }
}