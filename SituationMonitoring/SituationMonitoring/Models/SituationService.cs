using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace SituationMonitoring.Models
{
    public class SituationService
    {
        private SituationMonitoringEntities entities;

        public SituationService(SituationMonitoringEntities entities)
        {
            this.entities = entities;
        }

        public IEnumerable<SituationViewModel> Read()
        {
            return entities.Situation_Table.Select(db => new SituationViewModel
            {
                SituationID = db.SituationID,
                SituationDate = db.SituationDate.HasValue ? db.SituationDate.Value : default(DateTime),
              
                GovernorateID = db.GovernorateID,

                Governorate = new GovernorateViewModel()
                {
                    GovernorateID = db.Governorate_Table.GovernorateID,
                    GovernorateArName = db.Governorate_Table.GovernorateArName
                },

                MunicipalityID = db.MunicipalityID,

                Municipality = new SessionForeignKey.MunicipalityForeingKey()
                {
                    MunicipalityID = db.Municipality_Table.MunicipalityID,
                    MunicipalityName = db.Municipality_Table.MunicipalityArName
                },

                AreaID = db.AreaID,

                Area = new SessionForeignKey.AreaForeingKey()
                {
                    AreaID = db.Area_Table.AreaID,
                    AreaName = db.Area_Table.AreaArName
                },


                CollectiveCenter = db.CollectiveCenter,
                Site_Description=db.Site_Description,
            });
        }

        public void Create(SituationViewModel db)
        {
            var entity = new Situation_Table();

            entity.SituationDate = db.SituationDate;
            entity.GovernorateID = db.GovernorateID;
            entity.MunicipalityID = db.MunicipalityID;
            entity.AreaID = db.AreaID;
            entity.CollectiveCenter = db.CollectiveCenter;
            entity.Site_Description = db.Site_Description;

            entities.Situation_Table.Add(entity);
            entities.SaveChanges();

            db.SituationID = entity.SituationID;
        }


        public void Update(SituationViewModel db)
        {
            var entity = new Situation_Table();

            entity.SituationID = db.SituationID;
            entity.SituationDate = db.SituationDate;
            entity.GovernorateID = db.GovernorateID;
            entity.MunicipalityID = db.MunicipalityID;
            entity.AreaID = db.AreaID;
            entity.CollectiveCenter = db.CollectiveCenter;
            entity.Site_Description = db.Site_Description;
            entities.Situation_Table.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Destroy(SituationViewModel db)
        {
            var entity = new Situation_Table();

            entity.SituationID = db.SituationID;

            entities.Situation_Table.Attach(entity);

            entities.Situation_Table.Remove(entity);

            entities.SaveChanges();
        }

        public IEnumerable<GovernorateViewModel> ReadGovernorate()
        {
            return entities.Governorate_Table.Select(province => new GovernorateViewModel
            {
                GovernorateID = province.GovernorateID,
                GovernorateArName = province.GovernorateArName


            });
        }


        public IEnumerable<SessionForeignKey.MunicipalityForeingKey> ReadMunicipality()
        {
            return entities.Municipality_Table.Select(province => new SessionForeignKey.MunicipalityForeingKey
            {
                MunicipalityID = province.MunicipalityID,
                MunicipalityName = province.MunicipalityArName


            });
        }


        public IEnumerable<SessionForeignKey.AreaForeingKey> ReadArea()
        {
            return entities.Area_Table.Select(province => new SessionForeignKey.AreaForeingKey
            {
                AreaID = province.AreaID,
                AreaName = province.AreaArName


            });
        }
        public void Dispose()
        {
            entities.Dispose();
        }

    }
}