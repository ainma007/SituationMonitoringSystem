using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SituationMonitoring.Models
{
    public class AreaService
    {

        private SituationMonitoringEntities entities;

        public AreaService(SituationMonitoringEntities entities)
        {
            this.entities = entities;
        }

        public IEnumerable<AreaViewModel> Read()
        {
            return entities.Area_Table.Select(db => new AreaViewModel
            {
                AreaID = db.AreaID,
                AreaArName = db.AreaArName,
                AreaEnName = db.AreaEnName,
                GovernorateID = db.GovernorateID,

                Governorate = new GovernorateViewModel()
                {
                    GovernorateID = db.Governorate_Table.GovernorateID,
                    GovernorateArName = db.Governorate_Table.GovernorateArName
                },


            });
        }


        public void Create(AreaViewModel db)
        {
            var entity = new Area_Table();

            entity.AreaArName = db.AreaArName;
            entity.AreaEnName = db.AreaEnName;
            entity.GovernorateID = db.GovernorateID;

            entities.Area_Table.Add(entity);
            entities.SaveChanges();

            db.AreaID = entity.AreaID;
        }

        public void Update(AreaViewModel db)
        {
            var entity = new Area_Table();

            entity.AreaID = db.AreaID;
            entity.AreaArName = db.AreaArName;
            entity.AreaEnName = db.AreaEnName;
            entity.GovernorateID = db.GovernorateID;


            entities.Area_Table.Attach(entity);
            entities.Entry(entity).State = EntityState.Modified;
            entities.SaveChanges();
        }

        public void Destroy(AreaViewModel db)
        {
            var entity = new Area_Table();

            entity.AreaID = db.AreaID;

            entities.Area_Table.Attach(entity);

            entities.Area_Table.Remove(entity);

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