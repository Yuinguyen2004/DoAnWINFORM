using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;

namespace DAL
{
    public class UserDAL
    {
        private Cafe_Management cafe;

        public UserDAL() 
        {
            cafe = new Cafe_Management();
        }

        public bool CheckLogin(string username, string password)
        {
            return cafe.Users.Any(u => u.UserName == username && u.Userpassword == password);
        }
    }
}
