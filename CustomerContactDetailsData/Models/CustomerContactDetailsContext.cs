using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace CustomerContactDetailsData.Models
{
    public partial class CustomerContactDetailsContext : DbContext
    {
        public CustomerContactDetailsContext()
        {
        }

        public CustomerContactDetailsContext(DbContextOptions<CustomerContactDetailsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerContactDetails> CustomerContactDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=CustomerContactDetails;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerContactDetails>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustEmailId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustPhoneNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustSocialSecurityNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
