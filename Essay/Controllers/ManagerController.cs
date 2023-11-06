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
            db = new EssayDBDataContext();
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

        public static bool SetisOnline(String username, bool Status)
        {
            if (isExistsUser(username))
            {
                Manager m = db.Managers.SingleOrDefault(e => e.User == username);

                if (m != null)
                {
                    m.isOnline = Status;
                    db.SubmitChanges();
                    return true;
                }
            }
            return false;
        }

        public static bool Update(Manager Manager)
        {


            // Tìm bản ghi Manager cần chỉnh sửa bằng User
            //Manager existingManager = db.Managers.SingleOrDefault(m => m.ID == Manager.ID);
            Manager existingManager = (from m in db.Managers
                                       where m.ID == Manager.ID
                                       select m).FirstOrDefault();
           // MessageBox.Show("Pre-if");

            if (existingManager != null)
            {
                //MessageBox.Show("ok nhe");
                // Thực hiện các thay đổi cần thiết trên bản ghi Manager
                existingManager.Name = Manager.Name;
                existingManager.Pass = Manager.Pass;
                existingManager.birthDay = Manager.birthDay;
                existingManager.Phone = Manager.Phone;
                existingManager.LinkAVT = Manager.LinkAVT;

                // if change user -> check exists with other row
                if (existingManager.User != Manager.User && AdminController.isExistsUser(Manager.User))
                {
                    MessageBox.Show("User Name is invalid", "Error Input", MessageBoxButtons.OK);
                    return false;
                }
                else if(existingManager.User != Manager.User && !AdminController.isExistsUser(Manager.User))
                {
                    existingManager.User = Manager.User;
                }

                // Lưu các thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();

                return true;
            }

            return false; // Bản ghi không tồn tại hoặc không tìm thấy
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

        public static bool Restore(String username)
        {
            return SetStatus(username, 0);
        }

        public static bool WriteHistory(Manager e, DateTime date)
        {
            try
            {
                HistoryManager h = new HistoryManager()
                {
                    ID = e.ID,
                    TimeLogin = date
                };
                db.HistoryManagers.InsertOnSubmit(h);
                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error store history Manager: " + ex.Message);
            }
            return false;

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
