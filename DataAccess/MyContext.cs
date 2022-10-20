using EntityLayer.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAccessLayer
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyCon")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Admin>()
                .Map(map =>
                {
                    map.Properties(p => new
                    {
                        p.Username,
                        p.Password,
                        p.ID,
                        p.CreatedDate,
                        p.IsActive
                    });
                    map.ToTable("Admin");
                });

            modelBuilder.Entity<Comment>()
                .Map(map =>
                {
                    map.Properties(p => new
                    {
                        p.ID,
                        p.CreatedDate,
                        p.IsActive,
                        p.ProductID,
                        p.ApprovedAdminID,
                        p.IsApproved,
                        p.CustomerID,
                        p.Text
                    });
                    map.ToTable("Comment");
                });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Evaluation> Evaluation { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Producer> Producer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductEvaluation> ProductEvaluation { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
