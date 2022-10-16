using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerContactDetailsData.Models;
using CustomerContactDetailsData.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerContactDetailsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerContactDetailsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerContactDetailsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/CustomerContactDetails
        [Route("getall")]
        [HttpGet]
        public async Task<IActionResult> GetCustomerContactDetails()
        {
            return Ok(await _unitOfWork.CustomerContactDetails.GetAll());
        }

        // GET: api/CustomerContactDetails/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CustomerContactDetails
        [HttpPost]
        public async Task<IActionResult> AddCustomerContactDetails(CustomerContactDetails customerContactDetails)
        {

            bool isSaved = await _unitOfWork.CustomerContactDetails.Add(customerContactDetails);
            await _unitOfWork.CompleteAsync();
            return isSaved ? (ActionResult)Ok("Customer details added sucessfully!") : BadRequest("Customer Details aleardy Present");

        }

        // PUT: api/CustomerContactDetails/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
