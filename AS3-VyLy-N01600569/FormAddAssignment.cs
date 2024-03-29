using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS3_VyLy_N01600569
{
    public partial class FormAddAssignment : Form
    {
        public FormAddAssignment()
        {
            InitializeComponent();
        }

        private void btnAddAS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIDStudent.Text) ||
                string.IsNullOrWhiteSpace(textBoxASID.Text) ||
                string.IsNullOrWhiteSpace(textBoxASName.Text) ||
                string.IsNullOrWhiteSpace(textBoxASScore.Text) ||
                string.IsNullOrWhiteSpace(textBoxASTotal.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            int studentID;
            if (!int.TryParse(textBoxIDStudent.Text, out studentID))
            {
                MessageBox.Show("Please enter a valid Student ID.");
                return;
            }

            int assignmentID;
            if (!int.TryParse(textBoxASID.Text, out assignmentID))
            {
                MessageBox.Show("Please enter a valid Assignment ID.");
                return;
            }

            string assignmentName = textBoxASName.Text;
            int score;
            if (!int.TryParse(textBoxASScore.Text, out score))
            {
                MessageBox.Show("Please enter a valid Score.");
                return;
            }

            int totalScore;
            if (!int.TryParse(textBoxASTotal.Text, out totalScore))
            {
                MessageBox.Show("Please enter a valid Total Score.");
                return;
            }
            // Create a new Assignment object
            Assignment newAssignment = new Assignment
            {
                StudentID = studentID,
                AssignmentID = assignmentID,
                AssignmentName = assignmentName,
                Score = score,
                TotalScore = totalScore
            };

            // Get existing assignments from the database
            List<Assignment> existingAssignments = AssignmentDB.GetAssignments();

            // Add the new assignment to the existing assignments list
            existingAssignments.Add(newAssignment);

            // Save the updated list of assignments to the database
            AssignmentDB.SaveAssignments(existingAssignments);

            // Display a success message to the user
            MessageBox.Show("Assignment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form
            this.Close();

        }
    }
}
