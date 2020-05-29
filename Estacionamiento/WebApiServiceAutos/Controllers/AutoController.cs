namespace WebApiServiceEstacionamiento.Controllers
{
    #region Directives
    using System;
    using System.Collections.Generic;
    using EstacionamientoEF;
    using EstacionamientoEF.Entity;
    using Microsoft.AspNetCore.Mvc;
    #endregion

    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : WebApiControllers
    {
        public AutoController(EstacionamientoModel context1)
        {
            this.context = context1;
        }

        // GET: api/Auto
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return base.GetAutos();
        }

        // GET: api/Auto/5
        [HttpGet("{id}", Name = "GetAuto")]
        public IEnumerable<Car> Get(int id)
        {
            return base.GetAutos();
        }

        // POST: api/Auto
        [HttpPost]
        public IActionResult Post([FromBody] Car unAuto)
        {
            if (ModelState.IsValid)
            {
                Save(unAuto);
                return new CreatedAtRouteResult("GetAuto", new { id = unAuto.CarId }, unAuto);
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
                //base.rem
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Save(Car unAuto)
        {
            base.Save(unAuto);
        }
    }
}
