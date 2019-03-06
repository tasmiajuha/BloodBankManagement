using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace BloodBankManagement
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<BloodBankManagement.Models.BloodRequestContext>(null);
            Database.SetInitializer<BloodBankManagement.Models.BloodStockContext>(null);
            Database.SetInitializer<BloodBankManagement.Models.DonorRegistrationContext>(null);
            Database.SetInitializer<BloodBankManagement.Models.RegistrationContext>(null);



            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
