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
    public class SituationUserController : Controller
    {
        // GET: SituationUser
        public ActionResult SituationUser()
        {
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




        private SituationUserService SituationUserService;


        public SituationUserController()
        {

            SituationUserService = new SituationUserService(new SituationMonitoringEntities());


        }

        public ActionResult SituationUser_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(SituationUserService.Read().ToDataSourceResult(request));
        }

      
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Situation_Create([DataSourceRequest] DataSourceRequest request, SituationUserViewModel db)
        {
            if (db != null && ModelState.IsValid)
            {
                SituationUserService.Create(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult SituationUser_Update([DataSourceRequest] DataSourceRequest request, SituationUserViewModel db)
        {
            if (db != null && ModelState.IsValid)
            {
                SituationUserService.Update(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }


        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult SituationUser_Destroy([DataSourceRequest] DataSourceRequest request, SituationUserViewModel db)
        {
            if (db != null)
            {
                SituationUserService.Destroy(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }



        public JsonResult GetUsers()
        {
            return Json(SituationUserService.GetUseres(), JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetSituationID()
        {
            return Json(SituationUserService.ReadSituation(), JsonRequestBehavior.AllowGet);
        }
    }
}