using Invoicing.Contracts;
using Invoicing.Models.Api.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoicing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IWrapper _wrapper;

        public CustomerController(IWrapper wrapper)
        {
            _wrapper = wrapper;
        }

        /// <summary>
        /// Get All Cuatomers
        /// </summary>
        /// <response code="200">Successfully Fetched Customers Collection</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetCustomersDto))]
        public async Task<IActionResult> GetAsync()
        {
            var customers = await _wrapper.CustomerBL.GetAsync();
            return Ok(customers);
        }
        /// <summary>
        /// Add Customer
        /// </summary>
        /// <response code="200">Successfully Created Customer</response>
        [HttpPost]
        public async Task<IActionResult> AddAsync(PostCustomerDto postCustomerDto)
        {
            if (ModelState.IsValid)
            {
                await _wrapper.CustomerBL.AddAsync(postCustomerDto);
                return Ok(postCustomerDto.Id);
            }
            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }
    }
}
