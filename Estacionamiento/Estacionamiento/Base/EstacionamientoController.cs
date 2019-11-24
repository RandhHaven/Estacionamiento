namespace Estacionamiento.Base
{
    #region Directives
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Http;
    using ServicesAccess.Interface;
    using Estacionamiento.Models;
    using Estacionamiento.Controllers;
    using EntityEstacionamiento.Entidades;
    #endregion
    public abstract class EstacionamientoController : Controller
    {
        #region Properties
        public ILogger<HomeController> _logger { get; set; }

        public IServiceAccessEstacionamiento _IServiceAccessEstacionamiento { get; set; }

        public List<Empleado> ListadoEmpleados
        {
            get
            {
                object o = HttpContext.Session.GetObject<List<Empleado>>("ListadoEmpleados");
                return (Object.Equals(o, null)) ? new List<Empleado>() : (List<Empleado>)o;
            }
            set
            {
                HttpContext.Session.SetObject("ListadoEmpleados", value);
            }
        }

        public List<Auto> ListadoAutos
        {
            get
            {
                object o = HttpContext.Session.GetObject<List<Auto>>("ListadoAutos");
                return (Object.Equals(o, null)) ? new List<Auto>() : (List<Auto>)o;
            }
            set
            {
                HttpContext.Session.SetObject("ListadoAutos", value);
            }
        }

        #endregion

        #region Methods
        public abstract void OnInitialize(ILogger<HomeController> logger);
       
        public List<Auto> GetAutos()
        {
            List<Auto> listAuto = new List<Auto>();
            try
            {
                List<AutoBase> listAutoBase = _IServiceAccessEstacionamiento.GetAutos();

                this.GetAutoMappping(listAutoBase, ref listAuto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listAuto;
        }

        public List<Empleado> GetEmpleados()
        {
            List<Empleado> listEmpleado = new List<Empleado>();
            try
            {
                List<EmpleadoBase> listEmpleadoBase = _IServiceAccessEstacionamiento.GetEmpleados();

                this.GetEmpleadoMappping(listEmpleadoBase, ref listEmpleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listEmpleado;
        }

        public void GetAutoMappping(List<AutoBase> listaBase, ref List<Auto> lista)
        {
            try
            {
                if (!Object.Equals(listaBase, null) && listaBase.Any())
                {
                    lista = listaBase.ConvertAll(sist => new Auto
                    {
                        IdAuto = sist.IdAuto,
                        Marca = sist.Marca,
                        Modelo = sist.Modelo,
                        Patente = sist.Patente,
                        Empleado = sist.Empleado
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GetEmpleadoMappping(List<EmpleadoBase> listaBase, ref List<Empleado> lista)
        {
            try
            {
                if (!Object.Equals(listaBase, null) && listaBase.Any())
                {
                    lista = listaBase.ConvertAll(sist => new Empleado
                    {
                        IdEmpleado = sist.IdEmpleado,
                        Legajo = sist.Legajo,
                        Nombre = sist.Nombre,
                        Apellido = sist.Apellido,
                        Edad = sist.Edad,
                        NroCelular = sist.NroCelular
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CrearAuto()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarAuto(int idAuto)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditarAuto(int idAuto)
        {            
            try
            {
                
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public void CrearEmpleado()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditarEmpleado(int idEmpleado)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}