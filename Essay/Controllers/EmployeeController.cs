using Essay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essay.Controllers
{
    public class EmployeeController
    {

      
        private static EssayDBDataContext db = new EssayDBDataContext();

        public EmployeeController() 
        { 
            
        }

        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public static bool Add(Employee employee)
        {
            if(!AdminController.isExistsUser(employee.User))
            {
                db.Employees.InsertOnSubmit(employee);
                db.SubmitChanges();
                return true;
            }
            return false;
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
        

    }
}
