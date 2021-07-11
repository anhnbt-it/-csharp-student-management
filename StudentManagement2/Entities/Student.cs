using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentManagement2.Entities
{
    class Student
    {
        private int studentID;
        private string studentName;
        private DateTime dateOfBirth;
        private double avgScore;
        private string classID;
        private string address;

        public Student()
        {

        }
        public Student(int studentID, string studentName, DateTime dateOfBirth, double avgScore, string classID, string address)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            this.dateOfBirth = dateOfBirth;
            this.avgScore = avgScore;
            this.classID = classID;
            this.address = address;
        }

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public double AvgScore
        {
            get { return avgScore; }
            set { avgScore = value; }
        }

        public string ClassID
        {
            get { return classID; }
            set { classID = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
