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
    public class TourTypeMap : IEntityTypeConfiguration<TourType>
    {
        public void Configure(EntityTypeBuilder<TourType> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.Name).HasMaxLength(50);
            builder.Property(t => t.Description).IsRequired();
            builder.Property(t => t.Description).HasMaxLength(250);
            builder.Property(t => t.CreatedDate);
            builder.Property(t => t.UpdatedDate);
            builder.ToTable("TourTypes");
        }
    }
}
