using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using StudentManagement2.Entities;
using System.Configuration;

namespace StudentManagement2.DataAccessObject
{
    class StudentDao
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["StudentManagement"].ConnectionString;
        public Student FindByStudentID(int StudentID)
        {
            Student student = new Student();
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string queryString = "SELECT * FROM Students WHERE StudentID = " + StudentID;
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    student.StudentID = (int)dt.Rows[0]["StudentID"];
                    student.StudentName = dt.Rows[0]["StudentName"].ToString();
                    student.DateOfBirth = DateTime.Parse(dt.Rows[0]["DateOfBirth"].ToString());
                    student.AvgScore = (double)dt.Rows[0]["AvgScore"];
                    student.ClassID = dt.Rows[0]["ClassID"].ToString();
                    student.Address = dt.Rows[0]["Address"].ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return student;
        }

        public int Save(Student student)
        {
            int rowsAffected = 0;
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string queryString = "INSERT INTO Students (StudentID, " +
                    "StudentName, DateOfBirth, AvgScore, ClassID, Address) VALUES (" +
                    "@StudentID, @StudentName, @DateOfBirth, @AvgScore, @ClassID, @Address);";
                SqlCommand command = new SqlCommand(queryString, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.Add("@StudentID", SqlDbType.VarChar);
                command.Parameters["@StudentID"].Value = student.StudentID;
                command.Parameters.Add("@StudentName", SqlDbType.NVarChar);
                command.Parameters["@StudentName"].Value = student.StudentName;
                command.Parameters.Add("@DateOfBirth", SqlDbType.Date);
                command.Parameters["@DateOfBirth"].Value = student.DateOfBirth;
                command.Parameters.Add("@AvgScore", SqlDbType.Decimal);
                command.Parameters["@AvgScore"].Value = student.AvgScore;
                command.Parameters.Add("@ClassID", SqlDbType.NVarChar);
                command.Parameters["@ClassID"].Value = student.ClassID;
                command.Parameters.Add("@Address", SqlDbType.NVarChar);
                command.Parameters["@Address"].Value = student.Address;
                rowsAffected = command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return rowsAffected;
        }

        public bool DeleteByID(int StudentID)
        {
            int rowsAffected = 0;
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string queryString = "DELETE FROM Students WHERE StudentID = " + StudentID;
                SqlCommand command= new SqlCommand(queryString, conn);
                command.CommandType = CommandType.Text;
                rowsAffected = command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return rowsAffected > 0;
        }

        public List<Student> FindAll()
        {
            List<Student> students = new List<Student>();
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string queryString = "SELECT * FROM Students ORDER BY CreatedAt";
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach(DataRow row in dt.Rows)
                    {
                        Student student = new Student();
                        student.StudentID = int.Parse(row[0].ToString());
                        student.StudentName = row[1].ToString();
                        student.DateOfBirth = DateTime.Parse(row[2].ToString());
                        student.AvgScore = double.Parse(row[3].ToString());
                        student.ClassID = row[4].ToString();
                        student.Address = row[5].ToString();
                        students.Add(student);
                    }
                }
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return students;
        }

    }
}
