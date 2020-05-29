namespace EstacionamientoNetCore
{
    #region Assemblies
    using EstacionamientoEntity.Entidades;
    using System;
    using System.Collections.Generic;
    #endregion

    #region Class Core
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

        public List<EstacionamientoEF.Entity.Employee> GetListadoEmpleados()
        {
            List<EstacionamientoEF.Entity.Employee> listEmpleados = new List<EstacionamientoEF.Entity.Employee>();            
            try
            {
                listEmpleados = APIS.APIEmployee.GetEmployees("", "", "Employee");
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
    #endregion
}
