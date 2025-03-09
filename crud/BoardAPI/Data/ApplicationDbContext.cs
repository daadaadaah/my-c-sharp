using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer; // SQL Server 관련

using BoardAPI.Models;

namespace BoardAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Board> Boards { get; set; }
    }
} 