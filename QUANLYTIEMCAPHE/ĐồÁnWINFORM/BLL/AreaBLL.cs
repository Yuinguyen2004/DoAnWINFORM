using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Model;

namespace BLL
{
    public class AreaBLL
    {
        private AreaDAL areaDAL = new AreaDAL();

        public List<Area> GetAreas() {
            return areaDAL.GetAllAreas();
        }

        public void AddArea(Area area)
        {
            areaDAL.AddArea(area);
        }

        public void UpdateArea(Area area)
        {
            areaDAL.UpdateArea(area);
        }

        public void DeleteArea(string areaID)
        {
            areaDAL.DeleteArea(areaID);
        }

    }
}
