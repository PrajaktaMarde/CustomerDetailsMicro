using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerContactDetailsData.Data.Models
{
    public class CustomerContactDetails
    {
        [Key]
        public int CustomerId { get; set; }

        public string CustSocialSecurityNumber { get; set; }

        public string CustEmailId { get; set; }

        public string CustPhoneNumber { get; set; }
    }
}
