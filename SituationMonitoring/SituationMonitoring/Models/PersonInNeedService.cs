using SituationMonitoring.Models.SessionForeignKey;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SituationMonitoring.Models
{
    public class PersonInNeedService
    {

        private SituationMonitoringEntities entities;

        public PersonInNeedService(SituationMonitoringEntities entities)
        {
            this.entities = entities;
        }

        public IEnumerable<PersonInNeedViewModel> Read()
        {
            return entities.PersonInNeed_table.Select(db => new PersonInNeedViewModel
            {
                ID = db.ID,
                Name_of_Person_In_Need = db.Name_of_Person_In_Need,
                UserID = db.UserID,
                UserName=db.Users_Table.FullName,
                SituationID =db.SituationID,

                Contact_Details = db.Contact_Details,
                KeyConcernID = db.KeyConcernID,

                Key_concern = new Key_concernForeingKey()
                {
                    ID = db.Key_concernTable.ID,
                    Key_concern = db.Key_concernTable.Key_concern
                },
                Age=db.Age,
                Gender=db.Gender,
                ActionsTakenSoFar=db.ActionsTakenSoFar,
                FollowUpRequired=db.FollowUpRequired,


            });
        }


        public void Create(PersonInNeedViewModel db)
        {
            var entity = new PersonInNeed_table();

            entity.Name_of_Person_In_Need = db.Name_of_Person_In_Need;
            entity.Contact_Details = db.Contact_Details;
            entity.KeyConcernID = db.KeyConcernID;
            entity.Age = db.Age;
            entity.Gender = db.Gender;
            entity.ActionsTakenSoFar = db.ActionsTakenSoFar;
            entity.FollowUpRequired = db.FollowUpRequired;
            entity.SituationID =int.Parse( HttpContext.Current.Session["situationId"].ToString());
            entity.UserID= int.Parse(HttpContext.Current.Session["UserID"].ToString());


            entities.PersonInNeed_table.Add(entity);
            entities.SaveChanges();

            db.ID = entity.ID;
        }

        public void Update(PersonInNeedViewModel db)
        {
            var entity = new PersonInNeed_table();

            entity.ID = db.ID;
            entity.SituationID = entity.SituationID;
            entity.UserID = entity.UserID;
            entity.Name_of_Person_In_Need = db.Name_of_Person_In_Need;
            entity.Contact_Details = db.Contact_Details;
            entity.KeyConcernID = db.KeyConcernID;
            entity.Age = db.Age;
            entity.Gender = db.Gender;
            entity.ActionsTakenSoFar = db.ActionsTakenSoFar;
            entity.FollowUpRequired = db.FollowUpRequired;

            entities.PersonInNeed_table.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Destroy(PersonInNeedViewModel db)
        {
            var entity = new PersonInNeed_table();

            entity.ID = db.ID;

            entities.PersonInNeed_table.Attach(entity);

            entities.PersonInNeed_table.Remove(entity);

            entities.SaveChanges();
        }

        /// <summary>
        /// خاص بالكمبو بوكس
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Key_concernForeingKey> ReadKey_concern()
        {
            return entities.Key_concernTable.Select(province => new Key_concernForeingKey
            {
                ID = province.ID,
                Key_concern = province.Key_concern


            });
        }


        public void Dispose()
        {
            entities.Dispose();
        }
    }
}