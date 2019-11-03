using EntityEstacionamiento.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesAccess.Interface
{
    public interface IServiceAccessEstacionamiento
    {
        List<AutoBase> GetAutos();

        List<EmpleadoBase> GetEmpleados();
    }
}
