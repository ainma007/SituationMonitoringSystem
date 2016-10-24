using Kendo.Mvc.UI;
using SituationMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using SituationMonitoring.Models.SessionForeignKey;

namespace SituationMonitoring.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PopulateGovernorate();
            PopulateMunicipality();
            PopulateArea();
            PopulateUsers();
            return View();
        }


        private void PopulateGovernorate()
        {
            var dataContext = new SituationMonitoringEntities();
            var Governorate = dataContext.Governorate_Table
                        .Select(c => new GovernorateViewModel
                        {
                            GovernorateID = c.GovernorateID,
                            GovernorateArName = c.GovernorateArName
                        })
                        .OrderBy(e => e.GovernorateID);

            ViewData["Governorate"] = Governorate;
            ViewData["defaultGovernorate"] = Governorate.First();
        }

        private void PopulateMunicipality()
        {
            var dataContext = new SituationMonitoringEntities();
            var Municipality = dataContext.Municipality_Table
                        .Select(c => new Models.SessionForeignKey.MunicipalityForeingKey
                        {
                            MunicipalityID = c.MunicipalityID,
                            MunicipalityName = c.MunicipalityArName
                        })
                        .OrderBy(e => e.MunicipalityID);

            ViewData["Municipality"] = Municipality;
            ViewData["defaultMunicipality"] = Municipality.First();
        }

        private void PopulateArea()
        {
            var dataContext = new SituationMonitoringEntities();
            var Area = dataContext.Area_Table
                        .Select(c => new Models.SessionForeignKey.AreaForeingKey
                        {
                            AreaID = c.AreaID,
                            AreaName = c.AreaArName
                        })
                        .OrderBy(e => e.AreaID);

            ViewData["Area"] = Area;
            ViewData["defaultArea"] = Area.First();
        }

        public void PopulateUsers()
        {
            var dataContext = new SituationMonitoringEntities();
            var users = dataContext.Users_Table

                              .Select(c => new UserForeingKey
                              {
                                  UserID = c.UserID,
                                  UserFullName = c.FullName
                              })
                              .OrderBy(e => e.UserID);

            ViewData["users"] = users;
            ViewData["defaultUser"] = users.First();
        }

        private SituationService SituationService;


        public HomeController()
        {

            SituationService = new SituationService(new SituationMonitoringEntities());


        }

        public ActionResult SituationMainAdmin_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(SituationService.Read().ToDataSourceResult(request));
        }
        public ActionResult SituationMainUser_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(SituationService.Read().Where(u =>  u.UserID == int.Parse(Session["UserID"].ToString())).ToDataSourceResult(request));
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
