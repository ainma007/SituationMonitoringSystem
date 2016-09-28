using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SituationMonitoring.Models
{
    public class MunicipalityViewModel
    {
        [ScaffoldColumn(false)]
        public int MunicipalityID
        {
            get;
            set;
        }

        [Required]
        [DisplayName("اسم البلدية عربي:")]
        public string MunicipalityArName
        {
            get;
            set;
        }


        [Required]
        [DisplayName("اسم البلدية EN:")]
        public string MunicipalityEnName
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
