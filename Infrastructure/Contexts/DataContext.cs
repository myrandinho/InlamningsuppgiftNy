

using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public class DataContext : DbContext
{
    public DataContext()
    {
        
    }

    public DataContext(DbContextOptions options) : base(options)
    {
    }


    public virtual DbSet<UserEntity> Users { get; set; } = null!;
    public virtual DbSet<SkillEntity> Skills { get; set; } = null!;
    public virtual DbSet<RoleEntity> Roles { get; set; } = null!;
    public virtual DbSet<ProfileEntity> Profiles { get; set; } = null!;
    public virtual DbSet<LanguageEntity> Languages { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\my-projects\InlamningsuppgiftNy\Infrastructure\Data\database_local_new.mdf;Integrated Security=True;Connect Timeout=30");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>()
            .HasMany(x => x.Skills)
            .WithMany(y => y.Users)
            .UsingEntity(j => j.ToTable("UserSkills"));
    }
}
