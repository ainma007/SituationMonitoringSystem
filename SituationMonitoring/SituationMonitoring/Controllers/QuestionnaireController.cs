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
        // GET: Questionnaire
        public ActionResult QuestionnaireManmanagement(string situationId)
        {
            if (situationId != null)
            {
                Session["situationId"] = situationId;
                HoldingDataClass.situationId = situationId;
            }
            return View();
        }

        private QuestionnaireService QuestionnaireService;


        public QuestionnaireController()
        {

            QuestionnaireService = new QuestionnaireService(new SituationMonitoringEntities());


        }


        public ActionResult Questionnair_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(QuestionnaireService.Read().Where(u => u.SituationID == int.Parse(HoldingDataClass.situationId)).ToDataSourceResult(request));
        }

        // Insert New
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Questionnair_Create([DataSourceRequest] DataSourceRequest request, QuestionnaireViewModel db)
        {
            if (db != null && ModelState.IsValid)
            {
                QuestionnaireService.Create(db);
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