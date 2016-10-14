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

        #region(2. اهتمامات الحماية الواضحة داخل مركز الإيواء)
        [DisplayName("خلافات عائلية / مجتمعية  ")]
        public bool Question2_1_1Family_CommunityDisputes
        { get; set; }

        [DisplayName("غذاء غير كافي  ")]
        public bool Question2_1_2NotEnoughFood
        { get; set; }

        [DisplayName("خصوصية غير كافية  ")]
        public bool Question2_1_3NotEnoughPrivacy
        { get; set; }


        [DisplayName("مياه شرب غير كافية  ")]
        public bool Question2_1_4NotDrinkingEnoughWater
        { get; set; }


        [DisplayName("سكن غير آمن  ")]
        public bool Question2_1_5UnsafeHousing
        { get; set; }


        [DisplayName("اكتظاظ في المسكن  ")]
        public bool Question2_1_6Overcrowding
        { get; set; }


        [DisplayName("فراش غير كافي  ")]
        public bool Question2_1_7InsufficientBedding
        { get; set; }


        [DisplayName("مياه قليلة (غير مياه الشرب)  ")]
        public bool Question2_1_8NotEnoughWater
        { get; set; }


        [DisplayName("المساعدة الإنسانية غير كافية للأشخاص المحتاجين")]
        public bool Question2_1_9NotEnoughHumanitarianAssistance
        { get; set; }


        [DisplayName("حدد نوع المساعدة الإنسانية المعدومة  ")]
        public string Question2_1_9Text
        { get; set; }


        [DisplayName("عدم القدرة على الوصول إلى الخدمات الأساسية ")]
        public bool Question2_1_10NoAccessToEssentialServices
        { get; set; }


        [DisplayName("اذكر هذه الخدمات  ")]
        public string Question2_1_10Text
        { get; set; }


        [DisplayName("توزيع المساعدات يستثني الأسر التي يعيلها الأطفال  ")]
        public bool Question2_1_11DistributionOfAssistanceExcludesChild_headedFamilies
        { get; set; }


        [DisplayName("توزيع المساعدات يستثني الأسر التي تعيلها النساء  ")]
        public bool Question2_1_12DistributionOfAssistanceExcludesWomen_headedFamilies
        { get; set; }

        [DisplayName("نقص الأماكن الآمنة لجمع النساء والفتيات معاً  ")]
        public bool Question2_1_13LackOfSafeSpacesForWomenAndGirlsToGather
        { get; set; }

        [DisplayName("نقص الأماكن الآمنة للعب الأطفال  ")]
        public bool Question2_1_14LackOfSafeSpacesForChildrenToPlay
        { get; set; }

        [DisplayName("نقص الإضاءة المناسبة في المراحيض  ")]
        public bool Question2_1_15LackOfAdequateLightingForToilets
        { get; set; }

        [DisplayName("نقص المراحيض المخصصة لكلا الجنسين  ")]
        public bool Question2_1_16LackOfGenderSegregatedToilets
        { get; set; }

        [DisplayName("نقص أماكن الاستحمام المخصصة لكلا الجنسين  ")]
        public bool Question2_1_17LackOfGenderSegregatedBathingFacilities
        { get; set; }

        [DisplayName("غير ذلك  ")]
        public bool Question2_1_18Other
        { get; set; }

        [DisplayName("اذكرها  ")]
        public string Question2_1_18text
        { get; set; }


        [DisplayName("2.2 هل يشعر الناس بعدم الأمان داخل مركز الإيواء؟  ")]
        public string Question2_2
        { get; set; }

        [DisplayName("2.2.1 إذا كانت الإجابة بنعم، بأي طريقة (فسّر)؟  ")]
        public string Question2_2_1
        { get; set; }

        [DisplayName("2.3 هل يعرف الناس داخل مراكز الإيواء كيفية الوصول إلى المساعدة و/أو المعلومات؟  ")]
        public string Question2_3
        { get; set; }
        [DisplayName("2.3.1 إذا كانت الإجابة بنعم، أين يطلب الناس المساعدة و/أو المعلومات؟  ")]
        public string Question2_3_1
        { get; set; }


        #endregion
        #region(اهتمامات حماية محددة (للتذكير الأطفال هم الأشخاص ما دون سن 18 سنة)

        [DisplayName("3.1 هل يوجد أطفال منفصلين عن والديهم أو مقدمي الرعاية، ولكن ليس من الضرورة أن يكونوا منفصلين عن أسرهم الممتدة؟")]
        public string Question3_1
        { get; set; }

        [DisplayName("ذكور")]
        public int? Question3_1Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_1Femal
        { get; set; }

        [DisplayName(" 3.2 هل يوجد أطفال منفصلين عن والديهم أو مقدمي الرعاية، ويعيشون إما وحدهم أو من دون مقدم الرعاية المناسب؟")]
        public string Question3_2
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_2Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_2Femal
        { get; set; }

        [DisplayName(" 3.3 هل يوجد موجه منزلي للأطفال")]
        public string Question3_3
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_3Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_3Femal
        { get; set; }

        [DisplayName(" 3.4 هل يوجد أطفال يعانون من إصابات جسدية وبحاجة إلى المساعدة؟")]
        public string Question3_4
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_4Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_4Femal
        { get; set; }

        [DisplayName(" 3.5 هل يوجد أشخاص بالغين يعانون من إصابات جسدية وبحاجة إلى المساعدة؟")]
        public string Question3_5
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_5Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_5Femal
        { get; set; }

        [DisplayName(" 3.6 هل يوجد أطفال تضرروا نتيجة العنف الأسري أو المجتمعي؟")]
        public string Question3_6
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_6Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_6Femal
        { get; set; }

        [DisplayName(" 3.7 هل يوجد أشخاص بالغين تضرروا نتيجة العنف الأسري أو المجتمعي؟")]
        public string Question3_7
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_7Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_7Femal
        { get; set; }

        [DisplayName(" 3.8 هل يوجد أطفال متضررين بشدة؟")]
        public string Question3_8
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_8Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_8Femal
        { get; set; }


        [DisplayName(" 3.9 هل يوجد أشخاص بالغين متضررين بشدة؟")]
        public string Question3_9
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_9Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_9Femal
        { get; set; }


        [DisplayName(" 3.10 هل يوجد أطفال مشاركين بأعمال التسول أو أشكال الاستغلال لعمالة الأطفال؟")]
        public string Question3_10
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_10Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_10Femal
        { get; set; }

        [DisplayName(" 3.11 هل يوجد أطفال ذوي إعاقة بحاجة لمساعدة خاصة؟")]
        public string Question3_11
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_11Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_11Femal
        { get; set; }


        [DisplayName("3.12 هل يوجد أشخاص بالغين ذوي إعاقة بحاجة لمساعدة خاصة؟")]
        public string Question3_12
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_12Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_12Femal
        { get; set; }


        [DisplayName("3.13 هل يوجد حوادث عنف منزلي؟")]
        public string Question3_13
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_13Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_13Femal
        { get; set; }


        [DisplayName("3.14 Are there unaccompanied single women?")]
        public string Question3_14
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_14Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_14Femal
        { get; set; }

        [DisplayName("3.15 Are there female widows as a result of the emergency؟")]
        public string Question3_15
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_15Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_15Femal
        { get; set; }

        [DisplayName("3.16 Are there persons with chronic illness/untreated mental health issue?")]
        public string Question3_16
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_16Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_16Femal
        { get; set; }

        [DisplayName("3.17 هل يوجد كبار سن بحاجة لمساعدة؟")]
        public string Question3_17
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_17Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_17Femal
        { get; set; }

        [DisplayName("3.18 هل يوجد أشخاص متضررين بحاجة لمساعدة قانونية؟")]
        public string Question3_18
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_18Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_18Femal
        { get; set; }


        [DisplayName("3.19 هل يوجد أي حوادث معروفة لعنف جنسي؟")]
        public string Question3_19
        { get; set; }

       

        [DisplayName("3.20 اهتمامات حماية أخرى: ")]
        public string Question3_20
        { get; set; }

        [DisplayName("3.20.1 يرجى وصف اهتمامات الحماية التي تم تحديدها: ")]
        public string Question3_20Text
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_20Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_20Femal
        { get; set; }

        #endregion

        #region(4. من يقدم المساعدة والدعم للناس المحتاجين؟(اختر العديد من الإجابات التي تنطبق))
        [DisplayName("وزارة الشؤون الاجتماعية")]
        public bool Question4_1_1
        { get; set; }

        [DisplayName("الشرطة")]
        public bool Question4_1_2
        { get; set; }


        [DisplayName("المنظمات غير الحكومية المحلية")]
        public bool Question4_1_3
        { get; set; }

        [DisplayName("أعضاء المجتمع")]
        public bool Question4_1_4
        { get; set; }

        [DisplayName("قادة المجتمع")]
        public bool Question4_1_5
        { get; set; }

        [DisplayName("شخصيات دينية")]
        public bool Question4_1_6
        { get; set; }

        [DisplayName("المنظمات غير الحكومية الدولية")]
        public bool Question4_1_7
        { get; set; }

        [DisplayName("لا أحد")]
        public bool Question4_1_8
        { get; set; }

        [DisplayName("غير ذلك)")]
        public bool Question4_1_9
        { get; set; }

        [DisplayName("اذكر الجهة ")]
        public string Question4_1_9Text
        { get; set; }

        [DisplayName("لا أعرف")]
        public bool Question4_1_10
        { get; set; }

        [DisplayName("قم بتحديد أي من المخاوف، حيث أنه من الممكن ألا تتوفر لدينا الإمكانية أو الموارد للاستجابة والتدخل بشكل مباشر، يمكننا على الأقل أن ننتواصل بخصوص الحالة مع وزارة الشئون الاجتماعية ومع العاملين ذوي العلاقة في المجال الإنساني")]
        public string Question_5
        { get; set; }

        #endregion
    }
}