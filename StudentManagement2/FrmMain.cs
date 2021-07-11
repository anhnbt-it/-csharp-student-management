using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement2.Entities;
using StudentManagement2.DataAccessObject;

namespace StudentManagement2
{
    public partial class FrmMain : Form
    {
        private readonly StudentDao studentDao;
        private List<Student> students;
        int StudentRowIndex = 0;
        public FrmMain()
        {
            InitializeComponent();
            studentDao = new StudentDao();
            students = studentDao.FindAll();
            if (students.Count > 1)
            {
                StudentRowIndex = students.Count - 1;
                btnPrev.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student(
                    studentID: int.Parse(txtStudentID.Text),
                    studentName: txtStudentName.Text,
                    dateOfBirth: DateTime.Parse(dtpDateOfBirth.Value.ToString()),
                    avgScore: double.Parse(txtAvgScore.Text),
                    classID: txtClassID.Text,
                    address: txtAddress.Text);
                if (studentDao.Save(student) > 0)
                {
                    MessageBox.Show("Thêm sinh viên '" + student.StudentName + "'  thành công!");
                    // Cập nhật lại Danh sách sinh viên
                    students = studentDao.FindAll();
                    // Cập nhật lại STT = sinh viên cuối cùng trong Danh sách
                    StudentRowIndex = students.Count - 1;
                    btnPrev.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (students.Count > 0) {
                if (StudentRowIndex == 0)
                {
                    // Nếu là bản ghi đầu tiên thì set lại SV hiện tại = SV cuối cùng trong DS
                    StudentRowIndex = students.Count - 1;
                }
                else
                {
                    StudentRowIndex--;
                }
                Student student = students[StudentRowIndex];
                txtStudentID.Text = student.StudentID.ToString();
                txtStudentName.Text = student.StudentName.ToString();
                dtpDateOfBirth.Value = DateTime.Parse(student.DateOfBirth.ToString());
                txtAvgScore.Text = student.AvgScore.ToString();
                txtClassID.Text = student.ClassID.ToString();
                txtAddress.Text = student.Address.ToString();
                // Enable button Xoá
                btnDelete.Enabled = true;
            } else
            {
                MessageBox.Show("Không có dữ liệu.");
                // Nếu không còn sinh viên nào trong DS thì disable button
                btnPrev.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student student = students[StudentRowIndex];
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa sinh viên '" + student.StudentName + "'?", 
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (studentDao.DeleteByID(student.StudentID))
                {
                    MessageBox.Show("Xóa sinh viên '" + student.StudentName + "' thành công!");
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi");
                }
            }
        }

        public void ResetForm()
        {
            // Cập nhật lại Danh sách sinh viên
            students = studentDao.FindAll();
            // Cập nhật lại STT = sinh viên cuối cùng trong Danh sách
            StudentRowIndex = students.Count - 1;

            // Làm trống toàn bộ dữ liệu trong Form
            txtStudentID.Text = String.Empty;
            txtStudentName.Text = String.Empty;
            dtpDateOfBirth.Value = DateTimePicker.MinimumDateTime;
            txtAvgScore.Text = String.Empty;
            txtClassID.Text = String.Empty;
            txtAddress.Text = String.Empty;

            btnDelete.Enabled = false;
        }
    }
}
