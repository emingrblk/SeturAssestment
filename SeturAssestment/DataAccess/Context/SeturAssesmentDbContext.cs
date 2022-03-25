
using Core.Entities.Concrete;
using Core.Entities.Concrete.ContactEntities;
using Entities.Concrete.ContactEntities;
using Entities.Concrete.ContactInformationEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace DataAccess.Concrete.EntityFramework
{

    public class SeturAssesmentDbContext : DbContext
    {
      
        public SeturAssesmentDbContext(DbContextOptions<SeturAssesmentDbContext> options) : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactInformation> ContactInformations { get; set; }
       
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<ReportStatus> ReportStatuses { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReportStatus>().HasData(
                new ReportStatus { Id = 1, StatusName = "Hazırlanıyor" },
                new ReportStatus { Id = 2, StatusName = "Tamamlandı" });
        }
    }
}
