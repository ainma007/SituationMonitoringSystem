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

        [Required]

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
        [Required]

        [UIHint("GovernorateID")]
        [DisplayName("المحافظة")]
        public int? GovernorateID { get; set; }




        [UIHint("ClientMunicipality")]
        public SessionForeignKey.MunicipalityForeingKey Municipality
        {
            get;
            set;
        }


        [Required]

        [UIHint("MunicipalityID")]
        [DisplayName("البلدية")]
        public int? MunicipalityID { get; set; }



        [UIHint("ClientArea")]
        public SessionForeignKey.AreaForeingKey Area
        {
            get;
            set;
        }

        [Required]

        [UIHint("AreaID")]
        [DisplayName("المنطقة")]
        public int? AreaID { get; set; }


        [UIHint("ClientUser")]
        public SessionForeignKey.UserForeingKey Users
        {
            get;
            set;
        }

        

        [UIHint("UserID")]
        [DisplayName("اسم المستخدم:")]
        public int? UserID { get; set; }


        [DisplayName("الحالة")]
        public bool Status { get; set; }

        [Required]
        [DisplayName("مركز الايواء")]
        public string CollectiveCenter { get; set; }
        [Required]
        [DisplayName("وصف الموقع")]
        public string Site_Description { get; set; }


    }
}
