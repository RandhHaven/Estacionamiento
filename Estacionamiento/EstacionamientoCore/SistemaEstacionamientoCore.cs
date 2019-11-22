namespace EstacionamientoCore
{    
    #region Properties
    using System;
    using System.Collections.Generic;
    using EFEstacionamiento;
    using EFEstacionamiento.Entity;
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

        public List<Auto> GetListAuto()
        {
            List<Auto> list = new List<Auto>();
            try
            {
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
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
                    IdAuto = 1001,
                    Patente = "ORMR445",
                    Marca = "Renault",
                    Modelo = "Kangoo",
                    Empleado = "Empleado 2"
                });
                listAutos.Add(new AutoBase
                {
                    IdAuto = 1002,
                    Patente = "XCE984",
                    Marca = "Chevrolet",
                    Modelo = "Prisma",
                    Empleado = "Empleado 3"
                });
                listAutos.Add(new AutoBase
                {
                    IdAuto = 1003,
                    Patente = "MUJ234",
                    Marca = "Chevrolet",
                    Modelo = "Cruze",
                    Empleado = "Empleado 4"
                });
                listAutos.Add(new AutoBase
                {
                    IdAuto = 1004,
                    Patente = "ORZ903",
                    Marca = "Fiat",
                    Modelo = "Punto",
                    Empleado = "Empleado 5"
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
                    NroCelular = "45341223"
                });
                listEmpleados.Add(new EmpleadoBase
                {
                    IdEmpleado = 1001,
                    Legajo = 151,
                    Nombre = "Ignacio",
                    Apellido = "Pezzoli",
                    Edad = 34,
                    NroCelular = "023-45555443"
                });
                listEmpleados.Add(new EmpleadoBase
                {
                    IdEmpleado = 1002,
                    Legajo = 152,
                    Nombre = "Lidia",
                    Apellido = "Ramirez",
                    Edad = 27,
                    NroCelular = "154553334"
                });
                listEmpleados.Add(new EmpleadoBase
                {
                    IdEmpleado = 1003,
                    Legajo = 153,
                    Nombre = "Esteban",
                    Apellido = "Kenia",
                    Edad = 30,
                    NroCelular = "234443434"
                });
                listEmpleados.Add(new EmpleadoBase
                {
                    IdEmpleado = 1004,
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

        public string EliminarAuto(int idAuto)
        {
            try
            {
            
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return String.Empty;
        }

        public string CrearAuto()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return String.Empty;
        }

        public string EditarAuto(int idAuto)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return String.Empty;
        }

        public string EliminarEmpleado(int idEmpleado)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return String.Empty;
        }

        public string CrearEmpleado()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return String.Empty;
        }

        public string EditarEmpleado(int idEmpleado)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return String.Empty;
        }
    }
}
