using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class InheritanceMappingContext : DbContext
    {
        public InheritanceMappingContext()
        {
        }

        public InheritanceMappingContext(DbContextOptions options) : base(options) { }
        public DbSet<BillingDetail> BillingDetails { get; set; }
        public DbSet<BankAccount> BankAccounts  { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CreditCard>();
            builder.Entity<BillingDetail>()
                .HasDiscriminator<string>("BillingDetailType")
                .HasValue("BankAccount")
                .HasValue("CreditCard");
        }
    }
}
