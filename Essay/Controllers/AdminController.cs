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

        private static EssayDBDataContext db = new EssayDBDataContext();
        
        // check is Exists From 3 table
        public static bool isExistsUser(string username)
        {

            //MessageBox.Show("user count: " + CountUser.ToString());

            if (isExistsAdmin(username) || ManagerController.isExistsUser(username) || EmployeeController.isExistsUser(username))
            {
                return true;
            }

            return false;

        }


        // check is Exists from each table

        public static bool isExistsEmployee(string username) // table employee
        {
            return EmployeeController.isExistsUser(username);
        }

        public static bool isExistsManager(string username) // table Manager
        {
            return ManagerController.isExistsUser(username);
        }

        public static bool isExistsAdmin(string username)  // table Admin
        {
            int CountAdmin = (from Ad in db.Admins
                              where Ad.User == username
                              select Ad.User).ToList().Count();
            return CountAdmin > 0;
        }


        // Delete from User Name
        public static bool DeleteUser(String  username)
        {
            if (EmployeeController.Delete(username)) return true;
            else if (ManagerController.Delete(username)) return true;

            return false;
        }

        // Lock Account from User Name
        public static bool LockUser(String username)
        {
            if (EmployeeController.Lock(username)) return true;
            else if (ManagerController.Lock(username)) return true;

            return false;
        }
    }
}
