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

      
        private EssayDBDataContext db;

        public EmployeeController() 
        { 
            db = new EssayDBDataContext();
        }

        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public bool CheckE(String user)
        {
            return false;
        }

    }
}
