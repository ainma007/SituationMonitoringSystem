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
    public class PersonInNeedController : Controller
    {
        // GET: PersonInNeed
        public ActionResult PersonInNeedManage()
        {
            GetDate();
            GovernorateArName();
            MunicipalityArName();
            AreaArName();
            CollectiveCenter();
            UserFullName();
            PopulateKey_concern();
            return View();
        }

        public string UserFullName()
        {
            int H = 0;
            H = HoldingDataClass.situationId;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Situation_Table xx = entities.Situation_Table.Where(c => c.SituationID == H)
                               .Select(i => i).Single();


                ViewBag.UserFullName = xx.Users_Table.FullName.ToString();


            }

            return ViewBag.UserFullName;
        }
        public string GetDate()
        {
            int H = 0;
            H = HoldingDataClass.situationId;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Situation_Table xx = entities.Situation_Table.Where(c => c.SituationID == H)
                               .Select(i => i).Single();


                ViewBag.Date = xx.SituationDate.Value.ToShortDateString();


            }

            return ViewBag.Date;
        }

        public string GovernorateArName()
        {
            int H = 0;
            H = HoldingDataClass.situationId;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Situation_Table xx = entities.Situation_Table.Where(c => c.SituationID == H)
                               .Select(i => i).Single();


                ViewBag.GovernorateArName = xx.Governorate_Table.GovernorateArName.ToString();


            }

            return ViewBag.GovernorateArName;
        }


        public string MunicipalityArName()
        {
            int H = 0;
            H = HoldingDataClass.situationId;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Situation_Table xx = entities.Situation_Table.Where(c => c.SituationID == H)
                               .Select(i => i).Single();


                ViewBag.MunicipalityArName = xx.Municipality_Table.MunicipalityArName.ToString();


            }

            return ViewBag.MunicipalityArName;
        }

        public string AreaArName()
        {
            int H = 0;
            H = HoldingDataClass.situationId;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Situation_Table xx = entities.Situation_Table.Where(c => c.SituationID == H)
                               .Select(i => i).Single();


                ViewBag.AreaArName = xx.Area_Table.AreaArName.ToString();


            }

            return ViewBag.AreaArName;
        }

        public string CollectiveCenter()
        {
            int H = 0;
            H = HoldingDataClass.situationId;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Situation_Table xx = entities.Situation_Table.Where(c => c.SituationID == H)
                               .Select(i => i).Single();


                ViewBag.CollectiveCenter = xx.CollectiveCenter.ToString();


            }

            return ViewBag.CollectiveCenter;
        }

        private void PopulateKey_concern()
        {
            var dataContext = new SituationMonitoringEntities();
            var key_concern = dataContext.Key_concernTable
                        .Select(c => new Key_concernForeingKey
                        {
                            ID = c.ID,
                            Key_concern = c.Key_concern
                        })
                        .OrderBy(e => e.ID);

            ViewData["key_concern"] = key_concern;
            ViewData["defaultkey_concern"] = key_concern.First();
        }

        private PersonInNeedService PersonInNeedService;


        public PersonInNeedController()
        {

            PersonInNeedService = new PersonInNeedService(new SituationMonitoringEntities());


        }
        public ActionResult PersonInNeed_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(PersonInNeedService.Read().Where(u => u.SituationID == HoldingDataClass.situationId).ToDataSourceResult(request));
        }

        public ActionResult PersonInNeed_UserRead([DataSourceRequest] DataSourceRequest request)
        {
            return Json(PersonInNeedService.Read().Where(u => u.SituationID == HoldingDataClass.situationId && u.UserID == int.Parse(Session["UserID"].ToString())).ToDataSourceResult(request));
        }
      
        // Insert New
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult PersonInNeed_Create([DataSourceRequest] DataSourceRequest request, PersonInNeedViewModel db)
        {
            if (db != null && ModelState.IsValid)
            {
                PersonInNeedService.Create(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult PersonInNeed_Update([DataSourceRequest] DataSourceRequest request, PersonInNeedViewModel db)
        {
            if (db != null && ModelState.IsValid)
            {
                PersonInNeedService.Update(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }


        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult PersonInNeed_Destroy([DataSourceRequest] DataSourceRequest request, PersonInNeedViewModel db)
        {
            if (db != null)
            {
                PersonInNeedService.Destroy(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }

        public JsonResult GetKey_concern()
        {
            return Json(PersonInNeedService.ReadKey_concern(), JsonRequestBehavior.AllowGet);
        }
    }
}