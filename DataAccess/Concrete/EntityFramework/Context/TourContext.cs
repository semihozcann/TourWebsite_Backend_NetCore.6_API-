using Core.Entities.Concrete;
using DataAccess.Mappings;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class TourContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-5R6CJJ3\SQLEXPRESS;Database=TourWebsiteDb;Trusted_Connection=true");
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourImage> TourImages { get; set; }
        public DbSet<TourType> TourTypes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CompanyMap());
            builder.ApplyConfiguration(new ImageMap());
            builder.ApplyConfiguration(new TourImageMap());
            builder.ApplyConfiguration(new TourMap());
            builder.ApplyConfiguration(new TourTypeMap());
            builder.ApplyConfiguration(new CommentMap());
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new OperationClaimMap());
            builder.ApplyConfiguration(new UserOperationClaimMap());
        }

    }
}
