using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SituationMonitoring.Models
{
    public class AreaViewModel
    {
        [ScaffoldColumn(false)]
        public int AreaID
        {
            get;
            set;
        }

        [Required]
        [DisplayName("اسم المنطقة عربي:")]
        public string AreaArName
        {
            get;
            set;
        }


        [Required]
        [DisplayName("اسم المنطقة EN:")]
        public string AreaEnName
        {
            get;
            set;
        }


        [UIHint("ClientGovernorate")]
        public GovernorateViewModel Governorate
        {
            get;
            set;
        }
        [UIHint("GovernorateID")]
        [DisplayName("المحافظة")]
        public int? GovernorateID { get; set; }
    }
}
