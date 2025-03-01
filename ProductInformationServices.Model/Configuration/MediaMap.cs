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
    public class MediaMap : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            // Set the primary key
            builder.HasKey(m => m.MediaId);

            // Configure properties
            builder.Property(m => m.Url)
                   .IsRequired()
                   .HasMaxLength(500);

            builder.Property(m => m.Type)
                   .IsRequired()
                   .HasMaxLength(50);

            // Configure many-to-one relationship with Product
            builder.HasOne(m => m.Product)
                   .WithMany(p => p.Medias)
                   .HasForeignKey(m => m.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
