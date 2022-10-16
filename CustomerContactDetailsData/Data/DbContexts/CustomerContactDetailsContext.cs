using CustomerContactDetailsData.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerContactDetailsData.Data.DbContexts
{
    public class CustomerContactDetailsContext : DbContext
    {
        public CustomerContactDetailsContext(DbContextOptions<CustomerContactDetailsContext> options) : base(options)
        {
        }
        public DbSet<CustomerContactDetails> CustomerContactDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerContactDetails>().HasData(
                new CustomerContactDetails
                {
                    
                    CustSocialSecurityNumber = "789456989",
                    CustEmailId = "abc@gmail.com",
                    CustPhoneNumber = "+46025896389",
                },
                new CustomerContactDetails
                {
                    
                    CustSocialSecurityNumber = "789456990",
                    CustEmailId = "abc1@gmail.com",
                    CustPhoneNumber = "025894344",
                },
                new CustomerContactDetails
                {
                   
                    CustSocialSecurityNumber = "789456991",
                    CustEmailId = "abc2@gmail.com",
                    CustPhoneNumber = "+46025896478",
                }
            );
        }
    }
}
