using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SituationMonitoring.Models
{
    public class SituationUserViewModel
    {
        [ScaffoldColumn(false)]
        public int ID
        {
            get;
            set;
        }


        [UIHint("Clientproject")]
        public SessionForeignKey.SituationForeingKey projects
        {
            get;
            set;
        }

        [UIHint("SituationID")]
        [DisplayName("رقم النموذج:")]
        public int? SituationID { get; set; }


        [UIHint("ClientUser")]
        public SessionForeignKey.UserForeingKey Users
        {
            get;
            set;
        }

        [UIHint("UserID")]
        [DisplayName("اسم المستخدم:")]
        public int? UserID { get; set; }


        [DisplayName("الحالة:")]
        public bool Status { get; set; }
    }
}