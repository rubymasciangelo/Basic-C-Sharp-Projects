using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VroomInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Apply(string firstName, string lastName, string emailAddress, int MM, int DD, int YYYY, int year,
                            string make, string model, string DUI, int tickets, string insuranceType)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Application (FirstName, LastName, EmailAddress)
                                    VALUES (@FirstName, @LastName, @EmailAddress)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                command.Parameters.Add("@LastName", SqlDbType.VarChar);
                command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                command.Parameters["@FirstName"].Value = firstName;
                command.Parameters["@LastName"].Value = lastName;
                command.Parameters["@EmailAddress"].Value = emailAddress;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            return View("Applied");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}