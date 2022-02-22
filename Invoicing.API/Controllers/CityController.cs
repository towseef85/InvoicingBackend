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
    public class CityController : ControllerBase
    {
        private readonly IWrapper _wrapper;

        public CityController(IWrapper wrapper)
        {
            _wrapper = wrapper;
        }

        /// <summary>
        /// Get All Cities
        /// </summary>
        /// <response code="200">Successfully Fetched City Collection</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetCitiesDto))]
        public async Task<IActionResult> GetAsync()
        {
            var cities = await _wrapper.CityBL.GetAsync();
            return Ok(cities);
        }
        /// <summary>
        /// Add City
        /// </summary>
        /// <response code="200">Successfully Created City</response>
        [HttpPost]
        public async Task<IActionResult> AddAsync(PostCityDto postCityDto)
        {
            if (ModelState.IsValid)
            {
                await _wrapper.CityBL.AddAsync(postCityDto);
                return Ok(postCityDto.Id);
            }
            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }
    }
}
