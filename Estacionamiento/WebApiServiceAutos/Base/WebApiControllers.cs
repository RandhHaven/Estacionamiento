namespace WebApiServiceEstacionamiento.Controllers
{
    #region Directives
    using EstacionamientoEF;
    using EstacionamientoEF.Entity;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    #endregion

    public abstract class WebApiControllers : ControllerBase
    {
        #region Properties
        public EstacionamientoModel context;
        #endregion

        #region Methods
        public virtual void Save(Auto unAuto)
        {
            context.Autos.Add(unAuto);
            context.SaveChanges();
        }

        public virtual IEnumerable<Auto> GetAutos()
        {
            List<Auto> list = new List<Auto>();
            IQueryable<Auto> rtn = from temp in context.Autos select temp;
            list = rtn.ToList();
            return list.ToList();
        }

        public virtual IEnumerable<Empleado> GetEmpleados()
        {
            return context.Empleados.ToList();
        }

        public virtual void Save(Empleado unEmpleado)
        {
            context.Empleados.Add(unEmpleado);
            context.SaveChanges();
        }
        #endregion
    }
}
