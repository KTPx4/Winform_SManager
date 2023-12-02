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
        public bool isExistsID(string id)
        {
            int countID = (from students in db.Students
                           where students.SID == id
                           select students.ID
                           ).ToList().Count();

            return countID > 0;
        }
        public bool isExistsCer(string idcer)
        {

            int countID = (from Cer in db.Certifications
                           where Cer.IDCertificate == idcer
                           select Cer.IDCertificate
                           ).ToList().Count();

            return countID > 0;
        }

        public List<Certification> GetCertifications(string sid) 
        {
            List<Certification> certifications = (from certification in db.Certifications
                                                  where certification.SID == sid
                                                  select certification).ToList();
            return certifications;
        }
        public List<Certification> GetCertifications()
        {
            List<Certification> certifications = (from certification in db.Certifications                                                 
                                                  select certification).ToList();
            return certifications;
        }

        public bool Add(Student student)
        {
            if(isExistsID(student.SID))
            {
                MessageBox.Show("Student ID already exists", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }

            db.Students.InsertOnSubmit(student);
            db.SubmitChanges();
            return true;
        }

        public bool AddCertificate(Certification certification)
        {
            if (!isExistsID(certification.SID))
            {
                MessageBox.Show("Student ID not exists", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }
            if(isExistsCer(certification.IDCertificate))
            {
                MessageBox.Show("Certificate ID already exists", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }

            db.Certifications.InsertOnSubmit(certification);
            db.SubmitChanges();
            return true;
        }

        public bool Update(Student student)
        {

            if (!isExistsID(student.SID))
            {
                MessageBox.Show("Student ID not exists", "Invalid SID", MessageBoxButtons.OK);
                return false;
            }

            // Tìm bản ghi Manager cần chỉnh sửa bằng User
            Student existingStudent = db.Students.SingleOrDefault(e => e.SID == student.SID);

            if (existingStudent != null)
            {
              
                existingStudent.Name = student.Name;
                existingStudent.birthDay = student.birthDay;
                existingStudent.Address = student.Address;
                existingStudent.Class = student.Class;

              
                // Lưu các thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();

                return true;
            }
           
            return false; // Bản ghi không tồn tại hoặc không tìm thấy
        }

        public bool UpdateCertificate(Certification certification)
        {
            if (!isExistsID(certification.SID))
            {
                MessageBox.Show("Student ID not exists", "Invalid SID", MessageBoxButtons.OK);
                return false;
            }

            if (!isExistsCer(certification.IDCertificate))
            {
                MessageBox.Show("Certificate ID not exists", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }

            Certification existingCer = db.Certifications.SingleOrDefault(e => e.IDCertificate == certification.IDCertificate);
            if (existingCer != null)
            {
                existingCer.Name = certification.Name;
                existingCer.IssueDate = certification.IssueDate;
                existingCer.ExpiryDate = certification.ExpiryDate;
                existingCer.Grade = certification.Grade;
                
                db.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool Delete(String SID)
        {
            if (isExistsID(SID))
            {
                var m = db.Students.SingleOrDefault(e => e.SID == SID);

                //Manager m = (Manager)(from e in db.Managers
                //                                       where e.User == username
                //                                       select e);
                if (m != null)
                {
                    var cer = (from certificate in db.Certifications
                               where certificate.SID == SID
                               select certificate).ToList();

                    db.Certifications.DeleteAllOnSubmit(cer);
                    db.Students.DeleteOnSubmit(m);
                    
                    db.SubmitChanges();

                    return true;
                }
            }
            return false;
        }

        public bool DeleteCertificate(string CerID)
        {
            if (!isExistsCer(CerID))
            {
                MessageBox.Show("Certificate ID not exists", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }
            var cer = db.Certifications.SingleOrDefault(e=> e.IDCertificate == CerID);
            db.Certifications.DeleteOnSubmit(cer);
            db.SubmitChanges();
            return true;
        }


    }
}
