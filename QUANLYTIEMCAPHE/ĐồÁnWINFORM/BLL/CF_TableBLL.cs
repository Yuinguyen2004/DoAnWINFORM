using System.Collections.Generic;
using DAL;
using DAL.Model;

namespace BLL
{
    public class CF_TableBLL
    {
        private CF_TableDAL tableDAL = new CF_TableDAL();

        public List<dynamic> GetAllTables()
        {
            return tableDAL.GetAllTables();
        }

        public CF_Table GetTableById(string tableId)
        {
            return tableDAL.GetTableById(tableId);
        }

        public void AddTable(CF_Table table)
        {
            tableDAL.AddTable(table);
        }

        public void UpdateTable(CF_Table table)
        {
            tableDAL.UpdateTable(table);
        }

        public void DeleteTable(string tableId)
        {
            tableDAL.DeleteTable(tableId);
        }
    }
}
