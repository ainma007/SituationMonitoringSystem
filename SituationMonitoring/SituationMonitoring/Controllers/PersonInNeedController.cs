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
            PopulateKey_concern();
            return View();
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
            return Json(PersonInNeedService.Read().Where(u => u.SituationID == int.Parse(HoldingDataClass.situationId)).ToDataSourceResult(request));
        }

        public ActionResult PersonInNeed_UserRead([DataSourceRequest] DataSourceRequest request)
        {
            return Json(PersonInNeedService.Read().Where(u => u.SituationID == int.Parse(HoldingDataClass.situationId) && u.UserID == int.Parse(Session["UserID"].ToString())).ToDataSourceResult(request));
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