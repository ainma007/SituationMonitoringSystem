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


        [DisplayName("مدخل البيانات:")]
        public string UserFullName { get; set; }

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

        #region(. مخاوف حماية عامة خارج مركز الإيواء الجماعي)
        //Question1_1
        [DisplayName("1.1 هل أنت على علم بأي مجموعات أسرية تعيش مع عائلات مضيفة؟")]
        public string Question1_1 { get; set; }
     
       [DisplayName("1.1.1	إذا كانت الإجابة نعم، فكم عدد المجموعات العائلية التي تقطن مع عائلات مضيفة؟ ")]
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

        [DisplayName("ازدحام")]
        public bool Question1_2_6Overcrowding { get; set; }
        
        [DisplayName("فراش غير كافي")]
        public bool Question1_2_7InsufficientBedding { get; set; }

        [DisplayName("مياه قليلة (غير مياه الشرب)")]
        public bool Question1_2_8NotEnoughWater { get; set; }

        [DisplayName("لا يوجد مساعدة إغاثية لجميع المحتاجين  ")]
        public bool Question1_2_9Not_enough_humanitarian_assistance { get; set; }

        [DisplayName("اذكر أي المساعدات الإغاثية الناقصة")]
        public string Question1_2_9Text { get; set; }

        [DisplayName("لا إمكانية وصول إلى الخدمات  ")]
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


        //Question1_2
        [DisplayName("خلافات عائلية / مجتمعية")]
        public bool Question1_3_1Family_CommunityDisputes { get; set; }

        [DisplayName("غذاء غير كافي")]
        public bool Question1_3_2NotEnoughFood { get; set; }

        [DisplayName("خصوصية غير كافية")]
        public bool Question1_3_3NotEnoughPrivacy { get; set; }

        [DisplayName("مياه شرب غير كافية")]
        public bool Question1_3_4NotenoughDrinkingWater { get; set; }

        [DisplayName("سكن غير آمن")]
        public bool Question1_3_5UnsafeHousing { get; set; }

        [DisplayName("ازدحام")]
        public bool Question1_3_6Overcrowding { get; set; }

        [DisplayName("فراش غير كافي")]
        public bool Question1_3_7InsufficientBedding { get; set; }

        [DisplayName("مياه قليلة (غير مياه الشرب)")]
        public bool Question1_3_8NotEnoughWater_otherThanDrinking { get; set; }

        [DisplayName("لا يوجد مساعدة إغاثية لجميع المحتاجين  ")]
        public bool Question1_3_9Not_enough_humanitarian_assistance { get; set; }

        [DisplayName("اذكر أي المساعدات الإغاثية الناقصة")]
        public string Question1_3_9Text { get; set; }

        [DisplayName("لا إمكانية وصول إلى الخدمات  ")]
        public bool Question1_3_10No_Access_to_essential_services
        { get; set; }

        [DisplayName("اذكر الخدمات ")]
        public string Question1_3_10Text
        { get; set; }

        [DisplayName("اخرى ")]
        public bool Question1_3_11Other
        { get; set; }

        [DisplayName("اذكرها: ")]
        public string Question1_3_11Text
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

        [DisplayName("خصوصية غير كافية في المراحيض ومرافق الاستحمام")]
        public bool Question2_1_3enough_privacy_in_DES_rooms
        { get; set; }


        [DisplayName("خصوصية غير كافية في مركز الإيواء الجماعي ")]
        public bool Question2_1_4NotEnoughPrivacy
        { get; set; }


        [DisplayName("ماء شرب غير كافي ")]
        public bool Question2_1_5NotDrinkingEnoughWater
        { get; set; }


        [DisplayName("سكن غير آمن")]
        public bool Question2_1_6Unsafe_housing
        { get; set; }


      
        [DisplayName("إزدحام")]
        public bool Question2_1_7IOvercrowding
        { get; set; }

        [DisplayName("فراش غير كافي  ")]
        public bool Question2_1_8Insufficient_bedding
        { get; set; }


        [DisplayName("مياه قليلة (غير مياه الشرب)  ")]
        public bool Question2_1_9NotEnoughWater_OtherThanDrinking
        { get; set; }


        [DisplayName("لا يوجد مساعدة إغاثية لجميع المحتاجين ")]
        public bool Question2_1_10NotEnoughHumanitarianAssistanceForPeopleInNeed
        { get; set; }


        [DisplayName("حدد نوع الاغاثة    ")]
        public string Question2_1_10Text
        { get; set; }


        [DisplayName("لا إمكانية وصول إلى الخدمات الضرورية ")]
        public bool Question2_1_11NoAccessToEssentialServices
        { get; set; }


        [DisplayName("اذكر هذه الخدمات  ")]
        public string Question2_1_11Text
        { get; set; }


        [DisplayName("توزيع المساعدات يستثني الأسر التي يعيلها الأطفال  ")]
        public bool Question2_1_12DistributionOfAssistanceExcludesChild_HeadedFamilies
        { get; set; }


        [DisplayName("توزيع المساعدات يستثني الأسر التي تعيلها النساء  ")]
        public bool Question2_1_13DistributionOfAssistanceExcludesWomen_HeadedFamilies
        { get; set; }

        [DisplayName("نقص الأماكن الآمنة لجمع النساء والفتيات معاً  ")]
        public bool Question2_1_14LackOfSafeSpacesForWomenAndGirlsToGather
        { get; set; }

        [DisplayName("عدم وجود مساحات آمنة للعب الأطفال ")]
        public bool Question2_1_15LackOfSafeSpacesForChildrenToPlay
        { get; set; }

        [DisplayName("عدم وجود إضاءة آمنة للحمامات ")]
        public bool Question2_1_16LackOfAdequatelightingForToilets
        { get; set; }

        [DisplayName("عدم وجود حمامات منفصلة للجنسين ")]
        public bool Question2_1_17LackOfGenderSegregatedToilets
        { get; set; }

        [DisplayName("نقص أماكن الاستحمام المخصصة لكلا الجنسين  ")]
        public bool Question2_1_17LackOfGenderSegregatedBathingFacilities
        { get; set; }

        [DisplayName("عدم وجود مرافق استحمام منفصلة للجنسين")]
        public bool Question2_1_18LackOfGenderSegregatedBathingFacilitites
        { get; set; }

        [DisplayName("عدم وجود حمامات يمكن الوصول إليها")]
        public bool Question2_1_19LackOfAccessibleBathrooms
        { get; set; }

        [DisplayName("توزيع المساعدة يستثنى الأشخاص ذوي الإعاقة وأسرهم  ")]
        public bool Question2_1_20DistributionOfAssistanceExcludePersonsWithDisabilitiesAndTheirFamilies
        { get; set; }

        [DisplayName("عدم وجود أجهزة مساعدة ")]
        public bool Question2_1_21LackOfAssistiveDevices
        { get; set; }

        [DisplayName("قلق على أفراد مفقودين   ")]
        public bool Question2_1_22ConcernOverFamilyMemberMissing
        { get; set; }

        [DisplayName("غير ذلك  ")]
        public bool Question2_1_23Other
        { get; set; }

        [DisplayName("اذكرها  ")]
        public string Question2_1_23Text
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

        [DisplayName("3.1 هل هناك أطفال منفصلين عن ذويهم من كلا من الوالدين أو مقدمي الرعاية المعتادة ولكن ليس بالضرورة من الأسرة الموسعة؟")]
        public string Question3_1
        { get; set; }

        [DisplayName("ذكور")]
        public int? Question3_1Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_1Femal
        { get; set; }

        [DisplayName(" 3.2 هل هنالك أي أطفال منفصلين عن كلا ذويهم أو مقدمي الرعاية الاعتياديين وهم إما لوحدهم أو دون مقدم رعاية ملائم؟ ")]
        public string Question3_2
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_2Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_2Femal
        { get; set; }

        [DisplayName(" 3.3 هل يوجد هناك أي طفل يعيل أسرته؟")]
        public string Question3_3
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_3Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_3Femal
        { get; set; }

        [DisplayName(" 3.4 هل يوجد هناك أطفال يعانون من إصابات جسدية ويحتاجون إلى المساعدة؟")]
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

        [DisplayName(" 3.8 هل هناك أطفال مصابين بالكرب الشديد؟")]
        public string Question3_8
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_8Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_8Femal
        { get; set; }


        [DisplayName(" 3.9 هل هناك بالغين مصابين بالكرب الشديد؟")]
        public string Question3_9
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_9Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_9Femal
        { get; set; }


        [DisplayName(" 3.10 هل هناك الأطفال المشتركين في أشكال الاستغلال لعمالة الأطفال أو التسول؟")]
        public string Question3_10
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_10Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_10Femal
        { get; set; }

        [DisplayName(" 3.11 هل هناك اي أطفال ذوي إعاقة بحاجة لمساعدة خاصة؟")]
        public string Question3_11
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_11Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_11Femal
        { get; set; }


        [DisplayName("3.12  هل هناك بالغين من ذوي الإعاقة الذين بحاجة إلى مساعدة خاصة؟")]
        public string Question3_12
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_12Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_12Femal
        { get; set; }


        [DisplayName("3.13  هل هناك حوادث عنف منزلي؟")]
        public string Question3_13
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_13Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_13Femal
        { get; set; }


        [DisplayName("3.14 هل هناك نساء غير مصحوبات (مطلقة/منفصلة)؟")]
        public string Question3_14
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_14Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_14Femal
        { get; set; }

        [DisplayName("3.15 هل هناك نساء أرامل نتيجة لحالة الطواريء؟ ")]
        public string Question3_15
        { get; set; }
    

        [DisplayName("اثناث")]
        public int? Question3_15Femal
        { get; set; }

        [DisplayName("3.16 هل هناك أشخاص يعانون من أمراض مزمنة/حالات صحة نفسية من دون علاج؟")]
        public string Question3_16
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_16Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_16Femal
        { get; set; }

        [DisplayName("3.17  هل هناك من كبار السن الذين يحتاجون إلى المساعدة؟")]
        public string Question3_17
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_17Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_17Femal
        { get; set; }

        [DisplayName("3.18  هل هناك أشخاص متأثرين يحتاجون إلى المساعدة القانونية؟")]
        public string Question3_18
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_18Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_18Femal
        { get; set; }


        [DisplayName("3.19 هل هناك نساء حوامل وأمهات مرضعات بحاجة لبرامج تغذية علاجية تكميلية؟")]
        public string Question3_19
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_19Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_19Femal
        { get; set; }


        [DisplayName("3.20  هل هناك أي حوادث عنف جنسي معروفة؟")]
        public string Question3_20
        { get; set; }

        [DisplayName(" 3.21 مخاوف حماية أخرى ")]
        public string Question3_21
        { get; set; }

        [DisplayName("3.20.1 يرجى وصف مخاوف الحماية التي تم تحديدها: ")]
        public string Question3_21Text
        { get; set; }
        [DisplayName("ذكور")]

        public int? Question3_21Male
        { get; set; }

        [DisplayName("اثناث")]
        public int? Question3_21Femal
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