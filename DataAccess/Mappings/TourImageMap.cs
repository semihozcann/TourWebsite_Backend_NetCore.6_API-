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
    public class TourImageMap : IEntityTypeConfiguration<TourImage>
    {
        public void Configure(EntityTypeBuilder<TourImage> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.ImageId);
            builder.Property(t => t.TourId);
            builder.Property(t => t.CreatedDate);
            builder.Property(t => t.UpdatedDate);
            builder.ToTable("TourImages");
        }
    }
}
