using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.IdentityModel.Claims;
using sdtime.Util.Security;

namespace sdtime.Controllers
{
    public class TimeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            
            var id = User.Identity as ClaimsIdentity;
            if (id != null)
            {
                
                var claims = id.Claims;
                var data = claims.GetClaimsInfo();
                var mgr = new UserManager();
                if (!mgr.UserExists(data.IdentityProviderName, data.ProviderKey)) 
                    return RedirectToAction("Index", "RegisterUser");
                var user = mgr.GetUserByKey(data.IdentityProviderName, data.ProviderKey);
                ViewBag.Username = user.DisplayName;
                ViewBag.ProviderName = user.IdentityProviderName;
                ViewBag.MemberSince = user.MemberSince.GetValueOrDefault().ToString("mm/dd/yy");
            }
            return View();
        }

    }
}
