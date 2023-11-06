using Essay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Essay.Controllers
{
    public class EmployeeController
    {

      
        private static EssayDBDataContext db ;

        public EmployeeController() 
        {
            db = new EssayDBDataContext();
        }
        // method get
        public  List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public  List<Employee> GetListActive()
        {
            
            return GetFromStatus(0);
        }

        public  List<Employee> GetListBlocked()
        {
          
            return GetFromStatus(1);
        }

        public  List<Employee> GetListDeleted()
        {
            return GetFromStatus(-1);
        }

        public  Employee GetFromUser(string username)
        {
            return db.Employees.SingleOrDefault(e => e.User == username);
        }

        public  int NextID()
        {


            var currentID = (from em in db.Employees
                             orderby em.ID descending
                             select em.ID).FirstOrDefault();

            //int id = int.Parse(currentID.ToString());
            // MessageBox.Show("" + currentID);

            return int.Parse(currentID.ToString()) + 1;
        }

        
        // method Check
        public  bool isExistsUser(String username)
        {
            EssayDBDataContext db = new EssayDBDataContext();


            int CountEmployee = (from Ad in db.Employees
                                 where Ad.User == username
                                 select Ad.User).ToList().Count();

            return CountEmployee > 0;
        }
        
       

        // C-U-D 
        public  bool Add(Employee employee)
        {
            if (!new AdminController().isExistsUser(employee.User))
            {
                db.Employees.InsertOnSubmit(employee);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public  bool Update(Employee Employee)
        {


            // Tìm bản ghi Manager cần chỉnh sửa bằng User
            Employee existingEmployee = db.Employees.SingleOrDefault(m => m.ID == Employee.ID);

            if (existingEmployee != null)
            {
                // Thực hiện các thay đổi cần thiết trên bản ghi Manager
                existingEmployee.Name = Employee.Name;
                existingEmployee.Pass = Employee.Pass;
                existingEmployee.birthDay = Employee.birthDay;
                existingEmployee.Phone = Employee.Phone;
                existingEmployee.LinkAVT = Employee.LinkAVT;

                // if change user -> check exists with other row
             //    MessageBox.Show("db: " + existingEmployee.User + ", :" + Employee.User);
                if (existingEmployee.User != Employee.User && new AdminController().isExistsUser(Employee.User))
                {
                    MessageBox.Show("User Name is invalid", "Error Input", MessageBoxButtons.OK);
                    return false;
                }
                else if (existingEmployee.User != Employee.User && !new AdminController().isExistsUser(Employee.User))
                {
                    existingEmployee.User = Employee.User;
                }

                // Lưu các thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();

                return true;
            }

            return false; // Bản ghi không tồn tại hoặc không tìm thấy
        }

        public  bool Delete(String username)
        {
            if (isExistsUser(username))
            {
                Employee m = db.Employees.SingleOrDefault(e => e.User == username);

                //Manager m = (Manager)(from e in db.Managers
                //                                       where e.User == username
                //                                       select e);
                if (m != null)
                {
                    //db.Managers.DeleteOnSubmit(m);
                    // db.SubmitChanges();

                    // setStatus(username, -1); // delete -> hide

                    m.Status = -1;
                    db.SubmitChanges();

                    return true;
                }
            }
            return false;
        }

        public  bool Lock(String username)
        {           
            return SetStatus(username, 1);
        }

        public  bool Restore(String username)
        {
            return SetStatus(username, 0);
        }

        public  bool SetStatus(String username, int status)
        {
            if (isExistsUser(username))
            {
                Employee m = db.Employees.SingleOrDefault(e => e.User == username);


                if (m != null)
                {
                    m.Status = status;
                    db.SubmitChanges();
                    return true;
                }
            }
            return false;
        }

        public  bool SetisOnline(String username, bool Status)
        {
            if (isExistsUser(username))
            {
                Employee m = db.Employees.SingleOrDefault(e => e.User == username);


                if (m != null)
                {
                    m.isOnline = Status;
                    db.SubmitChanges();
                    return true;
                }
            }
            return false;
        }

        public  bool WriteHistory(Employee e, DateTime date)
        {
            try
            {
                HistoryEmployee h = new HistoryEmployee()
                {
                    ID = e.ID,
                    TimeLogin = date
                };
                db.HistoryEmployees.InsertOnSubmit(h);
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error store history Employee: " + ex.Message);
            }
            return false;

        }


        //private method
        private  List<Employee> GetFromStatus(int status)
        {
            List<Employee> list = (from m in db.Employees
                                  where m.Status == status
                                  select m).ToList();

            return list;
        }

    }
}
