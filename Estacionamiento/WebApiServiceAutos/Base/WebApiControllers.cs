using EFEstacionamiento;
using EFEstacionamiento.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebApiServiceEstacionamiento.Controllers
{
    public abstract class WebApiControllers : ControllerBase
    {
        #region Properties
        public ModeloEstacionamiento context;
        #endregion


        public virtual void Save(Auto unAuto)
        {
            context.Autos.Add(unAuto);
            context.SaveChanges();
        }

        public virtual IEnumerable<Auto> GetAutos()
        {
            return context.Autos.ToList();
        }
    }
}
