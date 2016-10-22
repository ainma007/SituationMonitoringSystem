using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SituationMonitoring.Models
{
    public class SituationUserService
    {
        private SituationMonitoringEntities entities;

        public SituationUserService(SituationMonitoringEntities entities)
        {
            this.entities = entities;
        }

        public IEnumerable<SituationUserViewModel> Read()
        {
            //  يجب ان يكون المشروع فعال 
            return entities.SituationUser_Table
                        .Select(db => new SituationUserViewModel
                        {
                            ID = db.ID,
                            SituationID = db.SituationID,
                            UserID = db.UserID,



                            projects = new Models.SessionForeignKey.SituationForeingKey()
                            {
                                SituationID = db.Situation_Table.SituationID,
                               
                            },

                            Users = new Models.SessionForeignKey.UserForeingKey()
                            {
                                UserID = db.Users_Table.UserID,
                                UserFullName = db.Users_Table.FullName
                            },

                            Status = db.Status,
                        });
        }
        public IEnumerable<SituationViewModelForUsers> ReadSituationForUser()
        {
            return entities.SituationUser_Table
                     .Where(i => i.Status != false).Select(control => new SituationViewModelForUsers
                     {
                         UserSituationID = control.ID,
                         MYUserID=control.UserID,
                         SituationtID = control.SituationID,
                         GovernorateArName=control.Situation_Table.Governorate_Table.GovernorateArName,
                         AreaName=control.Situation_Table.Area_Table.AreaArName,
                         MunicipalityName=control.Situation_Table.Municipality_Table.MunicipalityArName,
                         SituationStartDate = control.Situation_Table.SituationDate.HasValue ? control.Situation_Table.SituationDate.Value : default(DateTime),
                         CollectiveCenter=control.Situation_Table.CollectiveCenter,
                         Site_Description=control.Situation_Table.Site_Description,
                         Status = control.Status,


                     });

        }

        public void Create(SituationUserViewModel db)
        {
            try
            {
                //  تم اضافة هذا الاستعلام لعدم تكرار المشروع للمستخدم
                var project = entities.SituationUser_Table
                             .Single(i => i.UserID == db.UserID
                                         && i.SituationID == db.SituationID);
                db.UserID = 0;
            }
            catch (Exception)
            {
                var entity = new SituationUser_Table();

                entity.SituationID = db.SituationID;
                entity.UserID = db.UserID;
                entity.Status = db.Status;

                entities.SituationUser_Table.Add(entity);
                entities.SaveChanges();

                db.UserID = entity.ID;
            }

        }

        public void Update(SituationUserViewModel db)
        {
            var entity = new SituationUser_Table();

            entity.ID = db.ID;
            entity.SituationID = db.SituationID;
            entity.UserID = db.UserID;
            entity.Status = db.Status;

            entities.SituationUser_Table.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Destroy(SituationUserViewModel db)
        {
            var entity = new SituationUser_Table();

            entity.ID = db.ID;

            entities.SituationUser_Table.Attach(entity);

            entities.SituationUser_Table.Remove(entity);

            entities.SaveChanges();
        }




        public IEnumerable<SessionForeignKey.UserForeingKey> GetUseres()
        {
            //  هنا كمان   تم التعديل على حالة المستخدم 
            return entities.Users_Table
                .Where(i => i.Status != false && i.UserType!="مدير").Select(user => new SessionForeignKey.UserForeingKey
                {
                    UserID = user.UserID,
                    UserFullName = user.FullName,



                });
        }

        public IEnumerable<SessionForeignKey.SituationForeingKey> ReadSituation()
        {
            return entities.Situation_Table.Select(control => new SessionForeignKey.SituationForeingKey
            {
                SituationID = control.SituationID,
               
                
            });
        }
        public void Dispose()
        {
            entities.Dispose();
        }
    }
}