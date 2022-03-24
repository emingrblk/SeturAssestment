
using Core.Entities.Concrete;
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
        
    }
}
