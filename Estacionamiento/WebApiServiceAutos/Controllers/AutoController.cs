namespace WebApiServiceEstacionamiento.Controllers
{
    #region Directives
    using System;
    using System.Collections.Generic;
    using EFEstacionamiento;
    using EFEstacionamiento.Entity;
    using Microsoft.AspNetCore.Mvc;
    #endregion

    [Produces("application/json")]
    [Route("api/[controller]")]
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
