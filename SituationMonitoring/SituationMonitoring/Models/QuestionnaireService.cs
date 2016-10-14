using System;
using System.Collections.Generic;
using System.Data;
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
    UserID = db.UserID,
    SituationID=db.SituationID,

                QuestionnaireDate = db.QuestionnaireDate.HasValue ? db.QuestionnaireDate.Value : default(DateTime),
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
                Question1_3_8Other=db.Question1_3_8Other,
                Question1_3_8Text = db.Question1_3_8Text,
                Question1_4 = db.Question1_4,
                Question1_4_1 = db.Question1_4_1,
                Question2_1_1Family_CommunityDisputes = db.Question2_1_1Family_CommunityDisputes,
            Question2_1_2NotEnoughFood = db.Question2_1_2NotEnoughFood,
            Question2_1_3NotEnoughPrivacy = db.Question2_1_3NotEnoughPrivacy,
            Question2_1_4NotDrinkingEnoughWater = db.Question2_1_4NotDrinkingEnoughWater,
            Question2_1_5UnsafeHousing = db.Question2_1_5UnsafeHousing,
            Question2_1_6Overcrowding = db.Question2_1_6Overcrowding,
            Question2_1_7InsufficientBedding = db.Question2_1_7InsufficientBedding,
            Question2_1_8NotEnoughWater = db.Question2_1_8NotEnoughWater,
            Question2_1_9NotEnoughHumanitarianAssistance = db.Question2_1_9NotEnoughHumanitarianAssistance,
            Question2_1_9Text = db.Question2_1_9Text,
            Question2_1_10NoAccessToEssentialServices = db.Question2_1_10NoAccessToEssentialServices,
            Question2_1_10Text = db.Question2_1_10Text,
            Question2_1_11DistributionOfAssistanceExcludesChild_headedFamilies = db.Question2_1_11DistributionOfAssistanceExcludesChild_headedFamilies,
            Question2_1_12DistributionOfAssistanceExcludesWomen_headedFamilies = db.Question2_1_12DistributionOfAssistanceExcludesWomen_headedFamilies,
            Question2_1_13LackOfSafeSpacesForWomenAndGirlsToGather = db.Question2_1_13LackOfSafeSpacesForWomenAndGirlsToGather,
            Question2_1_14LackOfSafeSpacesForChildrenToPlay = db.Question2_1_14LackOfSafeSpacesForChildrenToPlay,
            Question2_1_15LackOfAdequateLightingForToilets = db.Question2_1_15LackOfAdequateLightingForToilets,
            Question2_1_16LackOfGenderSegregatedToilets = db.Question2_1_16LackOfGenderSegregatedToilets,
            Question2_1_17LackOfGenderSegregatedBathingFacilities = db.Question2_1_17LackOfGenderSegregatedBathingFacilities,
            Question2_1_18Other = db.Question2_1_18Other,
            Question2_1_18text = db.Question2_1_18text,
            Question2_2 = db.Question2_2,
            Question2_2_1 = db.Question2_2_1,
            Question2_3 = db.Question2_3,
            Question2_3_1 = db.Question2_3_1,
            Question3_1 = db.Question3_1,
            Question3_1Male = db.Question3_1Male,
            Question3_1Femal = db.Question3_1Femal,
            Question3_2 = db.Question3_2,
            Question3_2Male = db.Question3_2Male,
            Question3_2Femal = db.Question3_2Femal,
            Question3_3 = db.Question3_3,
            Question3_3Male = db.Question3_3Male,
            Question3_3Femal = db.Question3_3Femal,
            Question3_4 = db.Question3_4,
            Question3_4Male = db.Question3_4Male,
            Question3_4Femal = db.Question3_4Femal,
            Question3_5 = db.Question3_5,
            Question3_5Male = db.Question3_5Male,
            Question3_5Femal = db.Question3_5Femal,
            Question3_6 = db.Question3_6,
            Question3_6Male = db.Question3_6Male,
            Question3_6Femal = db.Question3_6Femal,
            Question3_7 = db.Question3_7,
            Question3_7Male = db.Question3_7Male,
            Question3_7Femal = db.Question3_7Femal,
            Question3_8 = db.Question3_8,
            Question3_8Male = db.Question3_8Male,
            Question3_8Femal = db.Question3_8Femal,
            Question3_9 = db.Question3_9,
            Question3_9Male = db.Question3_9Male,
            Question3_9Femal = db.Question3_9Femal,
            Question3_10 = db.Question3_10,
            Question3_10Male = db.Question3_10Male,
            Question3_10Femal = db.Question3_10Femal,
            Question3_11 = db.Question3_11,
            Question3_11Male = db.Question3_11Male,
            Question3_11Femal = db.Question3_11Femal,
            Question3_12 = db.Question3_12,
            Question3_12Male = db.Question3_12Male,
            Question3_12Femal = db.Question3_12Femal,
            Question3_13 = db.Question3_13,
            Question3_13Male = db.Question3_13Male,
            Question3_13Femal = db.Question3_13Femal,
            Question3_14 = db.Question3_14,
            Question3_14Male = db.Question3_14Male,
            Question3_14Femal = db.Question3_14Femal,
            Question3_15 = db.Question3_15,
            Question3_15Male = db.Question3_15Male,
            Question3_15Femal = db.Question3_15Femal,
                Question3_16 = db.Question3_16,
                Question3_16Male = db.Question3_16Male,
                Question3_16Femal = db.Question3_16Femal,

                Question3_17 = db.Question3_17,
                Question3_17Male = db.Question3_17Male,
                Question3_17Femal = db.Question3_17Femal,
                Question3_18 = db.Question3_18,
                Question3_18Male = db.Question3_18Male,
                Question3_18Femal = db.Question3_18Femal,
                Question3_19 = db.Question3_19,
                Question3_20 = db.Question3_20,
                Question3_20Text = db.Question3_20Text,
                Question3_20Male = db.Question3_20Male,
                Question3_20Femal = db.Question3_20Femal,
            Question4_1_1 = db.Question4_1_1,
            Question4_1_2 = db.Question4_1_2,
            Question4_1_3 = db.Question4_1_3,
            Question4_1_4 = db.Question4_1_4,
            Question4_1_5 = db.Question4_1_5,
            Question4_1_6 = db.Question4_1_6,
            Question4_1_7 = db.Question4_1_7,
            Question4_1_8 = db.Question4_1_8,
            Question4_1_9 = db.Question4_1_9,
            Question4_1_9Text = db.Question4_1_9Text,
            Question4_1_10 = db.Question4_1_10,
                Question_5=db.Question_5
            });
        }


        public void Create(QuestionnaireViewModel db)
        {
            var entity = new Questionnaire_Table();

            entity.QuestionnaireDate = (DateTime)db.QuestionnaireDate.Date;
            entity.UserID = int.Parse(HttpContext.Current.Session["UserID"].ToString());
            entity.SituationID = int.Parse(HttpContext.Current.Session["situationId"].ToString());
            entity.EmployeeName = db.EmployeeName;
            entity.CenterName = db.CenterName;
            entity.EmployeeMail = db.EmployeeMail;
            entity.EmployeePhone = db.EmployeePhone;
            entity.PersonName = db.PersonName;
            entity.PersonGEnder = db.PersonGEnder;
            entity.RoleInCommunity = db.RoleInCommunity;
            entity.Place_of_origin = db.Place_of_origin;
            entity.PersonMobile = db.PersonMobile;
            entity.CollectiveCenter = db.CollectiveCenter;
            entity.Estimated_Number_Of_Individuals = db.Estimated_Number_Of_Individuals;
            entity.Estimated_Number_Of_Families = db.Estimated_Number_Of_Families;
            entity.Site_Description = db.Site_Description;
            entity.Question1_1 = db.Question1_1;
            entity.Question1_1_1 = db.Question1_1_1;
            entity.Question1_2_1_Family_CommunityDisputes = db.Question1_2_1_Family_CommunityDisputes;
            entity.Question_1_2_2NotEnoughFood = db.Question_1_2_2NotEnoughFood;
            entity.Question1_2_3NotEnoughPrivacy = db.Question1_2_3NotEnoughPrivacy;
            entity.Question1_2_4NotEnoughDrinking = db.Question1_2_4NotEnoughDrinking;
            entity.Question1_2_5UnsafeHousing = db.Question1_2_5UnsafeHousing;
            entity.Question1_2_6Overcrowding = db.Question1_2_6Overcrowding;
            entity.Question1_2_7InsufficientBedding = db.Question1_2_7InsufficientBedding;
            entity.Question1_2_8NotEnoughWater = db.Question1_2_8NotEnoughWater;
            entity.Question1_2_9Not_enough_humanitarian_assistance = db.Question1_2_9Not_enough_humanitarian_assistance;
            entity.Question1_2_9Text = db.Question1_2_9Text;
            entity.Question1_2_10No_Access_to_essential_services = db.Question1_2_10No_Access_to_essential_services;
            entity.Question1_2_10Text = db.Question1_2_10Text;
            entity.Question1_2_11Other = db.Question1_2_11Other;
            entity.Question1_2_11Text = db.Question1_2_11Text;
            entity.Question1_3_1Family_CommunityDisputes = db.Question1_3_1Family_CommunityDisputes;
            entity.Question1_3_2NotEnoughFood = db.Question1_3_2NotEnoughFood;
            entity.Question1_3_3NotEnoughDrinking = db.Question1_3_3NotEnoughDrinking;
            entity.Question1_3_4UnsafeHousing = db.Question1_3_4UnsafeHousing;
            entity.Question1_3_5Overcrowding = db.Question1_3_5Overcrowding;
            entity.Question1_3_5NotEnoughWater = db.Question1_3_5NotEnoughWater;
            entity.Question1_3_6Not_enough_humanitarian_assistance = db.Question1_3_6Not_enough_humanitarian_assistance;
            entity.Question1_3_6Text = db.Question1_3_6Text;
            entity.Question1_3_7No_Access_to_essential_services = db.Question1_3_7No_Access_to_essential_services;
            entity.Question1_3_7Text = db.Question1_3_7Text;
            entity.Question1_3_8Other = db.Question1_3_8Other;
            entity.Question1_3_8Text = db.Question1_3_8Text;
            entity.Question1_4 = db.Question1_4;
            entity.Question1_4_1 = db.Question1_4_1;
            entity.Question2_1_1Family_CommunityDisputes = db.Question2_1_1Family_CommunityDisputes;
            entity.Question2_1_2NotEnoughFood = db.Question2_1_2NotEnoughFood;
            entity.Question2_1_3NotEnoughPrivacy = db.Question2_1_3NotEnoughPrivacy;
            entity.Question2_1_4NotDrinkingEnoughWater = db.Question2_1_4NotDrinkingEnoughWater;
            entity.Question2_1_5UnsafeHousing = db.Question2_1_5UnsafeHousing;
            entity.Question2_1_6Overcrowding = db.Question2_1_6Overcrowding;
            entity.Question2_1_7InsufficientBedding = db.Question2_1_7InsufficientBedding;
            entity.Question2_1_8NotEnoughWater = db.Question2_1_8NotEnoughWater;
            entity.Question2_1_9NotEnoughHumanitarianAssistance = db.Question2_1_9NotEnoughHumanitarianAssistance;
            entity.Question2_1_9Text = db.Question2_1_9Text;
            entity.Question2_1_10NoAccessToEssentialServices = db.Question2_1_10NoAccessToEssentialServices;
            entity.Question2_1_10Text = db.Question2_1_10Text;
            entity.Question2_1_11DistributionOfAssistanceExcludesChild_headedFamilies = db.Question2_1_11DistributionOfAssistanceExcludesChild_headedFamilies;
            entity.Question2_1_12DistributionOfAssistanceExcludesWomen_headedFamilies = db.Question2_1_12DistributionOfAssistanceExcludesWomen_headedFamilies;
            entity.Question2_1_13LackOfSafeSpacesForWomenAndGirlsToGather = db.Question2_1_13LackOfSafeSpacesForWomenAndGirlsToGather;
            entity.Question2_1_14LackOfSafeSpacesForChildrenToPlay = db.Question2_1_14LackOfSafeSpacesForChildrenToPlay;
            entity.Question2_1_15LackOfAdequateLightingForToilets = db.Question2_1_15LackOfAdequateLightingForToilets;
            entity.Question2_1_16LackOfGenderSegregatedToilets = db.Question2_1_16LackOfGenderSegregatedToilets;
            entity.Question2_1_17LackOfGenderSegregatedBathingFacilities = db.Question2_1_17LackOfGenderSegregatedBathingFacilities;
            entity.Question2_1_18Other = db.Question2_1_18Other;
            entity.Question2_1_18text = db.Question2_1_18text;
            entity.Question2_2 = db.Question2_2;
            entity.Question2_2_1 = db.Question2_2_1;
            entity.Question2_3 = db.Question2_3;
            entity.Question2_3_1 = db.Question2_3_1;
            entity.Question3_1 = db.Question3_1;
            entity.Question3_1Male = db.Question3_1Male;
            entity.Question3_1Femal = db.Question3_1Femal;
            entity.Question3_2 = db.Question3_2;
            entity.Question3_2Male = db.Question3_2Male;
            entity.Question3_2Femal = db.Question3_2Femal;
            entity.Question3_3 = db.Question3_3;
            entity.Question3_3Male = db.Question3_3Male;
            entity.Question3_3Femal = db.Question3_3Femal;
            entity.Question3_4 = db.Question3_4;
            entity.Question3_4Male = db.Question3_4Male;
            entity.Question3_4Femal = db.Question3_4Femal;
            entity.Question3_5 = db.Question3_5;
            entity.Question3_5Male = db.Question3_5Male;
            entity.Question3_5Femal = db.Question3_5Femal;
            entity.Question3_6 = db.Question3_6;
            entity.Question3_6Male = db.Question3_6Male;
            entity.Question3_6Femal = db.Question3_6Femal;
            entity.Question3_7 = db.Question3_7;
            entity.Question3_7Male = db.Question3_7Male;
            entity.Question3_7Femal = db.Question3_7Femal;
            entity.Question3_8 = db.Question3_8;
            entity.Question3_8Male = db.Question3_8Male;
            entity.Question3_8Femal = db.Question3_8Femal;
            entity.Question3_9 = db.Question3_9;
            entity.Question3_9Male = db.Question3_9Male;
            entity.Question3_9Femal = db.Question3_9Femal;
            entity.Question3_10 = db.Question3_10;
            entity.Question3_10Male = db.Question3_10Male;
            entity.Question3_10Femal = db.Question3_10Femal;
            entity.Question3_11 = db.Question3_11;
            entity.Question3_11Male = db.Question3_11Male;
            entity.Question3_11Femal = db.Question3_11Femal;
            entity.Question3_12 = db.Question3_12;
            entity.Question3_12Male = db.Question3_12Male;
            entity.Question3_12Femal = db.Question3_12Femal;
            entity.Question3_13 = db.Question3_13;
            entity.Question3_13Male = db.Question3_13Male;
            entity.Question3_13Femal = db.Question3_13Femal;
            entity.Question3_14 = db.Question3_14;
            entity.Question3_14Male = db.Question3_14Male;
            entity.Question3_14Femal = db.Question3_14Femal;
            entity.Question3_15 = db.Question3_15;
            entity.Question3_15Male = db.Question3_15Male;
            entity.Question3_15Femal = db.Question3_15Femal;
            entity.Question3_16 = db.Question3_16;
            entity.Question3_16Male = db.Question3_16Male;
            entity.Question3_16Femal = db.Question3_16Femal;
            entity.Question3_17 = db.Question3_17;
            entity.Question3_17Male = db.Question3_17Male;
            entity.Question3_17Femal = db.Question3_17Femal;
            entity.Question3_18 = db.Question3_18;
            entity.Question3_18Male = db.Question3_18Male;
            entity.Question3_18Femal = db.Question3_18Femal;
            entity.Question3_19 = db.Question3_19;           
            entity.Question3_20 = db.Question3_20;
            entity.Question3_20Text = db.Question3_20Text;
            entity.Question3_20Male = db.Question3_20Male;
            entity.Question3_20Femal = db.Question3_20Femal;
            entity.Question4_1_1 = db.Question4_1_1;
            entity.Question4_1_2 = db.Question4_1_2;
            entity.Question4_1_3 = db.Question4_1_3;
            entity.Question4_1_4 = db.Question4_1_4;
            entity.Question4_1_5 = db.Question4_1_5;
            entity.Question4_1_6 = db.Question4_1_6;
            entity.Question4_1_7 = db.Question4_1_7;
            entity.Question4_1_8 = db.Question4_1_8;
            entity.Question4_1_9 = db.Question4_1_9;
            entity.Question4_1_9Text = db.Question4_1_9Text;
            entity.Question4_1_10 = db.Question4_1_10;
            entity.Question_5 = db.Question_5;



            entities.Questionnaire_Table.Add(entity);
            entities.SaveChanges();

            db.QuestionnaireID = entity.QuestionnaireID;
        }

        public void Update(QuestionnaireViewModel db)
        {
            
            var entity = new Questionnaire_Table();
            entity.QuestionnaireID = db.QuestionnaireID;
            entity.UserID = db.UserID;

            entity.SituationID = db.SituationID;

            entity.QuestionnaireDate = (DateTime)db.QuestionnaireDate.Date;
           
            entity.EmployeeName = db.EmployeeName;
            entity.CenterName = db.CenterName;
            entity.EmployeeMail = db.EmployeeMail;
            entity.EmployeePhone = db.EmployeePhone;
            entity.PersonName = db.PersonName;
            entity.PersonGEnder = db.PersonGEnder;
            entity.RoleInCommunity = db.RoleInCommunity;
            entity.Place_of_origin = db.Place_of_origin;
            entity.PersonMobile = db.PersonMobile;
            entity.CollectiveCenter = db.CollectiveCenter;
            entity.Estimated_Number_Of_Individuals = db.Estimated_Number_Of_Individuals;
            entity.Estimated_Number_Of_Families = db.Estimated_Number_Of_Families;
            entity.Site_Description = db.Site_Description;
            entity.Question1_1 = db.Question1_1;
            entity.Question1_1_1 = db.Question1_1_1;
            entity.Question1_2_1_Family_CommunityDisputes = db.Question1_2_1_Family_CommunityDisputes;
            entity.Question_1_2_2NotEnoughFood = db.Question_1_2_2NotEnoughFood;
            entity.Question1_2_3NotEnoughPrivacy = db.Question1_2_3NotEnoughPrivacy;
            entity.Question1_2_4NotEnoughDrinking = db.Question1_2_4NotEnoughDrinking;
            entity.Question1_2_5UnsafeHousing = db.Question1_2_5UnsafeHousing;
            entity.Question1_2_6Overcrowding = db.Question1_2_6Overcrowding;
            entity.Question1_2_7InsufficientBedding = db.Question1_2_7InsufficientBedding;
            entity.Question1_2_8NotEnoughWater = db.Question1_2_8NotEnoughWater;
            entity.Question1_2_9Not_enough_humanitarian_assistance = db.Question1_2_9Not_enough_humanitarian_assistance;
            entity.Question1_2_9Text = db.Question1_2_9Text;
            entity.Question1_2_10No_Access_to_essential_services = db.Question1_2_10No_Access_to_essential_services;
            entity.Question1_2_10Text = db.Question1_2_10Text;
            entity.Question1_2_11Other = db.Question1_2_11Other;
            entity.Question1_2_11Text = db.Question1_2_11Text;
            entity.Question1_3_1Family_CommunityDisputes = db.Question1_3_1Family_CommunityDisputes;
            entity.Question1_3_2NotEnoughFood = db.Question1_3_2NotEnoughFood;
            entity.Question1_3_3NotEnoughDrinking = db.Question1_3_3NotEnoughDrinking;
            entity.Question1_3_4UnsafeHousing = db.Question1_3_4UnsafeHousing;
            entity.Question1_3_5Overcrowding = db.Question1_3_5Overcrowding;
            entity.Question1_3_5NotEnoughWater = db.Question1_3_5NotEnoughWater;
            entity.Question1_3_6Not_enough_humanitarian_assistance = db.Question1_3_6Not_enough_humanitarian_assistance;
            entity.Question1_3_6Text = db.Question1_3_6Text;
            entity.Question1_3_7No_Access_to_essential_services = db.Question1_3_7No_Access_to_essential_services;
            entity.Question1_3_7Text = db.Question1_3_7Text;
            entity.Question1_3_8Other = db.Question1_3_8Other;
            entity.Question1_3_8Text = db.Question1_3_8Text;
            entity.Question1_4 = db.Question1_4;
            entity.Question1_4_1 = db.Question1_4_1;
            entity.Question2_1_1Family_CommunityDisputes = db.Question2_1_1Family_CommunityDisputes;
            entity.Question2_1_2NotEnoughFood = db.Question2_1_2NotEnoughFood;
            entity.Question2_1_3NotEnoughPrivacy = db.Question2_1_3NotEnoughPrivacy;
            entity.Question2_1_4NotDrinkingEnoughWater = db.Question2_1_4NotDrinkingEnoughWater;
            entity.Question2_1_5UnsafeHousing = db.Question2_1_5UnsafeHousing;
            entity.Question2_1_6Overcrowding = db.Question2_1_6Overcrowding;
            entity.Question2_1_7InsufficientBedding = db.Question2_1_7InsufficientBedding;
            entity.Question2_1_8NotEnoughWater = db.Question2_1_8NotEnoughWater;
            entity.Question2_1_9NotEnoughHumanitarianAssistance = db.Question2_1_9NotEnoughHumanitarianAssistance;
            entity.Question2_1_9Text = db.Question2_1_9Text;
            entity.Question2_1_10NoAccessToEssentialServices = db.Question2_1_10NoAccessToEssentialServices;
            entity.Question2_1_10Text = db.Question2_1_10Text;
            entity.Question2_1_11DistributionOfAssistanceExcludesChild_headedFamilies = db.Question2_1_11DistributionOfAssistanceExcludesChild_headedFamilies;
            entity.Question2_1_12DistributionOfAssistanceExcludesWomen_headedFamilies = db.Question2_1_12DistributionOfAssistanceExcludesWomen_headedFamilies;
            entity.Question2_1_13LackOfSafeSpacesForWomenAndGirlsToGather = db.Question2_1_13LackOfSafeSpacesForWomenAndGirlsToGather;
            entity.Question2_1_14LackOfSafeSpacesForChildrenToPlay = db.Question2_1_14LackOfSafeSpacesForChildrenToPlay;
            entity.Question2_1_15LackOfAdequateLightingForToilets = db.Question2_1_15LackOfAdequateLightingForToilets;
            entity.Question2_1_16LackOfGenderSegregatedToilets = db.Question2_1_16LackOfGenderSegregatedToilets;
            entity.Question2_1_17LackOfGenderSegregatedBathingFacilities = db.Question2_1_17LackOfGenderSegregatedBathingFacilities;
            entity.Question2_1_18Other = db.Question2_1_18Other;
            entity.Question2_1_18text = db.Question2_1_18text;
            entity.Question2_2 = db.Question2_2;
            entity.Question2_2_1 = db.Question2_2_1;
            entity.Question2_3 = db.Question2_3;
            entity.Question2_3_1 = db.Question2_3_1;
            entity.Question3_1 = db.Question3_1;
            entity.Question3_1Male = db.Question3_1Male;
            entity.Question3_1Femal = db.Question3_1Femal;
            entity.Question3_2 = db.Question3_2;
            entity.Question3_2Male = db.Question3_2Male;
            entity.Question3_2Femal = db.Question3_2Femal;
            entity.Question3_3 = db.Question3_3;
            entity.Question3_3Male = db.Question3_3Male;
            entity.Question3_3Femal = db.Question3_3Femal;
            entity.Question3_4 = db.Question3_4;
            entity.Question3_4Male = db.Question3_4Male;
            entity.Question3_4Femal = db.Question3_4Femal;
            entity.Question3_5 = db.Question3_5;
            entity.Question3_5Male = db.Question3_5Male;
            entity.Question3_5Femal = db.Question3_5Femal;
            entity.Question3_6 = db.Question3_6;
            entity.Question3_6Male = db.Question3_6Male;
            entity.Question3_6Femal = db.Question3_6Femal;
            entity.Question3_7 = db.Question3_7;
            entity.Question3_7Male = db.Question3_7Male;
            entity.Question3_7Femal = db.Question3_7Femal;
            entity.Question3_8 = db.Question3_8;
            entity.Question3_8Male = db.Question3_8Male;
            entity.Question3_8Femal = db.Question3_8Femal;
            entity.Question3_9 = db.Question3_9;
            entity.Question3_9Male = db.Question3_9Male;
            entity.Question3_9Femal = db.Question3_9Femal;
            entity.Question3_10 = db.Question3_10;
            entity.Question3_10Male = db.Question3_10Male;
            entity.Question3_10Femal = db.Question3_10Femal;
            entity.Question3_11 = db.Question3_11;
            entity.Question3_11Male = db.Question3_11Male;
            entity.Question3_11Femal = db.Question3_11Femal;
            entity.Question3_12 = db.Question3_12;
            entity.Question3_12Male = db.Question3_12Male;
            entity.Question3_12Femal = db.Question3_12Femal;
            entity.Question3_13 = db.Question3_13;
            entity.Question3_13Male = db.Question3_13Male;
            entity.Question3_13Femal = db.Question3_13Femal;
            entity.Question3_14 = db.Question3_14;
            entity.Question3_14Male = db.Question3_14Male;
            entity.Question3_14Femal = db.Question3_14Femal;
            entity.Question3_15 = db.Question3_15;
            entity.Question3_15Male = db.Question3_15Male;
            entity.Question3_15Femal = db.Question3_15Femal;
            entity.Question3_16 = db.Question3_16;
            entity.Question3_16Male = db.Question3_16Male;
            entity.Question3_16Femal = db.Question3_16Femal;
            entity.Question3_17 = db.Question3_17;
            entity.Question3_17Male = db.Question3_17Male;
            entity.Question3_17Femal = db.Question3_17Femal;
            entity.Question3_18 = db.Question3_18;
            entity.Question3_18Male = db.Question3_18Male;
            entity.Question3_18Femal = db.Question3_18Femal;
            entity.Question3_19 = db.Question3_19;
            entity.Question3_20 = db.Question3_20;
            entity.Question3_20Text = db.Question3_20Text;
            entity.Question3_20Male = db.Question3_20Male;
            entity.Question3_20Femal = db.Question3_20Femal;
            entity.Question4_1_1 = db.Question4_1_1;
            entity.Question4_1_2 = db.Question4_1_2;
            entity.Question4_1_3 = db.Question4_1_3;
            entity.Question4_1_4 = db.Question4_1_4;
            entity.Question4_1_5 = db.Question4_1_5;
            entity.Question4_1_6 = db.Question4_1_6;
            entity.Question4_1_7 = db.Question4_1_7;
            entity.Question4_1_8 = db.Question4_1_8;
            entity.Question4_1_9 = db.Question4_1_9;
            entity.Question4_1_9Text = db.Question4_1_9Text;
            entity.Question4_1_10 = db.Question4_1_10;
            entity.Question_5 = db.Question_5;
            entities.Questionnaire_Table.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Destroy(QuestionnaireViewModel db)
        {
            var entity = new Questionnaire_Table();

            entity.QuestionnaireID = db.QuestionnaireID;

            entities.Questionnaire_Table.Attach(entity);

            entities.Questionnaire_Table.Remove(entity);

            entities.SaveChanges();
        }

    }
}