using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS3_VyLy_N01600569
{
    public static class StudentDB
    {
        private static readonly string Path = @"C:\Users\vylnp\OneDrive\Documents\Semester2\C#\week11\AS3-VyLy-N01600569\AS3-VyLy-N01600569\Student.txt";
        private const string Delimiter = "|";
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            using (StreamReader textIn = new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read)))
            {
                string row;
                while ((row = textIn.ReadLine()) != null)
                {
                    string[] columns = row.Split(Delimiter.ToCharArray());

                    if (columns.Length == 7)
                    {
                        Student student = new Student
                        {
                            StudentID = Convert.ToInt32(columns[0]),
                            FirstName = columns[1],
                            LastName = columns[2],
                            Age = Convert.ToInt32(columns[3]),
                            Gender = columns[4],
                            ClassName = columns[5],
                            Grade = Convert.ToDouble(columns[6])
                        };
                        students.Add(student);
                    }
                }
            }
            return students;
        }

        public static void SaveStudents(List<Student> students)
        {
            using (StreamWriter textOut = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write)))
            {
                foreach (Student student in students)
                {
                    textOut.Write(student.StudentID + Delimiter);
                    textOut.Write(student.FirstName + Delimiter);
                    textOut.Write(student.LastName + Delimiter);
                    textOut.Write(student.Age + Delimiter);
                    textOut.Write(student.Gender + Delimiter);
                    textOut.Write(student.ClassName + Delimiter);
                    textOut.WriteLine(student.Grade);
                }
            }
        }

        public static void DeleteStudent(Student selectedStudent)
        {
            List<Student> students = GetStudents();
            students.RemoveAll(student => student.StudentID == selectedStudent.StudentID);
            SaveStudents(students);
        }

        public static void AddStudent(Student newStudent)
        {
            List<Student> students = GetStudents();
            students.Add(newStudent);
            SaveStudents(students);
        }

        public static void EditStudent(Student editedStudent)
        {
            List<Student> students = GetStudents();

            // Tìm bài tập cần chỉnh sửa trong danh sách
            Student existingStudent = students.FirstOrDefault(a => a.StudentID == editedStudent.StudentID);

            if (existingStudent != null)
            {
                // Chỉnh sửa thông tin của bài tập
                existingStudent.FirstName = editedStudent.FirstName;
                existingStudent.LastName = editedStudent.LastName;
                existingStudent.Age = editedStudent.Age;
                existingStudent.Gender = editedStudent.Gender;
                existingStudent.ClassName = editedStudent.ClassName;
                existingStudent.Grade = editedStudent.Grade;

                // Lưu danh sách bài tập đã chỉnh sửa vào tệp văn bản
                SaveStudents(students);
            }
        }
    }
}
