//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SituationMonitoring.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Questionnaire_Table
    {
        public int QuestionnaireID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> SituationID { get; set; }
        public Nullable<System.DateTime> QuestionnaireDate { get; set; }
        public string EmployeeName { get; set; }
        public string CenterName { get; set; }
        public string EmployeeMail { get; set; }
        public string EmployeePhone { get; set; }
        public string PersonName { get; set; }
        public string PersonGEnder { get; set; }
        public string RoleInCommunity { get; set; }
        public string Place_of_origin { get; set; }
        public string PersonMobile { get; set; }
        public string CollectiveCenter { get; set; }
        public Nullable<int> Estimated_Number_Of_Individuals { get; set; }
        public Nullable<int> Estimated_Number_Of_Families { get; set; }
        public string Site_Description { get; set; }
        public string Question1_1 { get; set; }
        public string Question1_1_1 { get; set; }
        public bool Question1_2_1_Family_CommunityDisputes { get; set; }
        public bool Question_1_2_2NotEnoughFood { get; set; }
        public bool Question1_2_3NotEnoughPrivacy { get; set; }
        public bool Question1_2_4NotEnoughDrinking { get; set; }
        public bool Question1_2_5UnsafeHousing { get; set; }
        public bool Question1_2_6Overcrowding { get; set; }
        public bool Question1_2_7InsufficientBedding { get; set; }
        public bool Question1_2_8NotEnoughWater { get; set; }
        public bool Question1_2_9Not_enough_humanitarian_assistance { get; set; }
        public string Question1_2_9Text { get; set; }
        public bool Question1_2_10No_Access_to_essential_services { get; set; }
        public string Question1_2_10Text { get; set; }
        public bool Question1_2_11Other { get; set; }
        public string Question1_2_11Text { get; set; }
        public bool Question1_3_1Family_CommunityDisputes { get; set; }
        public bool Question1_3_2NotEnoughFood { get; set; }
        public bool Question1_3_3NotEnoughDrinking { get; set; }
        public bool Question1_3_4UnsafeHousing { get; set; }
        public bool Question1_3_5Overcrowding { get; set; }
        public bool Question1_3_5NotEnoughWater { get; set; }
        public bool Question1_3_6Not_enough_humanitarian_assistance { get; set; }
        public string Question1_3_6Text { get; set; }
        public bool Question1_3_7No_Access_to_essential_services { get; set; }
        public string Question1_3_7Text { get; set; }
        public bool Question1_3_8Other { get; set; }
        public string Question1_3_8Text { get; set; }
        public string Question1_4 { get; set; }
        public string Question1_4_1 { get; set; }
    
        public virtual Situation_Table Situation_Table { get; set; }
        public virtual Users_Table Users_Table { get; set; }
    }
}
