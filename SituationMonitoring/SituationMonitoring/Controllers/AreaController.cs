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
    public class AreaController : Controller
    {
        // GET: Area
        public ActionResult AreaManagment()
        {
            PopulateGovernorate();
            return View();
        }

        private void PopulateGovernorate()
        {
            var dataContext = new SituationMonitoringEntities();
            var Governorate = dataContext.Governorate_Table
                        .Select(c => new GovernorateViewModel
                        {
                            GovernorateID = c.GovernorateID,
                            GovernorateArName = c.GovernorateArName
                        })
                        .OrderBy(e => e.GovernorateID);

            ViewData["Governorate1"] = Governorate;
            ViewData["defaultGovernorate1"] = Governorate.First();
        }

        private AreaService AreaService;


        public AreaController()
        {

            AreaService = new AreaService(new SituationMonitoringEntities());


        }
        public ActionResult Area_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(AreaService.Read().ToDataSourceResult(request));
        }


        // Insert New
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Area_Create([DataSourceRequest] DataSourceRequest request, AreaViewModel db)
        {
            if (db != null && ModelState.IsValid)
            {
                AreaService.Create(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Area_Update([DataSourceRequest] DataSourceRequest request, AreaViewModel db)
        {
            if (db != null && ModelState.IsValid)
            {
                AreaService.Update(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }


        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Area_Destroy([DataSourceRequest] DataSourceRequest request, AreaViewModel db)
        {
            if (db != null)
            {
                AreaService.Destroy(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult GetGovernorate()
        {
            return Json(AreaService.ReadGovernorate(), JsonRequestBehavior.AllowGet);
        }
    }
}