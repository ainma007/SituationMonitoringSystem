using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SituationMonitoring.Models
{
    public class QuestionnaireService
    {

        private SituationMonitoringEntities entities;

        public QuestionnaireService(SituationMonitoringEntities entities)
        {
            this.entities = entities;
        }

        public IEnumerable<QuestionnaireViewModel> Read()
        {
            return entities.Questionnaire_Table.Select(db => new QuestionnaireViewModel
            {
                QuestionnaireID = db.QuestionnaireID,
                QuestionnaireDate = db.QuestionnaireDate.HasValue ? db.QuestionnaireDate.Value : default(DateTime),
                UserID = db.UserID,
                SituationID = db.SituationID,
                EmployeeName = db.EmployeeName,
                CenterName = db.CenterName,
                EmployeeMail = db.EmployeeMail,
                EmployeePhone = db.EmployeePhone,
                PersonName = db.PersonName,
                PersonGEnder = db.PersonGEnder,
                RoleInCommunity = db.RoleInCommunity,
                Place_of_origin = db.Place_of_origin,
                PersonMobile = db.PersonMobile,
                CollectiveCenter = db.CollectiveCenter,
                Estimated_Number_Of_Individuals = db.Estimated_Number_Of_Individuals,
                Estimated_Number_Of_Families = db.Estimated_Number_Of_Families,
                 Site_Description = db.Site_Description,
                Question1_1 = db.Question1_1,
                Question1_1_1 = db.Question1_1_1,
                Question1_2_1_Family_CommunityDisputes = db.Question1_2_1_Family_CommunityDisputes,
                Question_1_2_2NotEnoughFood = db.Question_1_2_2NotEnoughFood,
                Question1_2_3NotEnoughPrivacy = db.Question1_2_3NotEnoughPrivacy,
                Question1_2_4NotEnoughDrinking = db.Question1_2_4NotEnoughDrinking,
                Question1_2_5UnsafeHousing = db.Question1_2_5UnsafeHousing,
                Question1_2_6Overcrowding = db.Question1_2_6Overcrowding,
                Question1_2_7InsufficientBedding = db.Question1_2_7InsufficientBedding,
                Question1_2_8NotEnoughWater = db.Question1_2_8NotEnoughWater,
                Question1_2_9Not_enough_humanitarian_assistance = db.Question1_2_9Not_enough_humanitarian_assistance,
                Question1_2_9Text = db.Question1_2_9Text,
                Question1_2_10No_Access_to_essential_services = db.Question1_2_10No_Access_to_essential_services,
                Question1_2_10Text = db.Question1_2_10Text,
                Question1_2_11Other = db.Question1_2_11Other,
                Question1_2_11Text = db.Question1_2_11Text,
                Question1_3_1Family_CommunityDisputes = db.Question1_3_1Family_CommunityDisputes,
                Question1_3_2NotEnoughFood = db.Question1_3_2NotEnoughFood,
                Question1_3_3NotEnoughDrinking = db.Question1_3_3NotEnoughDrinking,
                Question1_3_4UnsafeHousing = db.Question1_3_4UnsafeHousing,
                Question1_3_5Overcrowding = db.Question1_3_5Overcrowding,
                Question1_3_5NotEnoughWater = db.Question1_3_5NotEnoughWater,
                Question1_3_6Not_enough_humanitarian_assistance = db.Question1_3_6Not_enough_humanitarian_assistance,
                Question1_3_6Text = db.Question1_3_6Text,
                Question1_3_7No_Access_to_essential_services = db.Question1_3_7No_Access_to_essential_services,
                Question1_3_7Text = db.Question1_3_7Text,
                Question1_3_8Text = db.Question1_3_8Text,
                Question1_4 = db.Question1_4,
                Question1_4_1 = db.Question1_4_1,                                         

            });
        }
    }
}