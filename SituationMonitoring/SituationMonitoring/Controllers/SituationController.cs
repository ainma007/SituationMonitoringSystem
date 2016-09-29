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
    public class SituationController : Controller
    {
        // GET: Situation
        public ActionResult situationManagement()
        {
            PopulateGovernorate();
            PopulateMunicipality();
            PopulateArea();

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

            ViewData["Governorate"] = Governorate;
            ViewData["defaultGovernorate"] = Governorate.First();
        }

        private void PopulateMunicipality()
        {
            var dataContext = new SituationMonitoringEntities();
            var Municipality = dataContext.Municipality_Table
                        .Select(c => new Models.SessionForeignKey.MunicipalityForeingKey
                        {
                            MunicipalityID = c.MunicipalityID,
                            MunicipalityName = c.MunicipalityArName
                        })
                        .OrderBy(e => e.MunicipalityID);

            ViewData["Municipality"] = Municipality;
            ViewData["defaultMunicipality"] = Municipality.First();
        }

        private void PopulateArea()
        {
            var dataContext = new SituationMonitoringEntities();
            var Area = dataContext.Area_Table
                        .Select(c => new Models.SessionForeignKey.AreaForeingKey
                        {
                            AreaID = c.AreaID,
                            AreaName = c.AreaArName
                        })
                        .OrderBy(e => e.AreaID);

            ViewData["Area"] = Area;
            ViewData["defaultArea"] = Area.First();
        }


        private SituationService SituationService;


        public SituationController()
        {

            SituationService = new SituationService(new SituationMonitoringEntities());


        }


        public ActionResult Situation_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(SituationService.Read().ToDataSourceResult(request));
        }
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Situation_Create([DataSourceRequest] DataSourceRequest request, SituationViewModel db)
        {
            if (db != null && ModelState.IsValid)
            {
                SituationService.Create(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Situation_Update([DataSourceRequest] DataSourceRequest request, SituationViewModel db)
        {
            if (db != null && ModelState.IsValid)
            {
                SituationService.Update(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }


        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Situation_Destroy([DataSourceRequest] DataSourceRequest request, SituationViewModel db)
        {
            if (db != null)
            {
                SituationService.Destroy(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult GetGovernorate()
        {
            return Json(SituationService.ReadGovernorate(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetMunicipality()
        {
            return Json(SituationService.ReadMunicipality(), JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetArea()
        {
            return Json(SituationService.ReadArea(), JsonRequestBehavior.AllowGet);
        }
    }
}