using HRProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HRProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Competence> Competences { get; set; }
        public DbSet<UserCompetence> UserCompetences { get; set; }
        public DbSet<ProjectManager> ProjectManagers { get; set; }
        public DbSet<ProjectRequirement> ProjectRequirements { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserCompetence>()
                .HasKey(uc => new { uc.UserId, uc.CompetenceId });

            builder.Entity<UserCompetence>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.UserCompetences)
                .HasForeignKey(uc => uc.UserId);

            builder.Entity<UserCompetence>()
                .HasOne(uc => uc.Competence)
                .WithMany(c => c.UserCompetences)
                .HasForeignKey(uc => uc.CompetenceId);

            builder.Entity<ProjectRequirement>()
                .HasOne(r => r.Project)
                .WithMany(p => p.Requirements)
                .HasForeignKey(r => r.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ProjectRequirement>()
                .HasOne(r => r.Competence)
                .WithMany()
                .HasForeignKey(r => r.CompetenceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
