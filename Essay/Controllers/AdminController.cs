using DevExpress.Mvvm.Native;
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
        
        public static Admin GetFromUser(string username)
        {
            return db.Admins.SingleOrDefault(e => e.User == username);
        }

        public static int ValidLogin(string username, string password)
        {
            int CountAdmin = (from Ad in db.Admins
                              where Ad.User == username && Ad.Password == password
                              select Ad.User).ToList().Count();
            if (CountAdmin > 0) return 2; // admin

            int CountManager = (from Ad in db.Managers
                              where Ad.User == username && Ad.Pass == password
                              select Ad.User).ToList().Count();
            if (CountManager > 0) return 0; // manager

            int CountEmp = (from Ad in db.Employees
                                where Ad.User == username && Ad.Pass == password
                                select Ad.User).ToList().Count();
            if (CountEmp > 0) return 1; // employee

            return -1; // not found

        }
        
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


        //Edit user
        public static bool Update(Admin Admin)
        {


            // Tìm bản ghi Manager cần chỉnh sửa bằng User
            Admin existingAdmin = db.Admins.SingleOrDefault(m => m.User == Admin.User);

            if (existingAdmin != null)
            {
                // Thực hiện các thay đổi cần thiết trên bản ghi Manager
                existingAdmin.Name = Admin.Name;
                existingAdmin.Password = Admin.Password;                
                existingAdmin.LinkAVT = Admin.LinkAVT;

                // if change user -> check exists with other row
                //    MessageBox.Show("db: " + existingEmployee.User + ", :" + Employee.User);
                if (existingAdmin.User != Admin.User && AdminController.isExistsUser(Admin.User))
                {
                    MessageBox.Show("User Name is invalid", "Error Input", MessageBoxButtons.OK);
                    return false;
                }
                else if (existingAdmin.User != Admin.User && !AdminController.isExistsUser(Admin.User))
                {
                    existingAdmin.User = Admin.User;
                }

                // Lưu các thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();

                return true;
            }

            return false; // Bản ghi không tồn tại hoặc không tìm thấy
        }

        // Lock Account from User Name
        public static bool LockUser(String username)
        {
            if (EmployeeController.Lock(username)) return true;
            else if (ManagerController.Lock(username)) return true;
            return false;
        }

        public static bool RestoreUser(String username)
        {
            if (EmployeeController.Restore(username)) return true;
            else if (ManagerController.Restore(username)) return true;

            return false;
        }

        // Find from search
        public static Tuple<List<Manager>, List<Employee>> Search(String search)
        {           

            // Tìm các bản ghi trong bảng Manager thỏa mãn điều kiện tìm kiếm
            List<Manager> managerResults = db.Managers
                .Where(m => m.Name.Contains(search) || m.User.Contains(search) || m.Phone.Contains(search))
                .ToList();

            // Tìm các bản ghi trong bảng Employee thỏa mãn điều kiện tìm kiếm
            List<Employee> employeeResults = db.Employees
                .Where(e => e.Name.Contains(search) || e.User.Contains(search) || e.Phone.Contains(search))
                .ToList();

            Tuple<List<Manager>, List<Employee>> Result = new Tuple<List<Manager>, List<Employee>>(managerResults, employeeResults);
            
            return Result;
        }
    }
}
