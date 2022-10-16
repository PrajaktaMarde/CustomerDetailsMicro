using CustomerContactDetailsData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerContactDetailsData.Repository
{
    public class CustomerContactDetailsRepository : Repository<CustomerContactDetails>, ICustomerContactDetailRepository
    {
        public CustomerContactDetailsRepository(CustomerContactDetailsContext context) : base(context)
        {

        }

        public override async Task<bool> Add(CustomerContactDetails customerContactDetails)
        {
            try
            {
                var existingCustomer = await dbSet.Where(x => x.CustSocialSecurityNumber == customerContactDetails.CustSocialSecurityNumber)
                                                    .FirstOrDefaultAsync();

                if(existingCustomer == null)
                {
                    await dbSet.AddAsync(customerContactDetails);
                    return true;

                }
                return false;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
