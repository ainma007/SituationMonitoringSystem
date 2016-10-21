using Kendo.Mvc.UI;
using SituationMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;

namespace SituationMonitoring.Models
{
    public class QueriesService
    {
        private SituationMonitoringEntities entities;

        public QueriesService(SituationMonitoringEntities entities)
        {
            this.entities = entities;

        }
        //public int GetSum_Question()
        //{
        //    int count = 0;
           
        //        using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
        //        {
        //            count = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(HoldingDataClass.situationId))
        //                           .Select(i => i.QuestionnaireID).Count();
        //        }
        //        return count;
            
          

        //}


        public void Dispose()
        {
            entities.Dispose();
        }
    }
}