using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace SituationMonitoring.Models
{
    public class QuestionnaireViewModel
    {

        public int QuestionnaireID { get; set; }

        public int? UserID { get; set; }
        public int? SituationID { get; set; }

        [DisplayName("التاريخ:")]
        [DataType(DataType.Date)]
        public DateTime QuestionnaireDate
        {
            get;
            set;
        }

        #region(بيانات الموظف)
        [DisplayName("اسم الموظف")]
        public string EmployeeName { get; set; }

        [DisplayName("المؤسسة")]
        public string CenterName { get; set; }

        [DisplayName("البريد الالكتروني")]
        public string EmployeeMail { get; set; }

        [DisplayName("رقم الهاتف")]
        public string EmployeePhone { get; set; }

        #endregion


        #region(بيانات الشخص المقابل)
        [DisplayName("الاسم")]
        public string PersonName { get; set; }

        [DisplayName("الجنس")]
        public string PersonGEnder { get; set; }

        [DisplayName("دورة في المجتمع")]
        public string RoleInCommunity { get; set; }

        [DisplayName("مكانه الاصلي")]
        public string Place_of_origin { get; set; }

        [DisplayName("رقم الجوال")]
        public string PersonMobile { get; set; }

        #endregion


        #region(مصادر معلومات الموقع)
        [DisplayName("المنطقة/مركز الايواء")]
        public string CollectiveCenter { get; set; }

        [DisplayName("العدد التقديري للأفراد")]
        public int? Estimated_Number_Of_Individuals { get; set; }

        [DisplayName("العدد التقديري للعائلات")]
        public int? Estimated_Number_Of_Families { get; set; }

        [DisplayName("وصف الموقع")]
        public string Site_Description { get; set; }



        #endregion

        #region(اهتمامات الحماية الواضحة خارج مركز الايواء)
        //Question1_1
        [DisplayName("1.1 هل أنت على علم بأي مجموعات أسرية تعيش مع عائلات مضيفة؟")]
        public string Question1_1 { get; set; }
     
       [DisplayName("1.1.1 إذا كانت الإجابة بنعم، ما هو عدد المجموعات الأسرية التي تقيم مع عائلات مضيفة؟")]
        public string Question1_1_1 { get; set; }


        //Question1_2
        [DisplayName("خلافات عائلية / مجتمعية")]
        public bool Question1_2_1_Family_CommunityDisputes { get; set; }

        [DisplayName("غذاء غير كافي")]
        public bool Question_1_2_2NotEnoughFood { get; set; }

        [DisplayName("خصوصية غير كافية")]
        public bool Question1_2_3NotEnoughPrivacy { get; set; }

        [DisplayName("مياه شرب غير كافية")]
        public bool Question1_2_4NotEnoughDrinking { get; set; }

        [DisplayName("سكن غير آمن")]
        public bool Question1_2_5UnsafeHousing { get; set; }

        [DisplayName("اكتظاظ في المسكن")]
        public bool Question1_2_6Overcrowding { get; set; }
        
        [DisplayName("فراش غير كافي")]
        public bool Question1_2_7InsufficientBedding { get; set; }

        [DisplayName("مياه قليلة (غير مياه الشرب)")]
        public bool Question1_2_8NotEnoughWater { get; set; }

        [DisplayName("المساعدة الإنسانية غير كافية للأشخاص المحتاجين ")]
        public bool Question1_2_9Not_enough_humanitarian_assistance { get; set; }

        [DisplayName("حدد نوع المساعدة الإنسانية المعدومة")]
        public string Question1_2_9Text { get; set; }

        [DisplayName("عدم القدرة على الوصول إلى الخدمات الأساسية ")]
        public bool Question1_2_10No_Access_to_essential_services
        { get; set; }
        
        [DisplayName("اذكر الخدمات ")]
        public string Question1_2_10Text
        { get; set; }

        [DisplayName("اخرى ")]
        public bool Question1_2_11Other
        { get; set; }

        [DisplayName("اذكرها: ")]
        public string Question1_2_11Text
        { get; set; }


        //Question1_3
        [DisplayName("خلافات عائلية / مجتمعية")]
        public bool Question1_3_1Family_CommunityDisputes { get; set; }

        [DisplayName("غذاء غير كافي")]
        public bool Question1_3_2NotEnoughFood { get; set; }
     
        [DisplayName("مياه شرب غير كافية")]
        public bool Question1_3_3NotEnoughDrinking { get; set; }

        [DisplayName("سكن غير آمن")]
        public bool Question1_3_4UnsafeHousing { get; set; }

        [DisplayName("اكتظاظ في المسكن")]
        public bool Question1_3_5Overcrowding { get; set; }

       
        [DisplayName("مياه قليلة (غير مياه الشرب)")]
        public bool Question1_3_5NotEnoughWater { get; set; }

        [DisplayName("المساعدة الإنسانية غير كافية للأشخاص المحتاجين ")]
        public bool Question1_3_6Not_enough_humanitarian_assistance { get; set; }

        [DisplayName("حدد نوع المساعدة الإنسانية المعدومة")]
        public string Question1_3_6Text { get; set; }

        [DisplayName("عدم القدرة على الوصول إلى الخدمات الأساسية ")]
        public bool Question1_3_7No_Access_to_essential_services
        { get; set; }

        [DisplayName("اذكر الخدمات ")]
        public string Question1_3_7Text
        { get; set; }

        [DisplayName("اخرى ")]
        public bool Question1_3_8Other
        { get; set; }

        [DisplayName("اذكرها: ")]
        public string Question1_3_8Text
        { get; set; }

        //Question1_4
        [DisplayName("1.4 هل يعرف الناس في منطقتكم كيفية الوصول إلى المساعدة و/أو المعلومات؟")]
        public string Question1_4 { get; set; }

        [DisplayName("1.4.1 إذا كانت الإجابة بنعم، أين يطلب الناس المساعدة و/أو المعلومات؟")]
        public string Question1_4_1 { get; set; }
        #endregion
    }
}