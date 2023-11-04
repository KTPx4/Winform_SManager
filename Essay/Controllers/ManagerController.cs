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
        private EssayDBDataContext db;

        public ManagerController()
        {
            db = new EssayDBDataContext();
        }

        public List<Manager> GetAll()
        {
            return db.Managers.ToList();
        }
    }
}
