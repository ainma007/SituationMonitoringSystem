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

        /// <summary>
        /// This Parameter Holding Session[situationId] value 
        /// </summary>
        public static string situationId { get; set; } 




        #region " Get  Final Sum"
        public int GetSum_Estimated_Number_Of_Individuals()
        {
            int Sm = 0;
            Sm = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(situationId))
                             .Select(i => i.Estimated_Number_Of_Individuals.Value).Sum();

            return Sm;
        }
        public int GetSum_Estimated_Number_Of_Families()
        {
            int Sm = 0;
            Sm = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(situationId))
                             .Select(i => i.Estimated_Number_Of_Families.Value).Sum();

            return Sm;
        }

        public int GetSum_Question3_1Male()
        {
            int Sm = 0;
            Sm = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(situationId))
                             .Select(i => i.Question3_1Male.Value).Sum();

            return Sm;
        }

        public int GetSum_Question3_1Femal()
        {
            int Sm = 0;
            Sm = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(situationId))
                             .Select(i => i.Question3_1Femal.Value).Sum();

            return Sm;
        }


        public int GetSum_Question3_2Male()
        {
            int Sm = 0;
            Sm = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(situationId))
                             .Select(i => i.Question3_2Male.Value).Sum();

            return Sm;
        }

        public int GetSum_Question3_2Femal()
        {
            int Sm = 0;
            Sm = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(situationId))
                             .Select(i => i.Question3_2Femal.Value).Sum();

            return Sm;
        }

        public int GetSum_Question3_3Male()
        {
            int Sm = 0;
            Sm = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(situationId))
                             .Select(i => i.Question3_3Male.Value).Sum();

            return Sm;
        }

        public int GetSum_Question3_3Femal()
        {
            int Sm = 0;
            Sm = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(situationId))
                             .Select(i => i.Question3_3Femal.Value).Sum();

            return Sm;
        }


        public int GetSum_Question3_4Male()
        {
            int Sm = 0;
            Sm = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(situationId))
                             .Select(i => i.Question3_4Male.Value).Sum();

            return Sm;
        }

        public int GetSum_Question3_4Femal()
        {
            int Sm = 0;
            Sm = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(situationId))
                             .Select(i => i.Question3_4Femal.Value).Sum();

            return Sm;
        }

        public int GetSum_Question3_5Male()
        {
            int Sm = 0;
            Sm = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(situationId))
                             .Select(i => i.Question3_5Male.Value).Sum();

            return Sm;
        }

        public int GetSum_Question3_5Femal()
        {
            int Sm = 0;
            Sm = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(situationId))
                             .Select(i => i.Question3_5Femal.Value).Sum();

            return Sm;
        }

        #endregion


        #region " Queries  {   Get Final Count  }"

        /// <summary>
        /// Note Mr: Mohammed : insert value as parameter
        /// </summary>
        /// <param name="value">Defult  value   is { لا اعرف ,لا , نعم}</param>
        /// <returns> This Method Return integer Value </returns>
        public int GetCount_Question1_1(string value)
        {
            int count = 0;
            count = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(situationId)
            && c.Question1_1 == value)
                             .Select(i => i.QuestionnaireID).Count();

            return count;
        }


        /// <summary>
        /// Note Mr: Mohammed : insert value as parameter
        /// </summary>
        /// <param name="value">Defult  value   is { لا اعرف ,لا , نعم}</param>
        /// <returns> This Method Return integer Value </returns>
        public int GetCount_Question1_1_1(string value)
        {
            int count = 0;
            count = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(situationId)
            && c.Question1_1_1 == value)
                             .Select(i => i.QuestionnaireID).Count();

            return count;
        }










        #region  "Get Boolean Value As True "
        public int Question1_2_1_Family_CommunityDisputes_TrueValue()
        {
            int count = 0;
            count = entities.Questionnaire_Table.Where(c => c.SituationID == int.Parse(situationId)
            && c.Question1_2_1_Family_CommunityDisputes == true)
                             .Select(i => i.QuestionnaireID).Count();

            return count;
        }



        #endregion
        public void Dispose()
        {
            entities.Dispose();
        }
    } 
}