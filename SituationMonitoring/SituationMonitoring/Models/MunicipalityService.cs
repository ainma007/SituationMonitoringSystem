using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SituationMonitoring.Models
{
    public class MunicipalityService
    {
        private SituationMonitoringEntities entities;

        public MunicipalityService(SituationMonitoringEntities entities)
        {
            this.entities = entities;
        }

        public IEnumerable<MunicipalityViewModel> Read()
        {
            return entities.Municipality_Table.Select(db => new MunicipalityViewModel
            {
                MunicipalityID = db.MunicipalityID,
                MunicipalityArName = db.MunicipalityArName,
                MunicipalityEnName = db.MunicipalityEnName,
                GovernorateID = db.GovernorateID,

                Governorate = new GovernorateViewModel()
                {
                    GovernorateID = db.Governorate_Table.GovernorateID,
                    GovernorateArName = db.Governorate_Table.GovernorateArName
                },


            });
        }


        public void Create(MunicipalityViewModel db)
        {
            var entity = new Municipality_Table();

            entity.MunicipalityArName = db.MunicipalityArName;
            entity.MunicipalityEnName = db.MunicipalityEnName;
            entity.GovernorateID = db.GovernorateID;

            entities.Municipality_Table.Add(entity);
            entities.SaveChanges();

            db.MunicipalityID = entity.MunicipalityID;
        }

        public void Update(MunicipalityViewModel db)
        {
            var entity = new Municipality_Table();

            entity.MunicipalityID = db.MunicipalityID;
            entity.MunicipalityArName = db.MunicipalityArName;
            entity.MunicipalityEnName = db.MunicipalityEnName;
            entity.GovernorateID = db.GovernorateID;


            entities.Municipality_Table.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Destroy(MunicipalityViewModel db)
        {
            var entity = new Municipality_Table();

            entity.MunicipalityID = db.MunicipalityID;

            entities.Municipality_Table.Attach(entity);

            entities.Municipality_Table.Remove(entity);

            entities.SaveChanges();
        }

        /// <summary>
        /// خاص بالكمبو بوكس
        /// </summary>
        /// <returns></returns>
        public IEnumerable<GovernorateViewModel> ReadGovernorate()
        {
            return entities.Governorate_Table.Select(province => new GovernorateViewModel
            {
                GovernorateID = province.GovernorateID,
                GovernorateArName = province.GovernorateArName


            });
        }


        public void Dispose()
        {
            entities.Dispose();
        }
    }
}