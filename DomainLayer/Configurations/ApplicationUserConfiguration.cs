using System;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.Configuration
{
	public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasKey(u => u.UserId);

            builder.Property(u => u.TelegramUserId)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(u => u.UserName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(u => u.CreatedDate)
                   .IsRequired();

            builder.HasMany(c => c.Categories)
                   .WithMany(c => c.Users);

            builder.HasMany(u => u.Transactions)
                   .WithOne(t => t.ApplicationUser)
                   .HasForeignKey(t => t.UserId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

