using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Project.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
