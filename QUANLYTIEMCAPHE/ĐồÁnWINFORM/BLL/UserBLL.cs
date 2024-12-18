using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UserBLL
    {
        private UserDAL _userDAL;

        public UserBLL()
        {
            _userDAL = new UserDAL();
        }

        public bool Login(string username, string password)
        {
            return _userDAL.CheckLogin(username, password);
        }
    }
}
