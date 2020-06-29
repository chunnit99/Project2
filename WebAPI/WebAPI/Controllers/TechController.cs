using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Catalog.Technicians;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechController : ControllerBase
    {
        private readonly ITechService _manageTechService;
        public TechController( ITechService manageTechService)
        {
            _manageTechService = manageTechService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var tech = await _manageTechService.GetAll();
            return Ok(tech);
        }
        [HttpGet("{id_ktv}")]
        public async Task<IActionResult> GetById(int id_ktv)
        {
            var tech = await _manageTechService.GetById(id_ktv);
            if (tech == null) return BadRequest("Cannot find technician");
            return Ok(tech);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateTech request)
        {
            var techId = await _manageTechService.Create(request);
           // if (techId == 0)
               // return BadRequest();
            var tech= await _manageTechService.GetById(techId);
            return CreatedAtAction(nameof(GetById), new { id = techId }, tech);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody]EditTech request)
        {
            var result = await _manageTechService.Update(request);
            if (result == 0) return BadRequest();
            return Ok();
        }
        [HttpDelete("{id_ktv}")]
        public async Task<IActionResult> Delete(int id_ktv)
        {
            var result = await _manageTechService.Delete(id_ktv);
            if (result == 0) return BadRequest();
            return Ok();
        }
    }
}
