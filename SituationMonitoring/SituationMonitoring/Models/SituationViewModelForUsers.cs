using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SituationMonitoring.Models
{
    public class SituationViewModelForUsers
    {
        [ScaffoldColumn(false)]
        public int UserSituationID
        {
            get;
            set;
        }

        public int? MYUserID
        {
            get;
            set;
        }

        public int? SituationtID
        {
            get;
            set;
        }



        [DisplayName("التاريخ :")]
        [DataType(DataType.Date)]
        public DateTime SituationStartDate
        {
            get;
            set;
        }


        [DisplayName("الحالة:")]
        public bool Status
        {
            get;
            set;
        }

   

    }
}