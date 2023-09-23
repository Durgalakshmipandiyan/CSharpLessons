using Microsoft.EntityFrameworkCore;
using MVCEfApp.Models;
using System;

namespace MVCEfApp.Models
{
    public class HospitalDbContext:DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            String conString = @"server=200411LTP2741\SQLEXPRESS ; database=HospitalDB;integrated security= true;Encrypt = false";
            options.UseSqlServer(conString); //this line cn be changed like for oracle, postgresql
        }
    }
}
