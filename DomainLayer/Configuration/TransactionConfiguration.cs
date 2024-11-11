using System;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(t => t.TransactionId);

            builder.HasOne(t => t.ApplicationUser)
              .WithMany(u => u.Transactions)
              .HasForeignKey(t => t.UserId)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Category)
               .WithMany(t => t.Transactions)
               .HasForeignKey(t => t.CategoryId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.Property(t => t.Amount)
               .IsRequired()
               .HasPrecision(18, 2);

            builder.Property(t => t.TransactionDate)
              .IsRequired();

            builder.Property(t => t.Description)
                   .HasMaxLength(500);
        }
    }
}

