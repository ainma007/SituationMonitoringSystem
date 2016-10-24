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
    
    public partial class Situation_Table
    {
        public Situation_Table()
        {
            this.PersonInNeed_table = new HashSet<PersonInNeed_table>();
            this.Questionnaire_Table = new HashSet<Questionnaire_Table>();
            this.SituationUser_Table = new HashSet<SituationUser_Table>();
        }
    
        public int SituationID { get; set; }
        public Nullable<System.DateTime> SituationDate { get; set; }
        public Nullable<int> GovernorateID { get; set; }
        public Nullable<int> MunicipalityID { get; set; }
        public Nullable<int> AreaID { get; set; }
        public string CollectiveCenter { get; set; }
        public string Site_Description { get; set; }
        public Nullable<int> UserID { get; set; }
        public bool satus { get; set; }
    
        public virtual Area_Table Area_Table { get; set; }
        public virtual Governorate_Table Governorate_Table { get; set; }
        public virtual Municipality_Table Municipality_Table { get; set; }
        public virtual ICollection<PersonInNeed_table> PersonInNeed_table { get; set; }
        public virtual ICollection<Questionnaire_Table> Questionnaire_Table { get; set; }
        public virtual ICollection<SituationUser_Table> SituationUser_Table { get; set; }
        public virtual Users_Table Users_Table { get; set; }
    }
}
