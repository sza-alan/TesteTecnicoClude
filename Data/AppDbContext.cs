using GestaoProfissionais.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoProfissionais.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profissional>()
                .HasOne(p => p.Especialidade)
                .WithMany()
                .HasForeignKey(p => p.EspecialidadeId);
        }
    }
}
