using Microsoft.EntityFrameworkCore;
using True_Dive_Deep.Models;

namespace True_Dive_Deep.Data
{
    public class TrueDiveDeepContext : DbContext
    {
        public DbSet<BCD> BCDs { get; set; }
        public DbSet<DivingSuit> DivingSuits { get; set; }
        public DbSet<Fin> Fins { get; set; }
        public DbSet<Mask_Snorkel> Mask_Snorkels { get; set; }
        public DbSet<RegulatorSet> RegulatorSets { get; set; }
        public DbSet<Tank> Tanks { get; set; }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BCD>().ToTable("BCD");
            modelBuilder.Entity<DivingSuit>().ToTable("DivingSuit");
            modelBuilder.Entity<Fin>().ToTable("Fin");
            modelBuilder.Entity<Mask_Snorkel>().ToTable("Mask_Snorkel");
            modelBuilder.Entity<RegulatorSet>().ToTable("RegulatorSet");
            modelBuilder.Entity<Tank>().ToTable("Tank");

            modelBuilder.Entity<BCD>().HasData

        }
    }
