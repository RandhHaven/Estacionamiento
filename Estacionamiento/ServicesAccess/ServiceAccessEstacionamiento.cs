using EntityEstacionamiento.Entidades;
using EntityEstacionamiento.Helpers;
using ServicesAccess.Interface;
using System.Collections.Generic;
using WsEstacionamiento;

namespace ServicesAccess
{
    public class ServiceAccessEstacionamiento : AServiceAccess, IServiceAccessEstacionamiento
    {
        EstacionamientoService ws = new EstacionamientoService();

        public List<AutoBase> GetAutos()
        {
            result = ws.GetListadoAutos();
            return (List<AutoBase>)Deserialize();
        }

        public List<EmpleadoBase> GetEmpleados()
        {
            result = ws.GetListadoEmpleados();
            return (List<EmpleadoBase>)Deserialize();
        }
    }
}
