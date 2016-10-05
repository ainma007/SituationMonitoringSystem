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
            return Json(QuestionnaireService.Read().ToDataSourceResult(request));
        }
    }
}