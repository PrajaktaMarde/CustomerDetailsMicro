using CustomerContactDetailsData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerContactDetailsData.Repository
{
    public class CustomerContactDetailsRepository : Repository<CustomerContactDetails>, ICustomerContactDetailRepository
    {
        public CustomerContactDetailsRepository(CustomerContactDetailsContext context) : base(context)
        {

        }
    }
}
