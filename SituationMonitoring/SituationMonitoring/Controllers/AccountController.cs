using SituationMonitoring.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI;
namespace SituationMonitoring.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            ViewBag.PM = "© 1998-2016 PCDCR- Mohammed El-Habbash , All Rights Reserved";
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Users_Table user)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    using (SituationMonitoringEntities dc = new SituationMonitoringEntities())
                    {
                        // Check If Existed Or Not : 
                        var u = dc.Users_Table.Single(i => i.UserName == user.UserName
                                                                    && i.Password == user.Password && i.Status==true);
                        if (u != null)
                        {
                           
                                Session["UserID"] = u.UserID;
                                Session["UserName"] = u.UserName;
                                Session["Password"] = u.Password;
                                Session["UserType"] = u.UserType;



                                return RedirectToAction("Index", "Home");

                          

                            //  User Informations : 
                           


                        }
                    }

                }
                catch (Exception)
                {
                    //اذا كان المستخدم اساسا مش موجود في جدول المستخدمين او كلمة المرور خطأ
                    ModelState.AddModelError("", "خطأ في الدخول للنظام");
                }
            }
            return View(user);
        }




        public ActionResult LoggedIn()
        {
            ViewBag.Message = "Welcome ";
            return View();

        }



        #region "      Check User Status     "
        // Abu Ehab 
        //private bool IsOnLine(int id)
        //{
        //    bool status = false;
        //    try
        //    {
        //        SituationMonitoringEntities context = new SituationMonitoringEntities();
        //        var user = context.LogHistory.Single(i => i.UserId == id && i.Status == "OnLine");
        //        // If User Is  Already OnLine  Before :
        //        if (user != null)
        //        {
        //            status = true;
        //        }
        //        return status;
        //    }
        //    catch (Exception)
        //    {
        //        return status;
        //    }

        //}




        // GET: /Account/LogOff 
        public ActionResult LogOff()
        {

            // Set User OfLine  :
            //  SetUserOffLine();

            // to destroy the FormsAuthentication cookie 
            // حذف الكويكزز
            Session["ID"] = null;
            Session.Clear();
            FormsAuthentication.SignOut();

            //----------------------------
            return RedirectToAction("Login", "Account");
        }


        public string GetLocalIPAddress()
        {
            string x;
            x = Dns.GetHostEntry(Dns.GetHostName()).AddressList.First(f =>
                f.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToString();
            return x.ToString();
        }


        public void SetUserOffLine()
        {
            //string ipaddressvalue = GetLocalIPAddress();

            //PCDCREntities entities = new PCDCREntities();
            //var entity = entities.LogHistory.Single(i => i.IPAddress == ipaddressvalue 
            //                     && i.Status == "OnLine");

            //entity.LogOutTime = DateTime.Now;
            //entity.Status = "OffLine";


            //entities.LogHistory .Attach(entity);
            //entities.Entry(entity).State = EntityState.Modified;
            //entities.SaveChanges();
        }
        #endregion
    }
}