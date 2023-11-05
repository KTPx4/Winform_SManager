using Essay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Essay.Controllers
{
    public class ManagerController
    {
        private static EssayDBDataContext db = new EssayDBDataContext();

        public ManagerController()
        {
           
        }

        // method Get
        public static List<Manager> GetAll()
        {
            return db.Managers.ToList();
        }

        public static List<Manager> GetListActive()
        {
            return GetFromStatus(0);
        }

        public static List<Manager> GetListBlocked()
        {
            return GetFromStatus(1);
        }

        public static List<Manager> GetListDeleted()
        {
           
            return GetFromStatus(-1);
        }

        public static Manager GetFromUser(string username)
        {
            return db.Managers.SingleOrDefault(e => e.User == username);
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



        // method check
        public static bool isExistsUser(String username)
        {
            //EssayDBDataContext db = new EssayDBDataContext();


            int CountManager = (from Ad in db.Managers
                                 where Ad.User == username
                                 select Ad.User).ToList().Count();

            return CountManager > 0;

        }



        // C-U-D

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

        public static bool SetStatus(String username, int status)
        {
            if (isExistsUser(username))
            {
                Manager m = db.Managers.SingleOrDefault(e => e.User == username);

                                              
                if (m != null)
                {
                    m.Status = status;
                    db.SubmitChanges();
                    return true;
                }
            }
            return false;
        }

        public static bool Delete(String username)
        {
            if (isExistsUser(username))
            {
                Manager m = db.Managers.SingleOrDefault(e => e.User == username);

                //Manager m = (Manager)(from e in db.Managers
                //                                       where e.User == username
                //                                       select e);
                if(m != null)
                {
                    //db.Managers.DeleteOnSubmit(m);
                    // db.SubmitChanges();

                    //setStatus(username, -1); // delete -> hide
                    
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


        // private method
        private static List<Manager> GetFromStatus(int status)
        {
            List<Manager> list = (from m in db.Managers
                                  where m.Status == status
                                  select m).ToList();

            return list;
        }

    }
}
