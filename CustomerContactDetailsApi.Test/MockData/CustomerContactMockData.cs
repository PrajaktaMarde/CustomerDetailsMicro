using CustomerContactDetailsData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerContactDetailsApi.Test.MockData
{
    public class CustomerContactMockData
    {
        public static List<CustomerContactDetails> GetCustomerDetails()
        {
            return new List<CustomerContactDetails>{
             new CustomerContactDetails{
                 CustomerId = 1,
                 CustSocialSecurityNumber = "7894561230",
                 CustEmailId ="abc@xyz.com",
                 CustPhoneNumber = "+46789456123"

             },
              new CustomerContactDetails{
                 CustomerId = 2,
                 CustSocialSecurityNumber = "7894561238",
                 CustEmailId ="abc1@xyz.com",
                 CustPhoneNumber = "+46789456173"

             },
              new CustomerContactDetails{
                 CustomerId = 3,
                 CustSocialSecurityNumber = "7894561239",
                 CustEmailId ="abc2@xyz.com",
                 CustPhoneNumber = "+467894561889"

             },
         };
        }
    }
}
