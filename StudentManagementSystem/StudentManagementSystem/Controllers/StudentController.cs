using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=School;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // GET: Student
        public ActionResult Index()
        {
            string queryString = "Select * From Students";
            List<Student> students = new List<Student>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Student student = new Student();
                    student.ID = Convert.ToInt32(reader["ID"]);
                    student.FirstName = reader["FirstName"].ToString();
                    student.LastName = reader["LastName"].ToString();
                    students.Add(student);
                }
                connection.Close();
            }
                return View(students);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Student student)
        {
            string queryString = @"Insert into Students (FirstName, LastName) Values (@FirstName, @LastName)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                command.Parameters.Add("@LastName", SqlDbType.VarChar);

                command.Parameters["@FirstName"].Value = student.FirstName;
                command.Parameters["@LastName"].Value = student.LastName;

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            string queryString = "Select * From Students where id = @id";
            Student student = new Student();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@id", SqlDbType.Int);

                command.Parameters["@id"].Value = id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    student.ID = Convert.ToInt32(reader["ID"]);
                    student.FirstName = reader["FirstName"].ToString();
                    student.LastName = reader["LastName"].ToString();
                }
                connection.Close();
            }
            return View(student);
        }

        public ActionResult Edit(int id)
        {
            string queryString = "Select * From Students where id = @id";
            Student student = new Student();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@id", SqlDbType.Int);

                command.Parameters["@id"].Value = id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    student.ID = Convert.ToInt32(reader["ID"]);
                    student.FirstName = reader["FirstName"].ToString();
                    student.LastName = reader["LastName"].ToString();
                }
                connection.Close();
            }
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            string queryString = @"Update Students set FirstName = @FirstName, LastName = @LastName where ID = @ID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ID", SqlDbType.Int);
                command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                command.Parameters.Add("@LastName", SqlDbType.VarChar);

                command.Parameters["@ID"].Value = student.ID;
                command.Parameters["@FirstName"].Value = student.FirstName;
                command.Parameters["@LastName"].Value = student.LastName;

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
            }
            return RedirectToAction("Index");
        }
    }
}