using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFEstacionamiento.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiServiceEstacionamiento.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : WebApiControllers
    {
        // GET: api/Auto
        [HttpGet]
        public IEnumerable<Auto> Get()
        {
            return base.Get();
        }

        // GET: api/Auto/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Auto
        [HttpPost]
        public IActionResult Post([FromBody] Auto unAuto)
        {
            if (ModelState.IsValid)
            {
                Save(unAuto);
               
                return new CreatedAtRouteResult("Get", new { id = unAuto.AutoId }, unAuto);
            }

            return BadRequest(ModelState);
        }

        // PUT: api/Auto/5
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
