namespace ServicesAccess.Interface
{
    using EntityEstacionamiento.Entidades;
    using System.Collections.Generic;

    public interface IServiceAccessEstacionamiento
    {
        List<AutoBase> GetAutos();

        List<EmpleadoBase> GetEmpleados();
    }
}
