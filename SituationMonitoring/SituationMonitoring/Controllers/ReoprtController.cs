using SituationMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SituationMonitoring.Controllers
{
    public class ReoprtController : Controller
    {
        // GET: Reoprt
        public ActionResult SituationMonitoringReport()
        {

            GovernorateArName();
            MunicipalityArName();
            AreaArName();
            CollectiveCenter();
            Site_Description();
            //
            SumQuestionnaire();
            GetSum_Male();
            GetSum_Femal();
            GetSum_Estimated_Number_Of_Individuals();
            GetSum_Estimated_Number_Of_Families();
            //
            GetPer_Question1_1Yes();
            GetPer_Question1_1No();
            GetPer_Question1_1Dontknow();
            //
            GetPer_Question1_1_1Less10();
            GetPer_Question1_1_1_10_50();
            GetPer_Question1_1_1_10_100();
            GetPer_Question1_1_1Over100();

            //
            GetPer_Question1_2_1_Family_CommunityDisputes();
            GetPer_Question1_2_2();
            GetPer_Question1_2_3();
            GetPer_Question1_2_4();
            GetPer_Question1_2_5();
            GetPer_Question1_2_6();
            GetPer_Question1_2_7();
            GetPer_Question1_2_8();
            GetPer_Question1_2_9();
            GetPer_Question1_2_10();
            GetPer_Question1_2_11();
            //
            GetPer_Question1_3_1();
            GetPer_Question1_3_2();
            GetPer_Question1_3_3();
            GetPer_Question1_3_4();
            GetPer_Question1_3_5();
            GetPer_Question1_3_6();
            GetPer_Question1_3_7();
            GetPer_Question1_3_8();
            GetPer_Question1_3_9();
            GetPer_Question1_3_10();
            GetPer_Question1_3_11();

            //

            GetPer_Question1_4Yes();
            GetPer_Question1_4No();
            GetPer_Question1_4Dontknow();
            //

            GetPer_Question2_1_1();
            GetPer_Question2_1_2();
            GetPer_Question2_1_3();
            GetPer_Question2_1_4();
            GetPer_Question2_1_5();
            GetPer_Question2_1_6();
            GetPer_Question2_1_7();
            GetPer_Question2_1_8();
            GetPer_Question2_1_9();
            GetPer_Question2_1_10();
            GetPer_Question2_1_11();
            GetPer_Question2_1_12();
            GetPer_Question2_1_13();
            GetPer_Question2_1_14();
            GetPer_Question2_1_15();
            GetPer_Question2_1_16();
            GetPer_Question2_1_17();
            GetPer_Question2_1_18();
            GetPer_Question2_1_19();
            GetPer_Question2_1_20();
            GetPer_Question2_1_21();
            GetPer_Question2_1_22();
            GetPer_Question2_1_23();

            //

            GetPer_Question2_2Yes();
            GetPer_Question2_2No();
            GetPer_Question2_2Dontknow();
            //
            GetPer_Question2_3Yes();
            GetPer_Question2_3No();
            GetPer_Question2_3Dontknow();

            //

            GetPer_Question3_1Yes();
            GetPer_Question3_1No();
            GetPer_Question3_1Dontknow();
            GetSUmMale_Question3_1();
            GetSUmFemal_Question3_1();

            GetPer_Question3_2Yes();
            GetPer_Question3_2No();
            GetPer_Question3_2Dontknow();
            GetSUmMale_Question3_2();
            GetSUmFemal_Question3_2();


            GetPer_Question3_3Yes();
            GetPer_Question3_3No();
            GetPer_Question3_3Dontknow();
            GetSUmMale_Question3_3();
            GetSUmFemal_Question3_3();


            GetPer_Question3_4Yes();
            GetPer_Question3_4No();
            GetPer_Question3_4Dontknow();
            GetSUmMale_Question3_4();
            GetSUmFemal_Question3_4();


            GetPer_Question3_5Yes();
            GetPer_Question3_5No();
            GetPer_Question3_5Dontknow();
            GetSUmMale_Question3_5();
            GetSUmFemal_Question3_5();


            GetPer_Question3_6Yes();
            GetPer_Question3_6No();
            GetPer_Question3_6Dontknow();
            GetSUmMale_Question3_6();
            GetSUmFemal_Question3_6();


            GetPer_Question3_7Yes();
            GetPer_Question3_7No();
            GetPer_Question3_7Dontknow();
            GetSUmMale_Question3_7();


            GetPer_Question3_8Yes();
            GetPer_Question3_8No();
            GetPer_Question3_8Dontknow();
            GetSUmMale_Question3_8();


            GetPer_Question3_9Yes();
            GetPer_Question3_9No();
            GetPer_Question3_9Dontknow();
            GetSUmMale_Question3_9();


            GetPer_Question3_10Yes();
            GetPer_Question3_10No();
            GetPer_Question3_10Dontknow();
            GetSUmMale_Question3_10();


            GetPer_Question3_11Yes();
            GetPer_Question3_11No();
            GetPer_Question3_11Dontknow();
            GetSUmMale_Question3_11();
            GetSUmFemal_Question3_11();


            GetPer_Question3_12Yes();
            GetPer_Question3_12No();
            GetPer_Question3_12Dontknow();
            GetSUmMale_Question3_12();
            GetSUmFemal_Question3_12();


            GetPer_Question3_12Yes();
            GetPer_Question3_12No();
            GetPer_Question3_12Dontknow();
            GetSUmMale_Question3_12();
            GetSUmFemal_Question3_12();

            GetPer_Question3_13Yes();
            GetPer_Question3_13No();
            GetPer_Question3_13Dontknow();
            GetSUmMale_Question3_13();
            GetSUmFemal_Question3_13();

            GetPer_Question3_14Yes();
            GetPer_Question3_14No();
            GetPer_Question3_14Dontknow();
            GetSUmFemal_Question3_14();

            GetPer_Question3_15Yes();
            GetPer_Question3_15No();
            GetPer_Question3_15Dontknow();
            GetSUmFemal_Question3_15();

            GetPer_Question3_16Yes();
            GetPer_Question3_16No();
            GetPer_Question3_16Dontknow();
            GetSUmMale_Question3_16();
            GetSUmFemal_Question3_16();

            GetPer_Question3_17Yes();
            GetPer_Question3_17No();
            GetPer_Question3_17Dontknow();
            GetSUmMale_Question3_17();
            GetSUmFemal_Question3_17();

            GetPer_Question3_18Yes();
            GetPer_Question3_18No();
            GetPer_Question3_18Dontknow();
            GetSUmMale_Question3_18();
            GetSUmFemal_Question3_18();

            GetPer_Question3_19Yes();
            GetPer_Question3_19No();
            GetPer_Question3_19Dontknow();
            GetSUmMale_Question3_19();
            GetSUmFemal_Question3_19();

            GetPer_Question3_20Yes();
            GetPer_Question3_20No();
            GetPer_Question3_20Dontknow();
           

            GetPer_Question3_21Yes();
            GetPer_Question3_21No();
            GetPer_Question3_21Dontknow();
            GetSUmMale_Question3_21();
            GetSUmFemal_Question3_21();

            //

            GetPer_Question4_1_1();
            GetPer_Question4_1_2();
            GetPer_Question4_1_3();
            GetPer_Question4_1_4();
            GetPer_Question4_1_5();
            GetPer_Question4_1_6();
            GetPer_Question4_1_7();
            GetPer_Question4_1_8();
            GetPer_Question4_1_9();
            GetPer_Question4_1_10();




            return View();




        }


        #region(get SituationData)

        public string GovernorateArName()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Situation_Table xx = entities.Situation_Table.Where(c => c.SituationID == H)
                               .Select(i => i).Single();


                ViewBag.GovernorateArName = xx.Governorate_Table.GovernorateArName.ToString();


            }

            return ViewBag.GovernorateArName;
        }


        public string MunicipalityArName()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Situation_Table xx = entities.Situation_Table.Where(c => c.SituationID == H)
                               .Select(i => i).Single();


                ViewBag.MunicipalityArName = xx.Municipality_Table.MunicipalityArName.ToString();


            }

            return ViewBag.MunicipalityArName;
        }

        public string AreaArName()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Situation_Table xx = entities.Situation_Table.Where(c => c.SituationID == H)
                               .Select(i => i).Single();


                ViewBag.AreaArName = xx.Area_Table.AreaArName.ToString();


            }

            return ViewBag.AreaArName;
        }

        public string CollectiveCenter()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Situation_Table xx = entities.Situation_Table.Where(c => c.SituationID == H)
                               .Select(i => i).Single();


                ViewBag.CollectiveCenter = xx.CollectiveCenter.ToString();


            }

            return ViewBag.CollectiveCenter;
        }

        public string Site_Description()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Situation_Table xx = entities.Situation_Table.Where(c => c.SituationID == H)
                               .Select(i => i).Single();


                ViewBag.Site_Description = xx.Site_Description.ToString();


            }

            return ViewBag.Site_Description;
        }


        #endregion

        private int SumQuestionnaire()
        {
                         
                int H = 0;
                H = int.Parse(Session["situationId"].ToString());
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                   ViewBag.SumQuestionnaire = (from m in entities.Questionnaire_Table where m.SituationID == H select new { m.SituationID }).Count();
                   

                }
            return ViewBag.SumQuestionnaire;

            }



        private int GetSum_Male()
        {

            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                ViewBag.GetSum_Male = entities.Questionnaire_Table.Where(c => c.SituationID == H && c.PersonGEnder == "ذكر")
                                .Select(i => i.QuestionnaireID).Count();

            }
            return ViewBag.GetSum_Male;

        }

        private int GetSum_Femal()
        {

            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                ViewBag.GetSum_Femal = entities.Questionnaire_Table.Where(c => c.SituationID == H && c.PersonGEnder == "أنثى")
                                .Select(i => i.QuestionnaireID).Count();

            }
            return ViewBag.GetSum_Femal;

        }

        public double GetSum_Estimated_Number_Of_Individuals()
        {


            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {

                int H = 0;
                H = int.Parse(Session["situationId"].ToString());
                try
                {
                    ViewBag.GetSum_Estimated_Number_Of_Individuals = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                                 .Select(i => i.Estimated_Number_Of_Individuals.Value).Average();



                    return Math.Round(ViewBag.GetSum_Estimated_Number_Of_Individuals, 2);
                }
                catch
                {
                    return 0;
                }

            }



        }


        public double GetSum_Estimated_Number_Of_Families()
        {

            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                try
                {
                   
                    ViewBag.GetSum_Estimated_Number_Of_Families = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                                 .Select(i => i.Estimated_Number_Of_Families.Value).Average();

                    return Math.Round(ViewBag.GetSum_Estimated_Number_Of_Families, 2);
                }
                catch
                {
                    return 0;
                }
            }
        }


        #region (Question1.1)
        public double GetPer_Question1_1Yes()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_1 == "نعم")
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_1Yes = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_1Yes;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public double GetPer_Question1_1No()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_1 == "لا")
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_1No = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_1No;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public double GetPer_Question1_1Dontknow()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_1 == "غير متأكد")
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_1Dontknow = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_1Dontknow;
            }
            catch (Exception)
            {

                return 0;
            }

        }



        public double GetPer_Question1_1_1Less10()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;

            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_1_1 == "أقل من 10")
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_1_1Less10 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_1_1Less10;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public double GetPer_Question1_1_1_10_50()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
          
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_1_1 == "10-50")
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_1_1_10_50 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_1_1_10_50;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public double GetPer_Question1_1_1_10_100()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_1_1 == "100-50")
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_1_1_10_100 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_1_1_10_100;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public double GetPer_Question1_1_1Over100()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
           
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_1_1 == "أكثر من 100")
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_1_1Over100 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_1_1Over100;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        #endregion



        #region  (Question1.2)
        public double GetPer_Question1_2_1_Family_CommunityDisputes()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_2_1_Family_CommunityDisputes == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_2_1_Family_CommunityDisputes = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_2_1_Family_CommunityDisputes;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public double GetPer_Question1_2_2()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question_1_2_2NotEnoughFood == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_2_2 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_2_2;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public double GetPer_Question1_2_3()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
           
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_2_3NotEnoughPrivacy == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_2_3 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_2_3;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public double GetPer_Question1_2_4()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
          
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_2_4NotEnoughDrinking == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_2_4 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_2_4;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public double GetPer_Question1_2_5()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
           
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_2_5UnsafeHousing == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_2_5 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_2_5;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public double GetPer_Question1_2_6()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
           
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_2_6Overcrowding == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_2_6 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_2_6;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public double GetPer_Question1_2_7()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
           
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_2_7InsufficientBedding == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_2_7 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_2_7;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public double GetPer_Question1_2_8()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
           
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_2_8NotEnoughWater == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_2_8 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_2_8;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public double GetPer_Question1_2_9()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_2_9Not_enough_humanitarian_assistance == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_2_9 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_2_9;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public double GetPer_Question1_2_10()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
           
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_2_10No_Access_to_essential_services == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_2_10 = Math.Round(ComputeIt(truecount, count), 2);
                    return ViewBag.GetPer_Question1_2_10;
                };

            }
            catch (Exception)
            {

                return 0;
            }
           
        }
        public double GetPer_Question1_2_11()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
           
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_2_11Other == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_2_11 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_2_11;
            }
            catch (Exception)
            {

                return 0;
            }
        }


        #endregion
        #region  (Question1.3)
        public double GetPer_Question1_3_1()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_3_1Family_CommunityDisputes == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_3_1 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_3_1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public double GetPer_Question1_3_2()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_3_2NotEnoughFood == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_3_2 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_3_2;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public double GetPer_Question1_3_3()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_3_3NotEnoughPrivacy == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_3_3 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_3_3;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public double GetPer_Question1_3_4()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_3_4NotenoughDrinkingWater == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_3_4 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_3_4;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public double GetPer_Question1_3_5()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_3_5UnsafeHousing == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_3_5 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_3_5;
            }
            catch (Exception)
            {

                return 0;
            }
        }
        public double GetPer_Question1_3_6()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                try
                {
                    {
                        Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                        count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                                   .Select(i => i.QuestionnaireID).Count();


                        truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                       && c.Question1_3_6Overcrowding == true)
                                 .Select(i => i.QuestionnaireID).Count();

                        ViewBag.GetPer_Question1_3_6 = Math.Round(ComputeIt(truecount, count), 2);
                    };

                    return ViewBag.GetPer_Question1_3_6;
                }
                catch (Exception)
                {

                    return 0;
                }
        }
        public double GetPer_Question1_3_7()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            try
            {
                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {
                    Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                    count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                               .Select(i => i.QuestionnaireID).Count();


                    truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                                   && c.Question1_3_7InsufficientBedding == true)
                             .Select(i => i.QuestionnaireID).Count();

                    ViewBag.GetPer_Question1_3_7 = Math.Round(ComputeIt(truecount, count), 2);
                };

                return ViewBag.GetPer_Question1_3_7;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public double GetPer_Question1_3_8()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question1_3_8NotEnoughWater_otherThanDrinking == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question1_3_8 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question1_3_8;
        }
        public double GetPer_Question1_3_9()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question1_3_9Not_enough_humanitarian_assistance == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question1_3_9 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question1_3_9;
        }

        public double GetPer_Question1_3_10()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question1_3_10No_Access_to_essential_services == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question1_3_10 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question1_3_10;
        }
        public double GetPer_Question1_3_11()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question1_3_11Other == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question1_3_11 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question1_3_11;
        }


        #endregion


        #region (Question1.4)
        public double GetPer_Question1_4Yes()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question1_4 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question1_4Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question1_4Yes;
        }

        public double GetPer_Question1_4No()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question1_4 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question1_4No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question1_4No;
        }

        public double GetPer_Question1_4Dontknow()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question1_4 == "غير متأكد")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question1_4Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question1_4Dontknow;
        }



        #endregion


        #region  (Question 2.1)
        public double GetPer_Question2_1_1()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_1Family_CommunityDisputes == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_1 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_1;
        }

        public double GetPer_Question2_1_2()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_2NotEnoughFood == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_2 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_2;
        }
        public double GetPer_Question2_1_3()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_3enough_privacy_in_DES_rooms == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_3 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_3;
        }
        public double GetPer_Question2_1_4()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_4NotEnoughPrivacy == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_4 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_4;
        }
        public double GetPer_Question2_1_5()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_5NotDrinkingEnoughWater == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_5 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_5;
        }
        public double GetPer_Question2_1_6()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_6Unsafe_housing == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_6 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_6;
        }
        public double GetPer_Question2_1_7()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_7IOvercrowding == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_7 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_7;
        }

        public double GetPer_Question2_1_8()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
           
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_8Insufficient_bedding == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_8 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_8;
        }
        public double GetPer_Question2_1_9()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_9NotEnoughWater_OtherThanDrinking == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_9 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_9;
        }

        public double GetPer_Question2_1_10()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_10NotEnoughHumanitarianAssistanceForPeopleInNeed == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_10 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_10;
        }
        public double GetPer_Question2_1_11()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_11NoAccessToEssentialServices == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_11 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_11;
        }
        public double GetPer_Question2_1_12()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_12DistributionOfAssistanceExcludesChild_HeadedFamilies == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_12 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_12;
        }
        public double GetPer_Question2_1_13()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_13DistributionOfAssistanceExcludesWomen_HeadedFamilies == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_13 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_13;
        }
        public double GetPer_Question2_1_14()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_14LackOfSafeSpacesForWomenAndGirlsToGather == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_14 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_14;
        }
        public double GetPer_Question2_1_15()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_15LackOfSafeSpacesForChildrenToPlay == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_15 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_15;
        }
        public double GetPer_Question2_1_16()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_16LackOfAdequatelightingForToilets == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_16 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_16;
        }
        public double GetPer_Question2_1_17()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_17LackOfGenderSegregatedToilets == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_17 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_17;
        }
        public double GetPer_Question2_1_18()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
           
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_18LackOfGenderSegregatedBathingFacilitites == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_18 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_18;
        }
        public double GetPer_Question2_1_19()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
           
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_19LackOfAccessibleBathrooms == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_19 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_19;
        }
        public double GetPer_Question2_1_20()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());

            int count = 0;
            int truecount = 0;
            
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_20DistributionOfAssistanceExcludePersonsWithDisabilitiesAndTheirFamilies == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_20 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_20;
        }
        public double GetPer_Question2_1_21()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_21LackOfAssistiveDevices == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_21 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_21;
        }
        public double GetPer_Question2_1_22()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_22ConcernOverFamilyMemberMissing == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_22 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_22;
        }
        public double GetPer_Question2_1_23()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            int count = 0;
            int truecount = 0;
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_1_23Other == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_1_23 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_1_23;
        }


        #endregion


        #region (Question2.2)
        public double GetPer_Question2_2Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_2 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_2Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_2Yes;
        }

        public double GetPer_Question2_2No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_2 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_2No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_2No;
        }

        public double GetPer_Question2_2Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_2 == "غير متأكد")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_2Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_2Dontknow;
        }



        #endregion


        #region (Question2.3)
        public double GetPer_Question2_3Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_3 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_3Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_3Yes;
        }

        public double GetPer_Question2_3No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_3 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_3No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_3No;
        }

        public double GetPer_Question2_3Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question2_3 == "غير متأكد")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question2_3Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question2_3Dontknow;
        }



        #endregion

        #region (Question 3.1)
        public double GetPer_Question3_1Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_1 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_1Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_1Yes;
        }

        public double GetPer_Question3_1No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_1 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_1No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_1No;
        }

        public double GetPer_Question3_1Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_1 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_1Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_1Dontknow;
        }

        public int GetSUmMale_Question3_1()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_1 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_1Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_1;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_1()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {
                

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_1 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_1Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_1;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.2)
        public double GetPer_Question3_2Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_2 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_2Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_2Yes;
        }

        public double GetPer_Question3_2No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_2 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_2No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_2No;
        }

        public double GetPer_Question3_2Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_2 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_2Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_2Dontknow;
        }

        public int GetSUmMale_Question3_2()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_2 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_2Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_2;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_2()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_2 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_2Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_2;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.3)
        public double GetPer_Question3_3Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_3 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_3Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_3Yes;
        }

        public double GetPer_Question3_3No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_3 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_3No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_3No;
        }

        public double GetPer_Question3_3Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_3 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_3Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_3Dontknow;
        }

        public int GetSUmMale_Question3_3()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_3 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_3Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_3;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_3()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_3 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_3Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_3;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.4)
        public double GetPer_Question3_4Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_4 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_4Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_4Yes;
        }

        public double GetPer_Question3_4No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_4 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_4No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_4No;
        }

        public double GetPer_Question3_4Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_4 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_4Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_4Dontknow;
        }

        public int GetSUmMale_Question3_4()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_4 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_4Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_4;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_4()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_4 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_4Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_4;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.5)
        public double GetPer_Question3_5Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_5 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_5Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_5Yes;
        }

        public double GetPer_Question3_5No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_5 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_5No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_5No;
        }

        public double GetPer_Question3_5Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_5 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_5Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_5Dontknow;
        }

        public int GetSUmMale_Question3_5()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_5 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_5Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_5;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_5()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_5 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_5Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_5;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.6)
        public double GetPer_Question3_6Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_6 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_6Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_6Yes;
        }

        public double GetPer_Question3_6No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_6 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_6No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_6No;
        }

        public double GetPer_Question3_6Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_6 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_6Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_6Dontknow;
        }

        public int GetSUmMale_Question3_6()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_6 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_6Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_6;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_6()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_6 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_6Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_6;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.7)
        public double GetPer_Question3_7Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_7 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_7Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_7Yes;
        }

        public double GetPer_Question3_7No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_7 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_7No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_7No;
        }

        public double GetPer_Question3_7Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_7 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_7Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_7Dontknow;
        }

        public int GetSUmMale_Question3_7()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_7 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_7Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_7;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_7()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_7 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_7Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_7;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.8)
        public double GetPer_Question3_8Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_8 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_8Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_8Yes;
        }

        public double GetPer_Question3_8No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_8 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_8No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_8No;
        }

        public double GetPer_Question3_8Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_8 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_8Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_8Dontknow;
        }

        public int GetSUmMale_Question3_8()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_8 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_8Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_8;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_8()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_8 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_8Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_8;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.9)
        public double GetPer_Question3_9Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_9 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_9Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_9Yes;
        }

        public double GetPer_Question3_9No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_9 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_9No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_9No;
        }

        public double GetPer_Question3_9Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_9 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_9Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_9Dontknow;
        }

        public int GetSUmMale_Question3_9()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_9 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_9Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_9;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_9()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_9 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_9Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_9;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.10)
        public double GetPer_Question3_10Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_10 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_10Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_10Yes;
        }

        public double GetPer_Question3_10No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_10 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_10No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_10No;
        }

        public double GetPer_Question3_10Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_10 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_10Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_10Dontknow;
        }

        public int GetSUmMale_Question3_10()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_10 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_10Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_10;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_10()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_10 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_10Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_10;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.11)
        public double GetPer_Question3_11Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_11 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_11Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_11Yes;
        }

        public double GetPer_Question3_11No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_11 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_11No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_11No;
        }

        public double GetPer_Question3_11Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_11 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_11Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_11Dontknow;
        }

        public int GetSUmMale_Question3_11()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_11 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_11Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_11;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_11()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_11 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_11Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_11;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.12)
        public double GetPer_Question3_12Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_12 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_12Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_12Yes;
        }

        public double GetPer_Question3_12No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_12 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_12No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_12No;
        }

        public double GetPer_Question3_12Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_12 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_12Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_12Dontknow;
        }

        public int GetSUmMale_Question3_12()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_12 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_12Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_12;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_12()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_12 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_12Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_12;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.13)
        public double GetPer_Question3_13Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_13 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_13Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_13Yes;
        }

        public double GetPer_Question3_13No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_13 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_13No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_13No;
        }

        public double GetPer_Question3_13Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_13 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_13Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_13Dontknow;
        }

        public int GetSUmMale_Question3_13()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_13 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_13Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_13;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_13()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_13 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_13Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_13;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.14)
        public double GetPer_Question3_14Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_14 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_14Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_14Yes;
        }

        public double GetPer_Question3_14No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_14 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_14No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_14No;
        }

        public double GetPer_Question3_14Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_14 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_14Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_14Dontknow;
        }

    

        public int GetSUmFemal_Question3_14()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_14 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_14Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_14;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.15)
        public double GetPer_Question3_15Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_15 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_15Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_15Yes;
        }

        public double GetPer_Question3_15No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_15 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_15No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_15No;
        }

        public double GetPer_Question3_15Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_15 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_15Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_15Dontknow;
        }

       

        public int GetSUmFemal_Question3_15()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_15 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_15Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_15;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.16)
        public double GetPer_Question3_16Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_16 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_16Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_16Yes;
        }

        public double GetPer_Question3_16No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_16 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_16No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_16No;
        }

        public double GetPer_Question3_16Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_16 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_16Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_16Dontknow;
        }

        public int GetSUmMale_Question3_16()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_16 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_16Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_16;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_16()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_16 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_16Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_16;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.17)
        public double GetPer_Question3_17Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_17 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_17Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_17Yes;
        }

        public double GetPer_Question3_17No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_17 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_17No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_17No;
        }

        public double GetPer_Question3_17Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_17 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_17Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_17Dontknow;
        }

        public int GetSUmMale_Question3_17()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_17 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_17Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_17;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_17()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_17 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_17Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_17;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.18)
        public double GetPer_Question3_18Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_18 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_18Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_18Yes;
        }

        public double GetPer_Question3_18No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_18 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_18No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_18No;
        }

        public double GetPer_Question3_18Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_18 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_18Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_18Dontknow;
        }

        public int GetSUmMale_Question3_18()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_18 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_18Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_18;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_18()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_18 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_18Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_18;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion


        #region (Question 3.19)
        public double GetPer_Question3_19Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_19 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_19Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_19Yes;
        }

        public double GetPer_Question3_19No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_19 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_19No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_19No;
        }

        public double GetPer_Question3_19Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_19 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_19Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_19Dontknow;
        }

        public int GetSUmMale_Question3_19()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_19 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_19Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_19;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_19()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_19 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_19Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_19;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion

        #region (Question 3.20)
        public double GetPer_Question3_20Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_20 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_20Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_20Yes;
        }

        public double GetPer_Question3_20No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_20 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_20No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_20No;
        }

        public double GetPer_Question3_20Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_20 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_20Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_20Dontknow;
        }






        #endregion


        #region (Question 3.21)
        public double GetPer_Question3_21Yes()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_21 == "نعم")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_21Yes = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_21Yes;
        }

        public double GetPer_Question3_21No()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_21 == "لا")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_21No = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_21No;
        }

        public double GetPer_Question3_21Dontknow()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question3_21 == "غير معروف")
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question3_21Dontknow = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question3_21Dontknow;
        }

        public int GetSUmMale_Question3_21()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {

                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmMale_Question3_21 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_21Male.Value).Sum();



                };

                return ViewBag.GetSUmMale_Question3_21;
            }
            catch (Exception)
            {

                return 0;
            }

        }

        public int GetSUmFemal_Question3_21()
        {
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            try
            {


                using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
                {

                    ViewBag.GetSUmFemal_Question3_21 = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                   .Select(i => i.Question3_21Femal.Value).Sum();



                };

                return ViewBag.GetSUmFemal_Question3_21;
            }
            catch (Exception)
            {


                return 0;
            }
        }


        #endregion



        #region  (Question4.1)
        public double GetPer_Question4_1_1()
        {
           
            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question4_1_1 == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question4_1_1 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question4_1_1;
        }

        public double GetPer_Question4_1_2()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question4_1_2 == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question4_1_2 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question4_1_2;
        }
        public double GetPer_Question4_1_3()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question4_1_3 == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question4_1_3 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question4_1_3;
        }
        public double GetPer_Question4_1_4()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question4_1_4 == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question4_1_4 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question4_1_4;
        }
        public double GetPer_Question4_1_5()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question4_1_5 == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question4_1_5 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question4_1_5;
        }
        public double GetPer_Question4_1_6()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question4_1_6 == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question4_1_6 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question4_1_6;
        }
        public double GetPer_Question4_1_7()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question4_1_7 == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question4_1_7 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question4_1_7;
        }

        public double GetPer_Question4_1_8()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question4_1_8 == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question4_1_8 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question4_1_8;
        }
        public double GetPer_Question4_1_9()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question4_1_9 == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question4_1_9 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question4_1_9;
        }

        public double GetPer_Question4_1_10()
        {

            int count = 0;
            int truecount = 0;
            int H = 0;
            H = int.Parse(Session["situationId"].ToString());
            using (SituationMonitoringEntities entities = new SituationMonitoringEntities())
            {
                Func<int, int, double> ComputeIt = (x, y) => ((double)x / y) * 100;

                count = entities.Questionnaire_Table.Where(c => c.SituationID == H)
                           .Select(i => i.QuestionnaireID).Count();


                truecount = entities.Questionnaire_Table.Where(c => c.SituationID == H
                                               && c.Question4_1_10 == true)
                         .Select(i => i.QuestionnaireID).Count();

                ViewBag.GetPer_Question4_1_10 = Math.Round(ComputeIt(truecount, count), 2);
            };

            return ViewBag.GetPer_Question4_1_10;
        }


        #endregion

    }


}

