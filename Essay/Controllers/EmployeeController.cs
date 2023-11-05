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

      
        private static EssayDBDataContext db = new EssayDBDataContext();

        public EmployeeController() 
        { 
            
        }
        // method get
        public static List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public static List<Employee> GetListActive()
        {
            
            return GetFromStatus(0);
        }

        public static List<Employee> GetListBlocked()
        {
          
            return GetFromStatus(1);
        }

        public static List<Employee> GetListDeleted()
        {
            return GetFromStatus(-1);
        }

        public static Employee GetFromUser(string username)
        {
            return db.Employees.SingleOrDefault(e => e.User == username);
        }

        public static int NextID()
        {


            var currentID = (from em in db.Employees
                             orderby em.ID descending
                             select em.ID).FirstOrDefault();

            //int id = int.Parse(currentID.ToString());
            // MessageBox.Show("" + currentID);

            return int.Parse(currentID.ToString()) + 1;
        }

        
        // method Check
        public static bool isExistsUser(String username)
        {
            EssayDBDataContext db = new EssayDBDataContext();


            int CountEmployee = (from Ad in db.Employees
                                 where Ad.User == username
                                 select Ad.User).ToList().Count();

            return CountEmployee > 0;
        }
        
       

        // C-U-D 
        public static bool Add(Employee employee)
        {
            if (!AdminController.isExistsUser(employee.User))
            {
                db.Employees.InsertOnSubmit(employee);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public static bool Delete(String username)
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

        public static bool Lock(String username)
        {           
            return SetStatus(username, 1);
        }


        public static bool SetStatus(String username, int status)
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



        //private method
        private static List<Employee> GetFromStatus(int status)
        {
            List<Employee> list = (from m in db.Employees
                                  where m.Status == status
                                  select m).ToList();

            return list;
        }

    }
}
