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
    
    public partial class Governorate_Table
    {
        public Governorate_Table()
        {
            this.Municipality_Table = new HashSet<Municipality_Table>();
        }
    
        public int GovernorateID { get; set; }
        public string GovernorateEnName { get; set; }
        public string GovernorateArName { get; set; }
    
        public virtual ICollection<Municipality_Table> Municipality_Table { get; set; }
    }
}
