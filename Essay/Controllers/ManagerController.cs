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
        private static EssayDBDataContext db;

        public ManagerController()
        {
            db = new EssayDBDataContext();
        }

        // method Get
        public  List<Manager> GetAll()
        {
            return db.Managers.ToList();
        }

        public  List<Manager> GetListActive()
        {
            return GetFromStatus(0);
        }

        public  List<Manager> GetListBlocked()
        {
            return GetFromStatus(1);
        }

        public  List<Manager> GetListDeleted()
        {
           
            return GetFromStatus(-1);
        }

        public  Manager GetByUser(string username)
        {
            return db.Managers.SingleOrDefault(e => e.User == username) ?? new Manager();
        }

        public Manager GetByID(int id)
        {
            return db.Managers.SingleOrDefault(e => e.ID == id) ?? new Manager();
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



        // method check
        public  bool isExistsUser(String username)
        {
            //EssayDBDataContext db = new EssayDBDataContext();


            int CountManager = (from Ad in db.Managers
                                 where Ad.User == username
                                 select Ad.User).ToList().Count();

            return CountManager > 0;

        }



        // C-U-D

        public  bool Add(Manager m)
        {
            if (!new AdminController().isExistsUser(m.User))
            {
                db.Managers.InsertOnSubmit(m);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public  bool SetStatus(String username, int status)
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

        public  bool SetisOnline(String username, bool Status)
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

        public  bool Update(Manager Manager)
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
                if (existingManager.User != Manager.User && new AdminController().isExistsUser(Manager.User))
                {
                    MessageBox.Show("User Name is invalid", "Error Input", MessageBoxButtons.OK);
                    return false;
                }
                else if(existingManager.User != Manager.User && !new AdminController().isExistsUser(Manager.User))
                {
                    existingManager.User = Manager.User;
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

        public  bool Lock(String username)
        {
            return SetStatus(username, 1);
        }

        public  bool Restore(String username)
        {
            return SetStatus(username, 0);
        }

        public  bool WriteHistory(Manager e, DateTime date)
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
        private  List<Manager> GetFromStatus(int status)
        {
            List<Manager> list = (from m in db.Managers
                                  where m.Status == status
                                  select m).ToList();

            return list;
        }

    }


}
