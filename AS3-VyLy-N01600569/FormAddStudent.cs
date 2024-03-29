using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS3_VyLy_N01600569
{
    public partial class FormAddStudent : Form
    {
        public FormAddStudent()
        {
            InitializeComponent();
        }

        private void btnAddSD_Click(object sender, EventArgs e)
        {// Validate input fields
            if (string.IsNullOrWhiteSpace(textBoxIDStudent.Text) ||
                string.IsNullOrWhiteSpace(textBoxFN.Text) ||
                string.IsNullOrWhiteSpace(textBoxLN.Text) ||
                string.IsNullOrWhiteSpace(textBoxAge.Text) ||
                string.IsNullOrWhiteSpace(textBoxClass.Text) ||
                string.IsNullOrWhiteSpace(textBoxGrade.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Parse input values
            int studentID;
            if (!int.TryParse(textBoxIDStudent.Text, out studentID))
            {
                MessageBox.Show("Please enter a valid Student ID.");
                return;
            }

            string firstName = textBoxFN.Text;
            string lastName = textBoxLN.Text;

            int age;
            if (!int.TryParse(textBoxAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid Age.");
                return;
            }

            string gender = comboBoxGender.SelectedItem.ToString();
            string className = textBoxClass.Text;

            double grade;
            if (!double.TryParse(textBoxGrade.Text, out grade))
            {
                MessageBox.Show("Please enter a valid Grade.");
                return;
            }

            // Create a new Student object
            Student newStudent = new Student
            {
                StudentID = studentID,
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Gender = gender,
                ClassName = className,
                Grade = grade
            };

            // Get existing students from the database
            List<Student> existingStudents = StudentDB.GetStudents();

            // Add the new student to the existing students list
            existingStudents.Add(newStudent);

            // Save the updated list of students to the database
            StudentDB.SaveStudents(existingStudents);

            // Display a success message to the user
            MessageBox.Show("Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form
            this.Close();
        }
    }
}
