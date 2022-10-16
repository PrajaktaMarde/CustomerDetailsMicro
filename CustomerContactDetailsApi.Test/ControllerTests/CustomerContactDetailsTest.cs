using CustomerContactDetailsApi.Test.MockData;
using CustomerContactDetailsAPI.Controllers;
using CustomerContactDetailsData.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentValidation;
using CustomerContactDetailsData.Models;

namespace CustomerContactDetailsApi.Test.ControllerTests
{
    public class CustomerContactDetailsTest
    {
       
        [Fact]
        public async Task GetAllAsync_ShouldReturn200Status()
        {
            /// Arrange
            var objUnitofWork = new Mock<IUnitOfWork>();
            var validator = new Mock<IValidator<CustomerContactDetails>> ();
            objUnitofWork.Setup(c => c.CustomerContactDetails.GetAll()).ReturnsAsync(CustomerContactMockData.GetCustomerDetails());
            var sut = new CustomerContactDetailsController(objUnitofWork.Object, validator.Object);

            /// Act
            var result = (OkObjectResult)await sut.GetCustomerContactDetails();


            // /// Assert
            result.StatusCode.Equals(200);
        }
    }
}
