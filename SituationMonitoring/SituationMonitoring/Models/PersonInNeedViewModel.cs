﻿using SituationMonitoring.Models.SessionForeignKey;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SituationMonitoring.Models
{
    public class PersonInNeedViewModel
    {

        public int ID { get; set; }

        [DisplayName("اسم الشخص")]

        public int? SituationID { get; set; }
        public int? UserID { get; set; }
        public string UserName { get; set; }
        public string Name_of_Person_In_Need { get; set; }

        [DisplayName("معلومات الاتصال")]

        public string Contact_Details { get; set; }

        [UIHint("ClientGovernorate")]
        public Key_concernForeingKey Key_concern
        {
            get;
            set;
        }

        [UIHint("KeyConcernID")]
        [DisplayName("الاهتمام الرئيسي")]
        public int? KeyConcernID { get; set; }

        [DisplayName("الجنس")]

        public string Gender { get; set; }
        [DisplayName("العمر")]

        public int? Age { get; set; }

        [DisplayName("الإجراءات المتخذة حتى الآن")]

        public string ActionsTakenSoFar { get; set; }
        [DisplayName("المتابعة المطلوبة")]

        public string FollowUpRequired { get; set; }

        
        
    }
}