using ProyectoDew.DataAccessLayer;
using ProyectoDew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ProyectoDew.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DoLogin(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                Usuario authUser = null;
                using (DiscosDAL discosDAL = new DiscosDAL())
                {
                    authUser = discosDAL.Usuario.FirstOrDefault(u => u.nombreUsuario == usuario.nombreUsuario && u.Password == usuario.Password);
                }

                if(authUser != null)
                {
                    FormsAuthentication.SetAuthCookie(authUser.nombreUsuario, false);
                    Session["USUARIO"] = authUser;
                    return RedirectToAction("index", "Home");
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
    }
}