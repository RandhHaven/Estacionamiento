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
        public virtual void Save(Car unAuto)
        {
            context.Autos.Add(unAuto);
            context.SaveChanges();
        }

        public virtual IEnumerable<Car> GetAutos()
        {
            List<Car> list = new List<Car>();
            IQueryable<Car> rtn = from temp in context.Autos select temp;
            list = rtn.ToList();
            return list.ToList();
        }

        public virtual IEnumerable<Employee> GetEmpleados()
        {
            return context.Empleados.ToList();
        }

        public virtual void Save(Employee unEmpleado)
        {
            context.Empleados.Add(unEmpleado);
            context.SaveChanges();
        }
        #endregion
    }
}
