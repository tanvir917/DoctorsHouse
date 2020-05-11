using DoctorsHouseWeb.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorsHouseWeb.Controllers
{
    public class UserAuthenticationController : Controller
    {
        
        public string connectionString = @"Data Source = TANVIRPC\SQLEXPRESS; Initial Catalog = 

; Integrated Security = true";
        // GET: UserAuthentication
        public ActionResult Index()
        {
            var students = new DataTable();
            using (var sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                var query = "Select * from Patient";
                var sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.Fill(students);
                
            }
            return View(students);
        }
        public ActionResult Create(Student student)
        {
            using (var sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                var query = "insert into students(Id, name, Des) values(@Id, @Name, @Des)";
                var sqlCmd = new SqlCommand(query, sqlCon);
                

            }
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
    }
}