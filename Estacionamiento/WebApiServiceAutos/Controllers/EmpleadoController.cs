using System.Collections.Generic;
using EFEstacionamiento.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebApiServiceEstacionamiento.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : WebApiControllers
    {
        // GET: api/Empleado
        [HttpGet]
        public IEnumerable<Empleado> Get()
        {
            return base.GetEmpleados();
        }

        // GET: api/Empleado/5
        [HttpGet("{id}", Name = "GetEmpleado")]
        public IEnumerable<Empleado> Get(int id)
        {
            return base.GetEmpleados();
        }

        // POST: api/Empleado
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Empleado/5
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
