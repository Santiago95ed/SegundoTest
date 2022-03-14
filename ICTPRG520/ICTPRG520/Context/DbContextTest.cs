namespace ICTPRG520.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbContextTest : DbContext
    {
        public DbContextTest()
            : base("name=DbContextTest")
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Album> Album { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);
        }
    }
}
