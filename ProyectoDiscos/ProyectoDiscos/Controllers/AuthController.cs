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
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                Cliente authUser = null;
                using (DiscosDAL discosDAL = new DiscosDAL())
                {
                    authUser = discosDAL.Clientes.FirstOrDefault(u => u.Nombre == cliente.Nombre && u.Password == cliente.Password);
                }

                if(authUser != null)
                {
                    FormsAuthentication.SetAuthCookie(authUser.Nombre, false);
                    Session["USUARIO"] = authUser;
                    return RedirectToAction("index", "Pagina");
                }
                else
                {
                    ModelState.AddModelError("CredentialError", "Usuario o contraseña incorrectos");
                    return View();
                }
    
            }
            else
            {
                return View();
            }
            
        }
        [HttpPost]
        public ActionResult Register(Cliente cliente)
        {
            return RedirectToAction("Index", "Pagina");
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Pagina");
        }
    }
}