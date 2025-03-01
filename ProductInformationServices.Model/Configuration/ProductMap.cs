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
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);

            // Configure properties
            builder.Property(p => p.ProductName)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(p => p.ProductDescription)
                   .HasMaxLength(1000);

            builder.Property(p => p.ProductPrice)
                   .HasColumnType("decimal(18, 2)")
                   .IsRequired();

            builder.Property(p => p.ProductStock)
                   .IsRequired();

   
            builder.HasMany(p => p.Reviews)
                   .WithOne(r => r.Product)
                   .HasForeignKey(r => r.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.Medias)
                   .WithOne(m => m.Product)
                   .HasForeignKey(m => m.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);



        }
    }
}
