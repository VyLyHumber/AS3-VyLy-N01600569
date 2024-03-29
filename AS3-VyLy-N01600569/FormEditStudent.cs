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
    public partial class FormEditStudent : Form
    {
        private Student student;
        public FormEditStudent(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private bool ValidateInput()
        {
            // Check if first name is empty
            if (string.IsNullOrWhiteSpace(textBoxFN.Text))
            {
                MessageBox.Show("Please enter first name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if last name is empty
            if (string.IsNullOrWhiteSpace(textBoxLN.Text))
            {
                MessageBox.Show("Please enter last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if age is a valid integer
            int age;
            if (!int.TryParse(textBoxAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if grade is a valid double
            double grade;
            if (!double.TryParse(textBoxGrade.Text, out grade))
            {
                MessageBox.Show("Please enter a valid grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Dữ liệu hợp lệ
            return true;
        }

        private void FormEditStudent_Load(object sender, EventArgs e)
        {
            // Populate the form fields with the current student information
            textBoxIDStudent.Text = student.StudentID.ToString();
            textBoxFN.Text = student.FirstName;
            textBoxLN.Text = student.LastName;
            textBoxAge.Text = student.Age.ToString();
            comboBoxGender.SelectedItem = student.Gender;
            textBoxClass.Text = student.ClassName;
            textBoxGrade.Text = student.Grade.ToString();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            // Validate user input
            if (!ValidateInput())
                return; // If input is not valid, exit the method

            // Update student object with the new values from the form
            student.FirstName = textBoxFN.Text;
            student.LastName = textBoxLN.Text;
            student.Age = int.Parse(textBoxAge.Text);
            student.Gender = comboBoxGender.SelectedItem.ToString();
            student.ClassName = textBoxClass.Text;
            student.Grade = double.Parse(textBoxGrade.Text);

            // Call the EditStudent method to update the student in the database
            StudentDB.EditStudent(student);

            // Optionally, you can display a message indicating the successful update
            MessageBox.Show("Student information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form or take any other necessary actions
            this.Close();
        }
    }
}
