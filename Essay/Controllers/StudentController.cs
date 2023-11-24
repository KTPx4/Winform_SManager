using Essay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essay.Controllers
{
    public class StudentController
    {
        private static EssayDBDataContext db;

        public StudentController() 
        {
            db = new EssayDBDataContext();
        }

        public List<Student> GetALL() 
        {
            return db.Students.ToList();
        }


    }
}
