using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using GA.Core.Security;
using Microsoft.IdentityModel.Claims;
using Microsoft.IdentityModel.Configuration;
using Microsoft.IdentityModel.Web;
using sdtime.Util.Security;

namespace sdtime.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult ViewProfile()
        {
            var mgr = new UserManager();
            var id = User.Identity as ClaimsIdentity;
            if (id != null)
            {
                var claims = id.Claims;
                var data = claims.GetClaimsInfo();
                if (!mgr.UserExists(data.IdentityProviderName, data.ProviderKey))
                    return RedirectToAction("Index", "RegisterUser");
                var user = mgr.GetUserByKey(data.IdentityProviderName, data.ProviderKey);
                ViewBag.Username = user.DisplayName;
                ViewBag.ProviderName = user.IdentityProviderName;
                ViewBag.MemerSince = user.MemberSince.GetValueOrDefault().ToString("mm/dd/yy");
            }
            return View();
            
        }

        Func<string> GetRealmUrl = () =>
        {
            var section = ConfigurationManager.GetSection("microsoft.identityModel") as MicrosoftIdentityModelSection;
            var svc = section.ServiceElements.Cast<ServiceElement>().First() as ServiceElement;
            return svc.FederatedAuthentication.WSFederation.Realm;
        };

        public ActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Logout");
            }
            dynamic model = new ExpandoObject();
            model.RealmUrl = GetRealmUrl();
            return View(model);
        }

        public ActionResult Logout()
        {
            WSFederationAuthenticationModule fam = FederatedAuthentication.WSFederationAuthenticationModule;

            try
            {
                FormsAuthentication.SignOut();
            }
            finally
            {
                fam.SignOut(true);
            }

            return RedirectToAction("Index", "Home");
        }

    }
}
