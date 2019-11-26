namespace WebApiServiceEstacionamiento.Controllers
{
    #region Directives
    using System;
    using System.Collections.Generic;
    using EFEstacionamiento;
    using EFEstacionamiento.Entity;
    using Microsoft.AspNetCore.Mvc;
    #endregion

    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : WebApiControllers
    {
        public AutoController(ModeloEstacionamiento context1)
        {
            this.context = context1;
        }

        // GET: api/Auto
        [HttpGet]
        public IEnumerable<Auto> Get()
        {
            return base.GetAutos();
        }

        // GET: api/Auto/5
        [HttpGet("{id}", Name = "GetAuto")]
        public IEnumerable<Auto> Get(int id)
        {
            return base.GetAutos();
        }

        // POST: api/Auto
        [HttpPost]
        public IActionResult Post([FromBody] Auto unAuto)
        {
            if (ModelState.IsValid)
            {
                Save(unAuto);
                return new CreatedAtRouteResult("GetAuto", new { id = unAuto.AutoId }, unAuto);
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
            try
            {
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
