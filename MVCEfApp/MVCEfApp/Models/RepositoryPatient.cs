using Microsoft.EntityFrameworkCore;

namespace MVCEfApp.Models
{
    public class RepositoryPatient
    {
        public static List<Patient> GetPatients()
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var list = ctx.Patients.ToList();
            return list;
        }
        public static Patient GetPatientById(int id)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            var patient = ctx.Patients.Find(id);
            return patient;
        }
        public static void AddNewPatient(Patient patient)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Patients.Add(patient);
            ctx.SaveChanges();
        }
        public static void ModifyPatient(Patient patient)
        {
            HospitalDbContext ctx = new HospitalDbContext();
            ctx.Entry(patient).State = EntityState.Modified;
            ctx.SaveChanges();
        }
        public static void RemovePatient(int id)
        {
            HospitalDbContext cxt = new HospitalDbContext();
            Patient patient = cxt.Patients.Find(id);
            cxt.Patients.Remove(patient);
            cxt.SaveChanges();
        }
    }
}
