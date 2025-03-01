using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductInformationServices.Model.Metadata;

namespace ProductInformationServices.Model.Configuration
{
    public class ReviewMap : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(r => r.ReviewId);

            // Configure properties
            builder.Property(r => r.ReviewerName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(r => r.Content)
                   .IsRequired()
                   .HasMaxLength(1000);

            builder.Property(r => r.Rating)
                   .IsRequired();

            // Configure many-to-one relationship with Product
            builder.HasOne(r => r.Product).WithMany(p => p.Reviews).HasForeignKey(r => r.ProductId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
