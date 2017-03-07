using Microsoft.AspNetCore.Routing;
using Microsoft.Owin.Infrastructure;
using ProyectoDiscos.DataAccessLayer;
using ProyectoDiscos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ProyectoDiscos.Controllers
{
    //Controlador de la pagina principal
    public class PaginaController : Controller
    {
        // GET: Pagina
        // ActionResult que devuelve la vista Index del controlador Página
        public ActionResult Index()
        {
            return View();
        }

        //Comprueba si el log in del Usuario a sido correcto
        [HttpPost]
        public ActionResult Login(Cliente cliente)
        {
                Cliente authUser = null;
                using (DiscosDAL discosDAL = new DiscosDAL())
                {
                    authUser = discosDAL.Clientes.FirstOrDefault(u => u.Nombre == cliente.Nombre && u.Password == cliente.Password);
                }

                if (authUser != null)
                {
                    FormsAuthentication.SetAuthCookie(authUser.Nombre, false);
                    Session["Nombre"] = authUser.Nombre;
                    Session["IdCliente"] = authUser.id;
                    return RedirectToAction("Lista", "Lista");
                }
                else
                {
                    ModelState.AddModelError("CredentialError", "Usuario o contraseña incorrectos");
                    return RedirectToAction("Index", "Pagina");
                }
            
        }

        //Registra a un nuevo usuario y hace un log in
        [HttpPost]
        public ActionResult Register(Cliente cliente)
        {
            DateTime date = DateTime.Now;
            cliente.FechaRegistro = date;
            if (ModelState.IsValid)
            {
                using (var context = new DiscosDAL())
                {
                    context.Clientes.Add(cliente);
                    context.SaveChanges();
                }
                Cliente authUser = null;
                using (DiscosDAL discosDAL = new DiscosDAL())
                {
                    authUser = discosDAL.Clientes.FirstOrDefault(u => u.Nombre == cliente.Nombre && u.Password == cliente.Password);
                }

                if (authUser != null)
                {
                    FormsAuthentication.SetAuthCookie(authUser.Nombre, false);
                    Session["Nombre"] = authUser.Nombre;
                    Session["IdCliente"] = authUser.id;
                    return RedirectToAction("Lista", "Lista");
                }
                else
                {
                    ModelState.AddModelError("CredentialError", "Usuario o contraseña incorrectos");
                    return RedirectToAction("Index", "Pagina");
                }            
            }
            else
            {
                return RedirectToAction("Index", "Pagina");
            }        
        }

        //Hace un Log out de de la sesion del usuario
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Pagina");
        }
    }
}