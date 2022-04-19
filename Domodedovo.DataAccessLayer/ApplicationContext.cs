using Microsoft.EntityFrameworkCore;

namespace Domodedovo.DataAccessLayer
{
    /// <summary>
    /// Контекст базы данных
    /// </summary>
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// Пользователи
        /// </summary>
        public DbSet<User> Users { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Domodedovo;Trusted_Connection=True;");
    }
}