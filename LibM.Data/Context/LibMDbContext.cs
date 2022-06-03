using LibM.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibM.Data.Context
{
    public class LibMDbContext : DbContext
    {
        public LibMDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyGlobalFilters(e => !e.IsDeleted);
            // Fluent API ile model creating
            modelBuilder.Entity<Student>()
                        .HasOne(s => s.Grade)
                        .WithMany(g => g.Students)
                        .HasForeignKey(s => s.GradeId);
            modelBuilder.Entity<Student>()
                .Property(p => p.FirstName)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Student>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Student>()
                .Property(p => p.Age)
                .IsRequired()
                .HasDefaultValue(18);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Book> Books { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=localhost,20000;Database=LibMDb;User Id=sa;Password=Bilgeadam123!");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}