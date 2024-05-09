using Microsoft.EntityFrameworkCore;

namespace webAPI.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Grade>(entity =>
        //    { 
        //        entity.Property(e => e.GradeName)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.HasMany(g => g.Students) // A grade can have many students
        //            .WithOne(s => s.Grade)      // Each student belongs to one grade
        //            .HasForeignKey(s => s.GradeId)  // Foreign key property in the Student entity
        //            .OnDelete(DeleteBehavior.ClientSetNull); // Adjust the delete behavior as needed
        //    });

        //    modelBuilder.Entity<Student>(entity =>
        //    {
        //        entity.Property(e => e.FirstName)
        //            .HasMaxLength(100)
        //            .IsUnicode(false);

        //        entity.Property(e => e.LastName)
        //            .HasMaxLength(100)
        //            .IsUnicode(false);

        //        // Define the relationship with Grade
        //        entity.HasOne(d => d.Grade)
        //            .WithMany(p => p.Students)
        //            .HasForeignKey(d => d.GradeId)
        //            .OnDelete(DeleteBehavior.ClientSetNull) // Adjust the delete behavior as needed
        //            .HasConstraintName("FK_Student_Grade");
        //    });
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=bao;Password=bao");
            }
        }
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddCors(options =>
        //    {
        //        options.AddPolicy("AllowOrigin", builder =>
        //        {
        //            builder.WithOrigins("*")
        //                   .AllowAnyHeader()
        //                   .AllowAnyMethod();
        //        });
        //    });
        //}

    }
}
