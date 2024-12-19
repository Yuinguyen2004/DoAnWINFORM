using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL
{
    public class AreaDAL
    {
        private Cafe_Management db = new Cafe_Management();
        public List<Area> GetAllAreas()
        {   
                return db.Areas.ToList();
        }

        public void AddArea(Area area)
        {
                db.Areas.Add(area);
                db.SaveChanges();
        }

        public void UpdateArea(Area area)
        {
                var existingArea = db.Areas.Find(area.AreaID);
                if (existingArea != null)
                {
                    existingArea.AreaName = area.AreaName;
                    db.SaveChanges();
                }
        }

        public void DeleteArea(string areaID)
        {
                var area = db.Areas.Find(areaID);
                if (area != null)
                {
                    db.Areas.Remove(area);
                    db.SaveChanges();
                }
        }

    }
}
