namespace EstacionamientoCore
{    
    #region Properties
    using System;
    using System.Collections.Generic;
    using EntityEstacionamiento.Entidades;
    #endregion

    public class SistemaEstacionamientoCore
    {
        public SistemaEstacionamientoCore()
        {
        }

        public void Inicializar()
        {
            this.GetListadoAutos();
        }

        public List<AutoBase> GetListadoAutos()
        {
            List<AutoBase> listAutos = new List<AutoBase>();

            try
            {
                //unSistemaSolar.Initialize(anios);
                listAutos.Add(new AutoBase
                {
                    IdAuto = 1000,
                    Patente = "CBC345",
                    Marca = "Honda",
                    Modelo = "HR-V",
                    Empleado = "Empleado 1"
                });
                listAutos.Add(new AutoBase
                {
                    IdAuto = 1000,
                    Patente = "ORMR445",
                    Marca = "Renault",
                    Modelo = "HR-V",
                    Empleado = "Empleado 2"
                });
                listAutos.Add(new AutoBase
                {
                    IdAuto = 1000,
                    Patente = "XCE984",
                    Marca = "Chevrolet",
                    Modelo = "Prisma",
                    Empleado = "Empleado 3"
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listAutos;
        }

        public List<EmpleadoBase> GetListadoEmpleados()
        {
            List<EmpleadoBase> listEmpleados = new List<EmpleadoBase>();

            try
            {
                //unSistemaSolar.Initialize(anios);
                listEmpleados.Add(new EmpleadoBase
                {
                    IdEmpleado = 1000,
                    Legajo = 150,
                    Nombre = "Micaela",
                    Apellido = "Perez",
                    Edad = 24,
                    NroCelular = ""
                });
                listEmpleados.Add(new EmpleadoBase
                {
                    IdEmpleado = 1000,
                    Legajo = 151,
                    Nombre = "Ignacio",
                    Apellido = "Pezzoli",
                    Edad = 34,
                    NroCelular = "023-45555443"
                });
                listEmpleados.Add(new EmpleadoBase
                {
                    IdEmpleado = 1000,
                    Legajo = 152,
                    Nombre = "Lidia",
                    Apellido = "Ramirez",
                    Edad = 27,
                    NroCelular = "154553334"
                });
                listEmpleados.Add(new EmpleadoBase
                {
                    IdEmpleado = 1000,
                    Legajo = 153,
                    Nombre = "Esteban",
                    Apellido = "Kenia",
                    Edad = 30,
                    NroCelular = "234443434"
                });
                listEmpleados.Add(new EmpleadoBase
                {
                    IdEmpleado = 1000,
                    Legajo = 154,
                    Nombre = "Cristian",
                    Apellido = "Scarfo",
                    Edad = 23,
                    NroCelular = "234443434-23"
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listEmpleados;
        }
    }
}
