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

        public List<List<String>> getHisEmp(String User)
        {
            EmployeeController empController = new EmployeeController();
            ManagerController managerController = new ManagerController();
            List<List<String>> listHis = new List<List<String>>();

            if (!empController.isExistsUser(User) && !managerController.isExistsUser(User)) return null;

            try
            {
                Employee employee = empController.GetFromUser(User);
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
                        list.Add(employee.Name);
                        list.Add(emp.TimeLogin.ToString() ?? "");
                        listHis.Add(list);
                    }

                }
                Manager manager = managerController.GetFromUser(User);
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




    }
}
