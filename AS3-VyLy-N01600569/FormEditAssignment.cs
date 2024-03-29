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
    public partial class FormEditAssignment : Form
    {
        private Assignment assignment;
        public FormEditAssignment(Assignment assignment)
        {
            InitializeComponent();
            this.assignment = assignment;
        }

        private bool ValidateInput()
        {
            // Kiểm tra xem các TextBox có trống hay không
            if (string.IsNullOrWhiteSpace(textBoxASName.Text))
            {
                MessageBox.Show("Please enter assignment name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra xem điểm và tổng điểm có là số không
            int score;
            if (!int.TryParse(textBoxASScore.Text, out score))
            {
                MessageBox.Show("Please enter a valid score.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int totalScore;
            if (!int.TryParse(textBoxASTotal.Text, out totalScore))
            {
                MessageBox.Show("Please enter a valid total score.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra xem điểm có nhỏ hơn tổng điểm không
            if (score > totalScore)
            {
                MessageBox.Show("Score cannot be greater than total score.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Dữ liệu hợp lệ
            return true;
        }

        private void btnEditAS_Click(object sender, EventArgs e)
        {
            // Validate user input
            if (!ValidateInput())
                return; // If input is not valid, exit the method

            // Update assignment object with the new values from the form
            assignment.AssignmentID = int.Parse(textBoxASID.Text); 
            assignment.AssignmentName = textBoxASName.Text;
            assignment.Score = int.Parse(textBoxASScore.Text);
            assignment.TotalScore = int.Parse(textBoxASTotal.Text);

            // Call the EditAssignment method to update the assignment in the database
            AssignmentDB.EditAssignment(assignment);

            // Optionally, you can display a message indicating the successful update
            MessageBox.Show("Assignment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form or take any other necessary actions
            this.Close();

        }

        private void FormEditAssignment_Load(object sender, EventArgs e)
        {
            textBoxIDStudent.Text = assignment.StudentID.ToString();
            textBoxASID.Text = assignment.AssignmentID.ToString();
            textBoxASName.Text = assignment.AssignmentName;
            textBoxASScore.Text = assignment.Score.ToString();
            textBoxASTotal.Text = assignment.TotalScore.ToString();
        }
    }
}
