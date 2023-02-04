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
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.TourId);
            builder.Property(c => c.UserId);
            builder.Property(c => c.Details).IsRequired();
            builder.Property(c => c.Details).HasMaxLength(500);
            builder.Property(c => c.Point).IsRequired();
            builder.Property(c => c.Point).HasMaxLength(1);
            builder.Property(t => t.CreatedDate);
            builder.Property(t => t.UpdatedDate);
            builder.ToTable("Comments");
        }
    }
}
