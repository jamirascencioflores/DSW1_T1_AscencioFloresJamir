using Microsoft.EntityFrameworkCore;
using DSW1_T1_AscencioFloresJamir.Models;

namespace DSW1_T1_AscencioFloresJamir.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<NivelAcademico> NivelesAcademicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NivelAcademico>()
                .HasMany(n => n.Cursos)
                .WithOne(c => c.NivelAcademico)
                .HasForeignKey(c => c.NivelAcademicoId);
        }
    }
}