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
    
    public partial class Users_Table
    {
        public Users_Table()
        {
            this.SituationUser_Table = new HashSet<SituationUser_Table>();
        }
    
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public bool Status { get; set; }
    
        public virtual ICollection<SituationUser_Table> SituationUser_Table { get; set; }
    }
}
