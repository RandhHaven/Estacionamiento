namespace WebApiServiceEstacionamiento.Controllers
{
    using System.Collections.Generic;
    using EstacionamientoEF.Entity;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : WebApiControllers
    {
        // GET: api/Empleado
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return base.GetEmpleados();
        }

        // GET: api/Empleado/5
        [HttpGet("{id}", Name = "GetEmpleado")]
        public IEnumerable<Employee> Get(int id)
        {
            return base.GetEmpleados();
        }

        // POST: api/Empleado
        [HttpPost]
        public IActionResult Post([FromBody] Employee unEmpleado)
        {
            if (ModelState.IsValid)
            {
                Save(unEmpleado);
                return new CreatedAtRouteResult("GetEmpleado", new { id = unEmpleado.EmployeeId }, unEmpleado);
            }
            return BadRequest(ModelState);
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
