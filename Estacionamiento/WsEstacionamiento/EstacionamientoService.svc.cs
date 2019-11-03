using EntityEstacionamiento.Entidades;
using EntityEstacionamiento.Helpers;
using EstacionamientoCore;
using System;
using System.Collections.Generic;

namespace WsEstacionamiento
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IEstacionamientoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EstacionamientoService.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class EstacionamientoService : IEstacionamientoService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public string GetListadoAutos()
        {
            return SerializationHelper.SerializeToBinaryString(new SistemaEstacionamientoCore().GetListadoAutos());
        }

        public string GetListadoEmpleados()
        {
            return SerializationHelper.SerializeToBinaryString(new SistemaEstacionamientoCore().GetListadoEmpleados());
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
