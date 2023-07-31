using CrudBucketMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudBucketMVC.DataAccess
{
    public class CrudBucketContext : DbContext
    {
        public DbSet<Muffin> Muffins { get; set; }
        public CrudBucketContext(DbContextOptions<CrudBucketContext> options) : base(options)
        {
        }
    }
}
