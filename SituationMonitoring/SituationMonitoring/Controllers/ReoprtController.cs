using SituationMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SituationMonitoring.Controllers
{
    public class ReoprtController : Controller
    {
        // GET: Reoprt
        public ActionResult SituationMonitoringReport()
        {
            
            return View();
        }


        //private SituationMonitoringEntities entities;

        //public ReoprtController(SituationMonitoringEntities entities)
        //{
        //    this.entities = entities;

        //}
        //    public double GetSum_Estimated_Number_Of_Individuals()
        //    {
        //        double Sm = 0;
        //        Sm = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(Session["situationId"].ToString()))
        //                         .Select(i => i.Estimated_Number_Of_Individuals.Value).Average();

        //        return Sm;
        //    }
    }
}