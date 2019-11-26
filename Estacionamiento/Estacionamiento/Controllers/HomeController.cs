using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Estacionamiento.Models;
using Estacionamiento.Base;
using ServicesAccess;
using Microsoft.AspNetCore.Authorization;

namespace Estacionamiento.Controllers
{
    public class HomeController : EstacionamientoController
    {
        public HomeController(ILogger<HomeController> logger)
        {
            this.OnInitialize(logger);
        }

        public override void OnInitialize(ILogger<HomeController> logger)
        {
            _IServiceAccessEstacionamiento = new ServiceAccessEstacionamiento();
            this._logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ViewAutos()
        {
            List<Auto> listaAutos = new List<Auto>();
            try
            {
                listaAutos = this.GetAutos();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View(listaAutos);
        }

        [HttpGet]
        public ActionResult ViewEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();
            try
            {
                lista = this.GetEmpleados();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View(lista);
        }

        [HttpGet]
        public ActionResult ViewEditarEmpleado()
        {
            try
            {
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View();
        }

        [HttpPost]
        public ActionResult ViewEditarEmpleado(int idEmpleado)
        {
            try
            {
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View();
        }

        
        [HttpGet]
        public ActionResult ViewCrearEmpleado()
        {
            try
            {
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View();
        }

        [HttpGet]
        public ActionResult ViewEliminarEmpleado(int idEmpleado)
        {
            try
            {
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View();
        }

        [HttpGet]
        public ActionResult ViewEditarAuto(int idAuto)
        {
            try
            {
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View();
        }

        [HttpGet]
        public ActionResult ViewCrearAuto()
        {
            try
            {
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View();
        }

        [HttpPost]
        public ActionResult ViewEliminarAuto(int idAuto)
        {
            try
            {
                this.EliminarAuto(idAuto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw ex;
            }
            return View();
        }

        [HttpGet]
        public ActionResult ViewEliminarAuto()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
