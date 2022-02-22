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
    public class InventoryItemsController : ControllerBase
    {
        private readonly IWrapper _wrapper;

        public InventoryItemsController(IWrapper wrapper)
        {
            _wrapper = wrapper;
        }

        /// <summary>
        /// Get All Inventory Items
        /// </summary>
        /// <response code="200">Successfully Fetched Customers Collection</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetInventoryItemsDto))]
        public async Task<IActionResult> GetAsync()
        {
            var inventoryitems = await _wrapper.InventoryItemBL.GetAsync();
            return Ok(inventoryitems);
        }
        /// <summary>
        /// Add Inventory Items
        /// </summary>
        /// <response code="200">Successfully Created Inventory Item</response>
        [HttpPost]
        public async Task<IActionResult> AddAsync(PostInventoryItemDto postInventoryItemDto)
        {
            if (ModelState.IsValid)
            {
                await _wrapper.InventoryItemBL.AddAsync(postInventoryItemDto);
                return Ok(postInventoryItemDto.Id);
            }
            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }
    }
}
