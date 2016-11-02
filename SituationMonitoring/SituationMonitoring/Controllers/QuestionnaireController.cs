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
    public class QuestionnaireController : Controller
    {

        // TempData
        public  static  string  LocalSituationId { get; set; }
        
        // GET: Questionnaire
        public ActionResult QuestionnaireManmanagement(string situationId)
        {
            if (situationId != null)
            {
       
                Session["situationId"] = situationId;
                //==================================================
                HoldingDataClass.situationId = null;
                HoldingDataClass.situationId = situationId;
                //--------------------------------------------------
                //LocalSituationId = null;
                LocalSituationId = situationId;

                ////==================================================
            }
            GetDate();
            GovernorateArName();
            MunicipalityArName();
            AreaArName();
            CollectiveCenter();
            return View();
        }

        public string GetDate()
        {
            int H = 0;
            H = int.Parse(LocalSituationId);
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
            H = int.Parse(LocalSituationId);
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
            H = int.Parse(LocalSituationId);
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
            H = int.Parse(LocalSituationId);
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
            H = int.Parse(LocalSituationId);
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Situation_Table xx = entities.Situation_Table.Where(c => c.SituationID == H)
                               .Select(i => i).Single();


                ViewBag.CollectiveCenter = xx.CollectiveCenter.ToString();


            }

            return ViewBag.CollectiveCenter;
        }

        private QuestionnaireService QuestionnaireService;


        public QuestionnaireController()
        {

            QuestionnaireService = new QuestionnaireService(new SituationMonitoringEntities());


        }


        public ActionResult Questionnair_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(QuestionnaireService.Read().Where(u => u.SituationID == int.Parse(LocalSituationId)).ToDataSourceResult(request));
        }


        public ActionResult Questionnair_UserRead([DataSourceRequest] DataSourceRequest request)
        {
            return Json(QuestionnaireService.Read().Where(u => u.SituationID == int.Parse(LocalSituationId) && u.UserID==int.Parse(Session["UserID"].ToString())).ToDataSourceResult(request));
        }

        // Insert New
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Questionnair_Create([DataSourceRequest] DataSourceRequest request, QuestionnaireViewModel db,string situationId)
        {
            if (db != null && ModelState.IsValid)
            {

                QuestionnaireService.Create(db, situationId);
            }
            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Questionnair_Update([DataSourceRequest] DataSourceRequest request, QuestionnaireViewModel db)
        {
            if (db != null && ModelState.IsValid)
            {
               
                QuestionnaireService.Update(db);
            }
            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }


        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Questionnair_Destroy([DataSourceRequest] DataSourceRequest request, QuestionnaireViewModel db)
        {
            if (db != null)
            {
                QuestionnaireService.Destroy(db);
            }

            return Json(new[] { db }.ToDataSourceResult(request, ModelState));
        }
    }
}