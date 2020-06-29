using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Catalog;
using WebAPI.Catalog.Drivers.Dtos;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IUserService _manageDriverService;
        public DriverController(IUserService manageDriverService)
        {
            _manageDriverService = manageDriverService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var driver = await _manageDriverService.GetAll();
            return Ok(driver);
        }
        [HttpGet("{id_lg_xe}")]
        public async Task<IActionResult> GetById(int id_lg_xe)
        {
            var driver = await _manageDriverService.GetById(id_lg_xe);
            if (driver == null) return BadRequest("Cannot find driver");
            return Ok(driver);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateDriver request)
        {
            var driverId = await _manageDriverService.Create(request);
           // if (driverId == 0)
               // return BadRequest();
            var driver = await _manageDriverService.GetById(driverId);
            return CreatedAtAction(nameof(GetById), new { id = driverId }, driver);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]EditDriver request)
        {
            var result = await _manageDriverService.Update(request);
            if (result == 0) return BadRequest();
            return Ok();
        }
        [HttpDelete("{id_lg_xe}")]
        public async Task<IActionResult> Delete(int id_lg_xe)
        {
            var result = await _manageDriverService.Delete(id_lg_xe);
            if (result == 0) return BadRequest();
            return Ok();
        }
    }
}