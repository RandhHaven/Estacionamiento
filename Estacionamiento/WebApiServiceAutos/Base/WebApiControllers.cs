namespace WebApiServiceEstacionamiento.Controllers
{
    using EFEstacionamiento;
    using EFEstacionamiento.Entity;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class WebApiControllers : ControllerBase
    {
        #region Properties
        public ModeloEstacionamiento context;
        #endregion

        #region Methods
        public virtual void Save(Auto unAuto)
        {
            context.Autos.Add(unAuto);
            context.SaveChanges();
        }

        public virtual IEnumerable<Auto> GetAutos()
        {
            return context.Autos.ToList();
        }

        public virtual IEnumerable<Empleado> GetEmpleados()
        {
            return context.Empleados.ToList();
        }
        #endregion
    }
}
