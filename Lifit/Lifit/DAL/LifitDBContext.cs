using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Lifit.DAL
{
	
    public class LifitDBContext : DbContext
    {

        public LifitDBContext() : base("LifitConnectionString")
        {
            Database.SetInitializer<LifitDBContext>(null);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Recip> Recipes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}
