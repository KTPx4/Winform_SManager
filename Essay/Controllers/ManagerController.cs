using Essay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essay.Controllers
{
    public class ManagerController
    {
        private static EssayDBDataContext db = new EssayDBDataContext();

        public ManagerController()
        {
           
        }

        public List<Manager> GetAll()
        {
            return db.Managers.ToList();
        }

        public static bool Add(Manager m)
        {
            if (!AdminController.isExistsUser(m.User))
            {
                db.Managers.InsertOnSubmit(m);
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
