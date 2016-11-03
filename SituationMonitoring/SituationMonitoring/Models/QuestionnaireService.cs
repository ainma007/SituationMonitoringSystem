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
                SituationID = db.SituationID,
                UserFullName = db.Users_Table.FullName,
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
                Question1_3_3NotEnoughPrivacy = db.Question1_3_3NotEnoughPrivacy,
                Question1_3_4NotenoughDrinkingWater = db.Question1_3_4NotenoughDrinkingWater,
                Question1_3_5UnsafeHousing = db.Question1_3_5UnsafeHousing,
                Question1_3_6Overcrowding = db.Question1_3_6Overcrowding,
                Question1_3_7InsufficientBedding = db.Question1_3_7InsufficientBedding,
                Question1_3_8NotEnoughWater_otherThanDrinking = db.Question1_3_8NotEnoughWater_otherThanDrinking,
                Question1_3_9Not_enough_humanitarian_assistance = db.Question1_3_9Not_enough_humanitarian_assistance,
                Question1_3_9Text = db.Question1_3_9Text,
                Question1_3_10No_Access_to_essential_services = db.Question1_3_10No_Access_to_essential_services,
                Question1_3_10Text = db.Question1_3_10Text,
                Question1_3_11Other = db.Question1_3_11Other,
                Question1_3_11Text = db.Question1_3_11Text,

                Question1_4 = db.Question1_4,
                Question1_4_1 = db.Question1_4_1,
                Question2_1_1Family_CommunityDisputes = db.Question2_1_1Family_CommunityDisputes,
                Question2_1_2NotEnoughFood = db.Question2_1_2NotEnoughFood,
                Question2_1_3enough_privacy_in_DES_rooms = db.Question2_1_3enough_privacy_in_DES_rooms,
                Question2_1_4NotEnoughPrivacy = db.Question2_1_4NotEnoughPrivacy,
                Question2_1_5NotDrinkingEnoughWater = db.Question2_1_5NotDrinkingEnoughWater,
                Question2_1_6Unsafe_housing = db.Question2_1_6Unsafe_housing,
                Question2_1_7IOvercrowding = db.Question2_1_7IOvercrowding,
                Question2_1_8Insufficient_bedding = db.Question2_1_8Insufficient_bedding,
                Question2_1_9NotEnoughWater_OtherThanDrinking = db.Question2_1_9NotEnoughWater_OtherThanDrinking,
                Question2_1_10NotEnoughHumanitarianAssistanceForPeopleInNeed = db.Question2_1_10NotEnoughHumanitarianAssistanceForPeopleInNeed,
                Question2_1_10Text = db.Question2_1_10Text,
                Question2_1_11NoAccessToEssentialServices = db.Question2_1_11NoAccessToEssentialServices,
                Question2_1_11Text = db.Question2_1_11Text,
                Question2_1_12DistributionOfAssistanceExcludesChild_HeadedFamilies = db.Question2_1_12DistributionOfAssistanceExcludesChild_HeadedFamilies,
                Question2_1_13DistributionOfAssistanceExcludesWomen_HeadedFamilies = db.Question2_1_13DistributionOfAssistanceExcludesWomen_HeadedFamilies,
                Question2_1_14LackOfSafeSpacesForWomenAndGirlsToGather = db.Question2_1_14LackOfSafeSpacesForWomenAndGirlsToGather,
                Question2_1_15LackOfSafeSpacesForChildrenToPlay = db.Question2_1_15LackOfSafeSpacesForChildrenToPlay,
                Question2_1_16LackOfAdequatelightingForToilets = db.Question2_1_16LackOfAdequatelightingForToilets,

                Question2_1_17LackOfGenderSegregatedToilets = db.Question2_1_17LackOfGenderSegregatedToilets,
                Question2_1_18LackOfGenderSegregatedBathingFacilitites = db.Question2_1_18LackOfGenderSegregatedBathingFacilitites,
                Question2_1_19LackOfAccessibleBathrooms = db.Question2_1_19LackOfAccessibleBathrooms,
                Question2_1_20DistributionOfAssistanceExcludePersonsWithDisabilitiesAndTheirFamilies = db.Question2_1_20DistributionOfAssistanceExcludePersonsWithDisabilitiesAndTheirFamilies,
                Question2_1_21LackOfAssistiveDevices = db.Question2_1_21LackOfAssistiveDevices,
                Question2_1_22ConcernOverFamilyMemberMissing = db.Question2_1_22ConcernOverFamilyMemberMissing,
                Question2_1_23Other = db.Question2_1_23Other,
                Question2_1_23Text=db.Question2_1_23Text,
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
            Question3_14Femal = db.Question3_14Femal,
            Question3_15 = db.Question3_15,
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
                Question3_19Femal=db.Question3_19Femal,
                Question3_19Male=db.Question3_19Male,
                Question3_20 = db.Question3_20,
                Question3_21 = db.Question3_20,

                Question3_21Text = db.Question3_21Text,
                Question3_21Male = db.Question3_21Male,
                Question3_21Femal = db.Question3_21Femal,
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

  

        public void Create(QuestionnaireViewModel db )
        {
            var entity = new Questionnaire_Table();

            entity.QuestionnaireDate = (DateTime)db.QuestionnaireDate.Date;
            entity.UserID = int.Parse(HttpContext.Current.Session["UserID"].ToString());
            entity.SituationID = db.SituationID; /// <<<<<<__
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
            entity.Question1_3_3NotEnoughPrivacy = db.Question1_3_3NotEnoughPrivacy;
            entity.Question1_3_4NotenoughDrinkingWater = db.Question1_3_4NotenoughDrinkingWater;
            entity.Question1_3_5UnsafeHousing = db.Question1_3_5UnsafeHousing;
            entity.Question1_3_6Overcrowding = db.Question1_3_6Overcrowding;
            entity.Question1_3_7InsufficientBedding = db.Question1_3_7InsufficientBedding;
            entity.Question1_3_8NotEnoughWater_otherThanDrinking = db.Question1_3_8NotEnoughWater_otherThanDrinking;
            entity.Question1_3_9Not_enough_humanitarian_assistance = db.Question1_3_9Not_enough_humanitarian_assistance;
            entity.Question1_3_9Text = db.Question1_3_9Text;
            entity.Question1_2_10No_Access_to_essential_services = db.Question1_2_10No_Access_to_essential_services;
            entity.Question1_3_10No_Access_to_essential_services = db.Question1_3_10No_Access_to_essential_services;
            entity.Question1_3_10Text = db.Question1_3_10Text;
            entity.Question1_3_11Other = db.Question1_3_11Other;
            entity.Question1_3_11Text = db.Question1_3_11Text;




            entity.Question1_4 = db.Question1_4;
            entity.Question1_4_1 = db.Question1_4_1;
            entity.Question2_1_1Family_CommunityDisputes = db.Question2_1_1Family_CommunityDisputes;
            entity.Question2_1_2NotEnoughFood = db.Question2_1_2NotEnoughFood;
            entity.Question2_1_3enough_privacy_in_DES_rooms = db.Question2_1_3enough_privacy_in_DES_rooms;
            entity.Question2_1_4NotEnoughPrivacy = db.Question2_1_4NotEnoughPrivacy;
            entity.Question2_1_5NotDrinkingEnoughWater = db.Question2_1_5NotDrinkingEnoughWater;
            entity.Question2_1_6Unsafe_housing = db.Question2_1_6Unsafe_housing;
            entity.Question2_1_7IOvercrowding = db.Question2_1_7IOvercrowding;
            entity.Question2_1_8Insufficient_bedding = db.Question2_1_8Insufficient_bedding;
            entity.Question2_1_9NotEnoughWater_OtherThanDrinking = db.Question2_1_9NotEnoughWater_OtherThanDrinking;
            entity.Question2_1_10NotEnoughHumanitarianAssistanceForPeopleInNeed = db.Question2_1_10NotEnoughHumanitarianAssistanceForPeopleInNeed;
            entity.Question2_1_10Text = db.Question2_1_10Text;
            entity.Question2_1_11NoAccessToEssentialServices = db.Question2_1_11NoAccessToEssentialServices;
            entity.Question2_1_11Text = db.Question2_1_11Text;
            entity.Question2_1_12DistributionOfAssistanceExcludesChild_HeadedFamilies = db.Question2_1_12DistributionOfAssistanceExcludesChild_HeadedFamilies;
            entity.Question2_1_13DistributionOfAssistanceExcludesWomen_HeadedFamilies = db.Question2_1_13DistributionOfAssistanceExcludesWomen_HeadedFamilies;
            entity.Question2_1_14LackOfSafeSpacesForWomenAndGirlsToGather = db.Question2_1_14LackOfSafeSpacesForWomenAndGirlsToGather;
            entity.Question2_1_15LackOfSafeSpacesForChildrenToPlay = db.Question2_1_15LackOfSafeSpacesForChildrenToPlay;
            entity.Question2_1_16LackOfAdequatelightingForToilets = db.Question2_1_16LackOfAdequatelightingForToilets;

            entity.Question2_1_17LackOfGenderSegregatedToilets = db.Question2_1_17LackOfGenderSegregatedToilets;
            entity.Question2_1_18LackOfGenderSegregatedBathingFacilitites = db.Question2_1_18LackOfGenderSegregatedBathingFacilitites;
            entity.Question2_1_19LackOfAccessibleBathrooms = db.Question2_1_19LackOfAccessibleBathrooms;
            entity.Question2_1_20DistributionOfAssistanceExcludePersonsWithDisabilitiesAndTheirFamilies = db.Question2_1_20DistributionOfAssistanceExcludePersonsWithDisabilitiesAndTheirFamilies;
            entity.Question2_1_21LackOfAssistiveDevices = db.Question2_1_21LackOfAssistiveDevices;
            entity.Question2_1_22ConcernOverFamilyMemberMissing = db.Question2_1_22ConcernOverFamilyMemberMissing;
            entity.Question2_1_23Other = db.Question2_1_23Other;
            entity.Question2_1_23Text = db.Question2_1_23Text;
         

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
            entity.Question3_14Femal = db.Question3_14Femal;
            entity.Question3_15 = db.Question3_15;
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
            entity.Question3_19Male = db.Question3_19Male;
            entity.Question3_19Femal = db.Question3_19Femal;

            entity.Question3_20 = db.Question3_20;
            entity.Question3_21 = db.Question3_21;
            entity.Question3_21Text = db.Question3_21Text;
            entity.Question3_21Male = db.Question3_21Male;
            entity.Question3_21Femal = db.Question3_21Femal;
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
           // <<<<<<------
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
            entity.Question1_3_3NotEnoughPrivacy = db.Question1_3_3NotEnoughPrivacy;
            entity.Question1_3_4NotenoughDrinkingWater = db.Question1_3_4NotenoughDrinkingWater;
            entity.Question1_3_5UnsafeHousing = db.Question1_3_5UnsafeHousing;
            entity.Question1_3_6Overcrowding = db.Question1_3_6Overcrowding;
            entity.Question1_3_7InsufficientBedding = db.Question1_3_7InsufficientBedding;
            entity.Question1_3_8NotEnoughWater_otherThanDrinking = db.Question1_3_8NotEnoughWater_otherThanDrinking;
            entity.Question1_3_9Not_enough_humanitarian_assistance = db.Question1_3_9Not_enough_humanitarian_assistance;
            entity.Question1_3_9Text = db.Question1_3_9Text;
            entity.Question1_2_10No_Access_to_essential_services = db.Question1_2_10No_Access_to_essential_services;
            entity.Question1_3_10No_Access_to_essential_services = db.Question1_3_10No_Access_to_essential_services;
            entity.Question1_3_10Text = db.Question1_3_10Text;
            entity.Question1_3_11Other = db.Question1_3_11Other;
            entity.Question1_3_11Text = db.Question1_3_11Text;




            entity.Question1_4 = db.Question1_4;
            entity.Question1_4_1 = db.Question1_4_1;
            entity.Question2_1_1Family_CommunityDisputes = db.Question2_1_1Family_CommunityDisputes;
            entity.Question2_1_2NotEnoughFood = db.Question2_1_2NotEnoughFood;
            entity.Question2_1_3enough_privacy_in_DES_rooms = db.Question2_1_3enough_privacy_in_DES_rooms;
            entity.Question2_1_4NotEnoughPrivacy = db.Question2_1_4NotEnoughPrivacy;
            entity.Question2_1_5NotDrinkingEnoughWater = db.Question2_1_5NotDrinkingEnoughWater;
            entity.Question2_1_6Unsafe_housing = db.Question2_1_6Unsafe_housing;
            entity.Question2_1_7IOvercrowding = db.Question2_1_7IOvercrowding;
            entity.Question2_1_8Insufficient_bedding = db.Question2_1_8Insufficient_bedding;
            entity.Question2_1_9NotEnoughWater_OtherThanDrinking = db.Question2_1_9NotEnoughWater_OtherThanDrinking;
            entity.Question2_1_10NotEnoughHumanitarianAssistanceForPeopleInNeed = db.Question2_1_10NotEnoughHumanitarianAssistanceForPeopleInNeed;
            entity.Question2_1_10Text = db.Question2_1_10Text;
            entity.Question2_1_11NoAccessToEssentialServices = db.Question2_1_11NoAccessToEssentialServices;
            entity.Question2_1_11Text = db.Question2_1_11Text;
            entity.Question2_1_12DistributionOfAssistanceExcludesChild_HeadedFamilies = db.Question2_1_12DistributionOfAssistanceExcludesChild_HeadedFamilies;
            entity.Question2_1_13DistributionOfAssistanceExcludesWomen_HeadedFamilies = db.Question2_1_13DistributionOfAssistanceExcludesWomen_HeadedFamilies;
            entity.Question2_1_14LackOfSafeSpacesForWomenAndGirlsToGather = db.Question2_1_14LackOfSafeSpacesForWomenAndGirlsToGather;
            entity.Question2_1_15LackOfSafeSpacesForChildrenToPlay = db.Question2_1_15LackOfSafeSpacesForChildrenToPlay;
            entity.Question2_1_16LackOfAdequatelightingForToilets = db.Question2_1_16LackOfAdequatelightingForToilets;
            entity.Question2_1_17LackOfGenderSegregatedToilets = db.Question2_1_17LackOfGenderSegregatedToilets;
            entity.Question2_1_18LackOfGenderSegregatedBathingFacilitites = db.Question2_1_18LackOfGenderSegregatedBathingFacilitites;
            entity.Question2_1_19LackOfAccessibleBathrooms = db.Question2_1_19LackOfAccessibleBathrooms;
            entity.Question2_1_20DistributionOfAssistanceExcludePersonsWithDisabilitiesAndTheirFamilies = db.Question2_1_20DistributionOfAssistanceExcludePersonsWithDisabilitiesAndTheirFamilies;
            entity.Question2_1_21LackOfAssistiveDevices = db.Question2_1_21LackOfAssistiveDevices;
            entity.Question2_1_22ConcernOverFamilyMemberMissing = db.Question2_1_22ConcernOverFamilyMemberMissing;
            entity.Question2_1_23Other = db.Question2_1_23Other;
            entity.Question2_1_23Text = db.Question2_1_23Text;


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
            entity.Question3_14Femal = db.Question3_14Femal;
            entity.Question3_15 = db.Question3_15;
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
            entity.Question3_19Male = db.Question3_19Male;
            entity.Question3_19Femal = db.Question3_19Femal;
            entity.Question3_20 = db.Question3_20;
            entity.Question3_21 = db.Question3_21;
            entity.Question3_21Text = db.Question3_21Text;
            entity.Question3_21Male = db.Question3_21Male;
            entity.Question3_21Femal = db.Question3_21Femal;
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