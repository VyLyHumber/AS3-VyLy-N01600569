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
    public partial class Form1 : Form
    {
        private const string userFilePath = "C:\\Users\\vylnp\\OneDrive\\Documents\\Semester2\\C#\\week11\\AS3-VyLy-N01600569\\AS3-VyLy-N01600569\\user.txt";
        private List<User> users;
        public Form1()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            users = File.ReadAllLines(userFilePath)
                        .Select(line => line.Split(','))
                        .Select(parts => new User { Username = parts[0], Password = parts[1] })
                        .ToList();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (Authenticate(username, password))
            {
                MessageBox.Show("Login successful");
                OpenStudentManagementForm();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

        }

        private bool Authenticate(string username, string password)
        {
            return users.Any(u => u.Username == username && u.Password == password);
        }

        private void OpenStudentManagementForm()
        {
            FormStudentManagement studentForm = new FormStudentManagement();
            studentForm.Show();
        }
    }
}
