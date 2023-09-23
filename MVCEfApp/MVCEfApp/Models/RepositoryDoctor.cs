using Microsoft.EntityFrameworkCore;

namespace MVCEfApp.Models
{
    public class RepositoryDoctor
    {
        public static List<Doctor> GetDoctors()
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var list = ctx.Doctors.ToList();
            return list;
        }
        public static Doctor GetDoctorById(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var doctor = ctx.Doctors.Find(id);
            return doctor;
        }
        public static void AddNewDoctor(Doctor doctor)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Doctors.Add(doctor);
            ctx.SaveChanges();
        }
        public static void ModifyDoctor (Doctor doctor)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(doctor).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemoveDoctor(int id) 
        {
            HospitalDbContext cxt = new HospitalDbContext();
            Doctor doctor = cxt.Doctors.Find(id);
            cxt.Doctors.Remove(doctor);
            cxt.SaveChanges();
        }
    }
}
