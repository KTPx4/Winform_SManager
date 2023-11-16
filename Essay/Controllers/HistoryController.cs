using Essay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Essay.Controllers
{
    public class HistoryController
    {
        private EssayDBDataContext db;

        public HistoryController()
        {
            db = new EssayDBDataContext();
        }

        public List<List<String>> getHisUser(String User)
        {
            EmployeeController empController = new EmployeeController();
            ManagerController managerController = new ManagerController();
            List<List<String>> listHis = new List<List<String>>();

            if (!empController.isExistsUser(User) && !managerController.isExistsUser(User)) return null;

            try
            {
                Employee employee = empController.GetByUser(User);
                if (employee != null)
                {

                    int IDe = employee.ID;
                    List<HistoryEmployee> historyE = (from h in db.HistoryEmployees
                                                      where h.ID == IDe
                                                      select h).ToList();
                    foreach (HistoryEmployee emp in historyE)
                    {
                        List<String> list = new List<String>();
                        list.Add(employee.User);
                        list.Add("Employee");
                        list.Add(employee.Name);
                        list.Add(emp.TimeLogin.ToString() ?? "");
                        listHis.Add(list);
                    }

                }
                Manager manager = managerController.GetByUser(User);
                if (manager != null)
                {
                    int IDm = manager.ID;
                    List<HistoryManager> historyM = (from h in db.HistoryManagers
                                                     where h.ID == IDm
                                                     select h).ToList();
                    foreach (HistoryManager m in historyM)
                    {
                        List<String> list = new List<String>();
                        list.Add(manager.User);
                        list.Add("Manager");
                        list.Add(manager.Name);
                        list.Add(m.TimeLogin.ToString() ?? "");
                        listHis.Add(list);
                    }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error When load History one User: " + ex.Message);
            }
          

            return listHis;

        }

        public List<List<String>> getAllHis()
        {
            EmployeeController empController = new EmployeeController();
            ManagerController managerController = new ManagerController(); 

            
            List<List<String>> listHis = new List<List<String>>();

            
            List<HistoryEmployee> hisE = (from e in db.HistoryEmployees
                                   orderby e.ID 
                                   select e).ToList();

            List<HistoryManager> hisM = (from e in db.HistoryManagers
                                          orderby e.ID
                                          select e).ToList();

            foreach (HistoryManager manager in hisM)
            {
                int id = manager.ID ?? -1;
                Manager m = managerController.GetByID(id);

                List<String> list = new List<String>();
                list.Add(m.User);
                list.Add("Manager");
                list.Add(m.Name);
                list.Add(manager.TimeLogin.ToString() ?? "");
                listHis.Add(list);
            }

            foreach (HistoryEmployee emp in hisE)
            {
                int id = emp.ID ?? -1;
                Employee e = empController.GetByID(id);

                List<String> list = new List<String>();
                list.Add(e.User);
                list.Add("Employee");
                list.Add(e.Name);
                list.Add(emp.TimeLogin.ToString() ?? "");
                listHis.Add(list);
            }
           

            return listHis;
        }

        public List<List<string>> SearchHistory(string keyword)
        {
            EmployeeController empController = new EmployeeController();
            ManagerController managerController = new ManagerController();
            List<List<string>> listHis = new List<List<string>>();

            // Lấy lịch sử đăng nhập của Manager dựa trên từ khóa tìm kiếm User
            var managerHistories = (from manager in db.HistoryManagers
                                    where manager.Manager.User.Contains(keyword)
                                    orderby manager.ID
                                    select manager).ToList();

            foreach (var manager in managerHistories)
            {
                Manager m = managerController.GetByID(manager.ID ?? -1);

                List<string> list = new List<string>();
                list.Add(m.User);
                list.Add("Manager");
                list.Add(m.Name);
                list.Add(manager.TimeLogin.ToString() ?? "");
                listHis.Add(list);
            }

            // Lấy lịch sử đăng nhập của Employee dựa trên từ khóa tìm kiếm User
            var employeeHistories = (from emp in db.HistoryEmployees
                                     where emp.Employee.User.Contains(keyword)
                                     orderby emp.ID
                                     select emp).ToList();

            foreach (var emp in employeeHistories)
            {
                Employee e = empController.GetByID(emp.ID ?? -1);

                List<string> list = new List<string>();
                list.Add(e.User);
                list.Add("Employee");
                list.Add(e.Name);
                list.Add(emp.TimeLogin.ToString() ?? "");
                listHis.Add(list);
            }

            return listHis;
        }


    }
}
