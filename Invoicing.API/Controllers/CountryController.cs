using Invoicing.Contracts;
using Invoicing.Models.Api;
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
    public class CountryController : ControllerBase
    {
        private readonly IWrapper _wrapper;

        public CountryController(IWrapper wrapper)
        {
            _wrapper = wrapper;
        }

        /// <summary>
        /// Get All Countries
        /// </summary>
        /// <response code="200">Successfully Fetched Country Collection</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetCountriesDto))]
        public async Task<IActionResult> GetAsync()
        {
            var countries = await _wrapper.CountryBL.GetAsync();
            return Ok(countries);
        }
        /// <summary>
        /// Add Country
        /// </summary>
        /// <response code="200">Successfully Created country</response>
        [HttpPost]
        public async Task<IActionResult> AddAsync(PostCountryDto postCountryDto)
        {
            if(ModelState.IsValid)
            {
                 await _wrapper.CountryBL.AddAsync(postCountryDto);
                return Ok(postCountryDto.Id);
            }
            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

    }
}
