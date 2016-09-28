using Kendo.Mvc.UI;
using SituationMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;

namespace SituationMonitoring.Controllers
{
    public class MunicipalityController : Controller
    {
        // GET: Municipality
        public ActionResult MunicipalityManegment()
        {
                PopulateProvince();
      
                return View();
        }


        private void PopulateProvince()
        {
            var dataContext = new SituationMonitoringEntities();
            var Governorate = dataContext.Governorate_Table
                        .Select(c => new GovernorateViewModel
                        {
                            GovernorateID = c.GovernorateID,
                            GovernorateArName = c.GovernorateArName
                        })
                        .OrderBy(e => e.GovernorateID);

            ViewData["Governorate"] = Governorate;
            ViewData["defaultGovernorate"] = Governorate.First();
        }

        private MunicipalityService MunicipalityService;


        public MunicipalityController()
        {

            MunicipalityService = new MunicipalityService(new SituationMonitoringEntities());


        }
        public ActionResult Municipalit_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(MunicipalityService.Read().ToDataSourceResult(request));
        }


        // Insert New
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Municipality_Create([DataSourceRequest] DataSourceRequest request, MunicipalityViewModel db)
        {
            if (db != null && ModelState.IsValid)
            {
                MunicipalityService.Create(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Municipality_Update([DataSourceRequest] DataSourceRequest request, MunicipalityViewModel db)
        {
            if (db != null && ModelState.IsValid)
            {
                MunicipalityService.Update(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }


        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Municipality_Destroy([DataSourceRequest] DataSourceRequest request, MunicipalityViewModel db)
        {
            if (db != null)
            {
                MunicipalityService.Destroy(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult GetGovernorate()
        {
            return Json(MunicipalityService.ReadGovernorate(), JsonRequestBehavior.AllowGet);
        }
    }
}