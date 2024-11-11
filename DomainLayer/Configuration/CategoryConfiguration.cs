﻿using System;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);

            builder.Property(c => c.CategoryName)
             .IsRequired()
             .HasMaxLength(100);

            builder.HasMany(c => c.Users)
                .WithMany(c => c.Categories);

            builder.HasMany(c => c.Transactions)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.TransactionId);
        
        }
    }
}

