using Kendo.Mvc.UI;
using SituationMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using SituationMonitoring.Models.SessionForeignKey;

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
            PopulateUsers();

            return View();
        }

        public void PopulateUsers()
        {
            var dataContext = new SituationMonitoringEntities();
            var users = dataContext.Users_Table

                              .Select(c => new UserForeingKey
                              {
                                  UserID = c.UserID,
                                  UserFullName = c.FullName
                              })
                              .OrderBy(e => e.UserID);

            ViewData["users"] = users;
            ViewData["defaultUser"] = users.First();
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

        public JsonResult GetMunicipality( int governorateID)
        {
            return Json(SituationService.ReadMunicipality(governorateID), JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetArea(int governorateID)
        {
            return Json(SituationService.ReadArea(governorateID), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetUsers()
        {
            return Json(SituationService.GetUseres(), JsonRequestBehavior.AllowGet);
        }
    }
}