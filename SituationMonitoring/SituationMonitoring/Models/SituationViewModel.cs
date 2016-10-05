using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace SituationMonitoring.Models
{
    public class SituationViewModel
    {
        public int SituationID
        {
            get;
            set;
        }

        [DisplayName("التاريخ:")]
        [DataType(DataType.Date)]
        public DateTime SituationDate
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




        [UIHint("ClientMunicipality")]
        public SessionForeignKey.MunicipalityForeingKey Municipality
        {
            get;
            set;
        }



        [UIHint("MunicipalityID")]
        [DisplayName("البلدية")]
        public int? MunicipalityID { get; set; }



        [UIHint("ClientArea")]
        public SessionForeignKey.AreaForeingKey Area
        {
            get;
            set;
        }

        
        [UIHint("AreaID")]
        [DisplayName("المنطقة")]
        public int? AreaID { get; set; }


        [DisplayName("مركز الايواء")]
        public string CollectiveCenter { get; set; }
        [DisplayName("وصف الموقع")]
        public string Site_Description { get; set; }


    }
}
