using System;
using System.Linq;
using EventSchedule.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventSchedule.Infraestructure.Data.Context
{
    public class EventScheduleContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        private readonly string MysqlConnection =
            "Server=localhost; database=event_schedule; UID=root; password=root; Port=3308; SslMode=none";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseMySql(MysqlConnection);
            }
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries()
                .Where(entry => entry.Entity.GetType().GetProperty("CreatedAt") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedAt").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreatedAt").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}