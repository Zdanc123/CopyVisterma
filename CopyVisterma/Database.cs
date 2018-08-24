using CopyVisterma.Entities;
using CopyVisterma.Seed;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CopyVisterma
{
    public class Database : DbContext
    {
        private static readonly ILoggerFactory _loggerFactory = new LoggerFactory()
            .AddConsole((s, l) => l == LogLevel.Debug && s.EndsWith("Command"));

        public DbSet<Client> Clients { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<BillingPeriod> BillingPeriods { get; set; }
        public DbSet<ClientType> ClientTypes { get; set; }
        public DbSet<ClientTechnician> ClientTechnicians { get; set; }
        public DbSet<ServiceTechnician> ServiceTechnicians { get; set; }

        public Database(DbContextOptions<Database> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder
                .EnableSensitiveDataLogging()
                .UseLoggerFactory(_loggerFactory);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>()
                .HasData(ClientsSeed.Clients);

            modelBuilder.Entity<ServiceTechnician>()
                .HasData(ServiceTechniciansSeed.ServiceTechnicians);

            modelBuilder.Entity<ClientType>()
                .HasData(ClientTypesSeed.ClientTypes);

            modelBuilder.Entity<Building>()
                .HasData(BuildingsSeed.Buildings);

            modelBuilder.Entity<BillingPeriod>()
                .HasData(BillingPeriodsSeed.BillingPeriods);

            //    modelBuilder.Entity<Client>()
            //        .HasOne<IdentityUser>(s => s.PersonGuardian)
            //        .WithMany()
            //        .HasForeignKey(s => s.PersonGuardianId);

            //    modelBuilder.Entity<Client>()
            //        .HasOne<IdentityUser>(s => s.PersonHeating)
            //        .WithMany()
            //        .HasForeignKey(s => s.PersonHeatingId);

            //    modelBuilder.Entity<Client>()
            //        .HasOne<IdentityUser>(s => s.PersonWater)
            //        .WithMany()
            //        .HasForeignKey(s => s.PersonWaterId);

            //    modelBuilder.Entity<ClientTechnician>()
            //        .HasKey(s => new { s.ClientId, s.ServiceTechnicianId });

            //    modelBuilder.Entity<ClientTechnician>()
            //        .HasOne(s => s.Client)
            //        .WithMany(s => s.ClientsTechnicians)
            //        .HasForeignKey(s => s.ClientId);

            //    modelBuilder.Entity<ClientTechnician>()
            //        .HasOne(s => s.ServiceTechnician)
            //        .WithMany(s => s.ClientsTechnicians)
            //        .HasForeignKey(s => s.ServiceTechnicianId);

            //    modelBuilder.Entity<Employee>()
            //        .HasOne<Client>(s => s.Client)
            //        .WithMany(s => s.Employees)
            //        .HasForeignKey(s => s.ClientId)
            //        .OnDelete(DeleteBehavior.Cascade);

            //    modelBuilder.Entity<Client>()
            //        .HasOne<ClientType>(s => s.Type)
            //        .WithMany(s => s.Clients)
            //        .HasForeignKey(s => s.TypeId)
            //        .OnDelete(DeleteBehavior.ClientSetNull);

            //    modelBuilder.Entity<Building>()
            //        .HasOne<Client>(s => s.Client)
            //        .WithMany(s => s.Buildings)
            //        .HasForeignKey(s => s.ClientId)
            //        .OnDelete(DeleteBehavior.Cascade);

            //    modelBuilder.Entity<BillingPeriod>()
            //        .HasOne<Building>(s => s.Building)
            //        .WithMany(s => s.BillingPeriods)
            //        .HasForeignKey(s => s.BuildingId)
            //        .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
