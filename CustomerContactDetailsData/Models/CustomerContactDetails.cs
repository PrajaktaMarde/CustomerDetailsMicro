using System;
using System.Collections.Generic;

namespace CustomerContactDetailsData.Models
{
    public partial class CustomerContactDetails
    {
        public int CustomerId { get; set; }
        public string CustSocialSecurityNumber { get; set; }
        public string CustEmailId { get; set; }
        public string CustPhoneNumber { get; set; }
    }
}
