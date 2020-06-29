using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Catalog.Cars;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _manageCarService;
        public CarController(ICarService manageCarService)
        {
            _manageCarService = manageCarService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var car = await _manageCarService.GetAll();
            return Ok(car);
        }
        [HttpGet("{id_xe}")]
        public async Task<IActionResult> GetById(int id_xe)
        {
            var car = await _manageCarService.GetById(id_xe);
            if (car == null) return BadRequest("Cannot find car");
            return Ok(car);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateCar request)
        {
            var carId = await _manageCarService.Create(request);
            //if (carId == 0)
            //    return BadRequest();
            var car = await _manageCarService.GetById(carId);
            return CreatedAtAction(nameof(GetById), new { id = carId }, car);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]EditCar request)
        {
            var result = await _manageCarService.Update(request);
            if (result == 0) return BadRequest();
            return Ok();
        }
        [HttpDelete("{id_xe}")]
        public async Task<IActionResult> Delete(int id_xe)
        {
            var result = await _manageCarService.Delete(id_xe);
            if (result == 0) return BadRequest();
            return Ok();
        }
    }
}