using Essay.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essay.Controllers
{
    public class AdminController
    {
      
     

        public static bool isExistsUser(string username)
        {

            EssayDBDataContext db = new EssayDBDataContext();

            int CountAdmin = ( from Ad in db.Admins 
                              where Ad.User == username
                              select Ad.User).ToList().Count();

            int CountManager = (from Ad in db.Managers
                              where Ad.User == username
                              select Ad.User).ToList().Count();

            int CountEmployee = (from Ad in db.Employees
                                where Ad.User == username
                                select Ad.User).ToList().Count();


            //MessageBox.Show("user count: " + CountUser.ToString());

            if (CountAdmin != 0 || CountManager != 0 || CountEmployee != 0)
            {
                return true;
            }

            return false;

        }
    }
}
