using System;
using System.Collections.Generic;
using FluentValidation.Results;
using System.Linq;
using System.Threading.Tasks;
using CustomerContactDetailsData.Models;
using CustomerContactDetailsData.UnitOfWork;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerContactDetailsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerContactDetailsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private IValidator<CustomerContactDetails> _validator;

        public CustomerContactDetailsController(IUnitOfWork unitOfWork, IValidator<CustomerContactDetails> validator)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
        }
        // GET: api/CustomerContactDetails
        [Route("getall")]
        [HttpGet]
        public async Task<IActionResult> GetCustomerContactDetails()
        {
            return Ok(await _unitOfWork.CustomerContactDetails.GetAll());
        }

        // GET: api/CustomerContactDetails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerContactDetailsById(int id)
        {
            var customerDetails = await _unitOfWork.CustomerContactDetails.GetById(id);
            return (customerDetails == null) ? (ActionResult)NotFound() : Ok(customerDetails);

        }

        // POST: api/CustomerContactDetails
        [HttpPost]
        public async Task<IActionResult> AddCustomerContactDetails(CustomerContactDetails customerContactDetails)
        {
            ValidationResult result = await _validator.ValidateAsync(customerContactDetails);
            if (result.IsValid)
            {
                bool isSaved = await _unitOfWork.CustomerContactDetails.Add(customerContactDetails);
                await _unitOfWork.CompleteAsync();
                return isSaved ? (ActionResult)Ok("Customer details added sucessfully!") : BadRequest("Customer Already Exists");

            }
            else
            {
                string errorMessage = null;

                foreach (var error in result.Errors)
                {
                    errorMessage += error.ErrorMessage;
                }
                return BadRequest(errorMessage);
            }
        }

        // PUT: api/CustomerContactDetails/
        [HttpPut]
        public async Task<IActionResult> UpdateCustomerContactDetails(CustomerContactDetails customerContactDetails)
        {
            
                bool isUpdated = await _unitOfWork.CustomerContactDetails.Update(customerContactDetails);
                await _unitOfWork.CompleteAsync();
                return isUpdated ? (ActionResult)Ok("Customer details updated sucessfully!") : BadRequest("Error in updating Customer Details"); ;

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _unitOfWork.CustomerContactDetails.GetById(id);

            if (item == null)
                return BadRequest();

            bool isDeleted = _unitOfWork.CustomerContactDetails.Remove(item);
            await _unitOfWork.CompleteAsync();

            return  isDeleted ? (ActionResult)Ok("Customer details deleted sucessfully!") : BadRequest();
        }
    }
}
