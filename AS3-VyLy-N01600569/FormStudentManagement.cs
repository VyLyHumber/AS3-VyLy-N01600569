using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AS3_VyLy_N01600569
{
    public partial class FormStudentManagement : Form
    {       
        private List<Student> students;
        private List<Assignment> assignments;
        public FormStudentManagement()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadStudents();
            LoadAssignments();
        }

        private void InitializeDataGridView()
        {
            dataGridViewStudent.Columns.Add("StudentID", "Student ID");
            dataGridViewStudent.Columns.Add("FirstName", "First Name");
            dataGridViewStudent.Columns.Add("LastName", "Last Name");
            dataGridViewStudent.Columns.Add("Age", "Age");
            dataGridViewStudent.Columns.Add("Gender", "Gender");
            dataGridViewStudent.Columns.Add("ClassName", "Class Name");
            dataGridViewStudent.Columns.Add("Grade", "Grade");

            dataGridViewAS.Columns.Add("StudentID", "Student ID");
            dataGridViewAS.Columns.Add("AssignmentID", "Assignment ID");
            dataGridViewAS.Columns.Add("AssignmentName", "Assignment Name");
            dataGridViewAS.Columns.Add("Score", "Score");
            dataGridViewAS.Columns.Add("TotalScore", "Total Score");
        }

        private void UpdateDataGridView(List<Student> students)
        {
            dataGridViewStudent.Rows.Clear();

            foreach (var student in students)
            {
                dataGridViewStudent.Rows.Add(student.StudentID, student.FirstName, student.LastName, student.Age,
                                          student.Gender, student.ClassName, student.Grade);
            }


        }

        private void UpdateDataGridViewAS(Assignment[] assignments)
        {
            dataGridViewAS.Rows.Clear();

            foreach (var assignment in assignments)
            {
                dataGridViewAS.Rows.Add(assignment.StudentID, assignment.AssignmentID, assignment.AssignmentName,
                                          assignment.Score, assignment.TotalScore);
            }
        }

        private void LoadStudents()
        {
            // Retrieve assignments from the AssignmentDB
            students = StudentDB.GetStudents();

            // Update the DataGridView with assignment data
            UpdateDataGridView(students);
        }

        private void LoadAssignments()
        {
            // Retrieve assignments from the AssignmentDB
            assignments = AssignmentDB.GetAssignments();

            // Update the DataGridView with assignment data
            UpdateDataGridViewAS(assignments.ToArray());

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearchSD.Text.ToLower();
            var searchResult = students.Where(s => s.StudentID.ToString().Contains(keyword) ||
                                                   s.FirstName.ToLower().Contains(keyword) ||
                                                   s.LastName.ToLower().Contains(keyword))
                                       .ToList();

            UpdateDataGridView(searchResult);
        }
        
        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void btnSearchAS_Click(object sender, EventArgs e)
        {
            string keyword = txtBoxSearchAS.Text.ToLower();
            var searchResult = assignments.Where(a => a.StudentID.ToString().Contains(keyword) ||
                                                       a.AssignmentID.ToString().Contains(keyword) ||
                                                       a.AssignmentName.ToLower().Contains(keyword))
                                           .ToArray();

            UpdateDataGridViewAS(searchResult);
        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            if (radioButtonEditAS.Checked)
            {
                if (dataGridViewAS.SelectedRows.Count > 0)
                {
                    // Lấy bài tập được chọn
                    Assignment selectedAssignment = assignments[dataGridViewAS.SelectedRows[0].Index];

                    // Hiển thị form chỉnh sửa bài tập
                    FormEditAssignment formEditAssignment = new FormEditAssignment(selectedAssignment);
                    formEditAssignment.ShowDialog();
                    LoadAssignments();
                }
                else
                {
                    MessageBox.Show("Please select an assignment to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButtonAddAS.Checked)
            {
                // Hiển thị form thêm assignment
                FormAddAssignment formAddAssignment = new FormAddAssignment();
                formAddAssignment.ShowDialog();
                LoadAssignments();
            }
            else if (radioButtonDeleteAS.Checked)
            {
                if (dataGridViewAS.SelectedRows.Count > 0)
                {
                    // Get the selected assignment
                    Assignment selectedAssignment = assignments[dataGridViewAS.SelectedRows[0].Index];

                    // Prompt the user for confirmation
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this assignment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Delete the assignment
                        AssignmentDB.DeleteAssignment(selectedAssignment);
                        // Reload assignments
                        LoadAssignments();
                    }
                }
                else
                {
                    MessageBox.Show("Please select an assignment to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButtonAddSD.Checked)
            {
                // Hiển thị form thêm student
                FormAddStudent formAddStudent = new FormAddStudent();
                formAddStudent.ShowDialog();
                LoadStudents();
            }
            else if (radioButtonEditSD.Checked)
            {
                if (dataGridViewStudent.SelectedRows.Count > 0)
                {
                    // Lấy bài tập được chọn
                    Student selectedStudent = students[dataGridViewStudent.SelectedRows[0].Index];

                    FormEditStudent formEditStudent = new FormEditStudent(selectedStudent);
                    formEditStudent.ShowDialog();
                    LoadStudents();
                }
                else
                {
                    MessageBox.Show("Please select a student to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Hiển thị form chỉnh sửa student
                
            }
            else if (radioButtonDeleteSD.Checked)
            {
                if (dataGridViewStudent.SelectedRows.Count > 0)
                {
                    // Get the selected student
                    Student selectedStudent = students[dataGridViewStudent.SelectedRows[0].Index];

                    // Prompt the user for confirmation
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Delete the student
                        StudentDB.DeleteStudent(selectedStudent);
                        // Reload students
                        LoadStudents();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButtonExit.Checked)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an action.");
            }
        }
    }
}
