using FluentValidation;
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
    public class CustomerContactDetailsValidator : AbstractValidator<CustomerContactDetails>
    {
        public CustomerContactDetailsValidator()
        {

            RuleFor(x => x.CustSocialSecurityNumber).NotNull().NotEmpty().MinimumLength(10).WithMessage(" Social Security Number must not be less than 10 characters.").MaximumLength(12).WithMessage(" PhoneNumber must not exceed 12 characters.");
            RuleFor(x => x.CustEmailId).EmailAddress();
            RuleFor(x => x.CustPhoneNumber).MaximumLength(12).WithMessage(" PhoneNumber must not exceed 12 characters.").MinimumLength(9).WithMessage(" PhoneNumber must not be less than 9 characters.")
                .Matches(@"^([\\+]?46[-]?|[0])?[1-9][0-9]{8}$");
        }
    }
}
