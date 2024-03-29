using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS3_VyLy_N01600569
{
    public static class AssignmentDB
    {
        private static readonly string Path = @"C:\Users\vylnp\OneDrive\Documents\Semester2\C#\week11\AS3-VyLy-N01600569\AS3-VyLy-N01600569\Assignment.txt";
        private const string Delimiter = "|";

        public static List<Assignment> GetAssignments()
        {
            List<Assignment> assignments = new List<Assignment>();

            using (StreamReader textIn = new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read)))
            {
                string row;
                while ((row = textIn.ReadLine()) != null)
                {
                    string[] columns = row.Split(Delimiter.ToCharArray());

                    if (columns.Length == 5)
                    {
                        Assignment assignment = new Assignment
                        {
                            StudentID = Convert.ToInt32(columns[0]),
                            AssignmentID = Convert.ToInt32(columns[1]),
                            AssignmentName = columns[2],
                            Score = Convert.ToInt32(columns[3]),
                            TotalScore = Convert.ToInt32(columns[4])
                        };
                        assignments.Add(assignment);
                    }
                }
            }
            return assignments;
        }

        public static void SaveAssignments(List<Assignment> assignments)
        {
            using (StreamWriter textOut = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write)))
            {
                foreach (Assignment assignment in assignments)
                {
                    textOut.Write(assignment.StudentID + Delimiter);
                    textOut.Write(assignment.AssignmentID + Delimiter);
                    textOut.Write(assignment.AssignmentName + Delimiter);
                    textOut.Write(assignment.Score + Delimiter);
                    textOut.WriteLine(assignment.TotalScore);
                }
            }
        }

        public static void DeleteAssignment(Assignment selectedAssignment)
        {
            List<Assignment> assignments = GetAssignments();
            assignments.RemoveAll(assignment => assignment.StudentID == selectedAssignment.StudentID && assignment.AssignmentID == selectedAssignment.AssignmentID); // Remove assignment with matching StudentID and AssignmentID
            SaveAssignments(assignments); // Save the updated list
        }

        public static void AddAssignment(Assignment newAssignment)
        {
            List<Assignment> assignments = GetAssignments();
            assignments.Add(newAssignment); // Add new assignment to the list
            SaveAssignments(assignments); // Save the updated list
        }

        public static void EditAssignment(Assignment updatedAssignment)
        {
            List<Assignment> assignments = GetAssignments();

            // Tìm bài tập cần chỉnh sửa trong danh sách
            Assignment existingAssignment = assignments.FirstOrDefault(a => a.StudentID == updatedAssignment.StudentID);

            if (existingAssignment != null)
            {
                // Chỉnh sửa thông tin của bài tập
                existingAssignment.AssignmentID = updatedAssignment.AssignmentID;
                existingAssignment.AssignmentName = updatedAssignment.AssignmentName;
                existingAssignment.Score = updatedAssignment.Score;
                existingAssignment.TotalScore = updatedAssignment.TotalScore;

                // Lưu danh sách bài tập đã chỉnh sửa vào tệp văn bản
                SaveAssignments(assignments);
            }
        }
    }
}