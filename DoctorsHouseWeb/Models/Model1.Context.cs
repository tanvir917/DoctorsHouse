﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoctorsHouseWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DoctorsHouseEntities1 : DbContext
    {
        public DoctorsHouseEntities1()
            : base("name=DoctorsHouseEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Fee> Fees { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Online_Payments> Online_Payments { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
    }
}