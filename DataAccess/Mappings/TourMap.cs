using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class TourMap : IEntityTypeConfiguration<Tour>
    {
        public void Configure(EntityTypeBuilder<Tour> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Name).HasMaxLength(50);
            builder.Property(t => t.TourTypeId).IsRequired();
            builder.Property(t => t.CompanyId).IsRequired();
            builder.Property(t => t.StartTime).IsRequired();
            builder.Property(t => t.StartTime).HasMaxLength(20);
            builder.Property(t => t.FinishTime).IsRequired();
            builder.Property(t => t.FinishTime).HasMaxLength(20);
            builder.Property(t => t.PickUpTİme);
            builder.Property(t => t.PickUpTİme).HasMaxLength(20);
            builder.Property(t => t.PickUpPlace).IsRequired();
            builder.Property(t => t.PickUpPlace).HasMaxLength(50);
            builder.Property(t => t.ReturnPlace).HasMaxLength(50);
            builder.Property(t => t.Description).HasMaxLength(500);
            builder.Property(t => t.CreatedDate);
            builder.Property(t => t.UpdatedDate);
            builder.ToTable("Tours");
        }
    }
}
