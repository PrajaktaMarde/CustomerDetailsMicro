using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public void Post([FromBody] string value)
        {
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
