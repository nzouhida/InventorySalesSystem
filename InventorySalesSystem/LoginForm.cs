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

namespace InventorySalesSystem
{
    public partial class LoginForm : Form
    {
        // store users in a 2D array: [row, column]
        // columns 0 = username, 1 = password, 2 = full name, 3 = email

        private string[,] _users;
        private int _userCount = 0;
        public LoginForm()
        {
            InitializeComponent();
            LoadUsersFromFile();
        }

        private void LoadUsersFromFile()
        {
            string filePath = "login.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("login.txt file not found. Please place it in the project folder.", "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            string[] lines = File.ReadAllLines(filePath);

            _users = new string[lines.Length, 4]; // 4 columns per user
            _userCount = lines.Length;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts.Length >= 4)
                {
                    _users[i, 0] = parts[0]; // username
                    _users[i, 1] = parts[1]; // password
                    _users[i, 2] = parts[2]; // full name
                    _users[i, 3] = parts[3]; // email
                }
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            lblMessage.Text = ""; // Clear previous messages

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Please enter both username and password.";
                return;
            }
            // make sure users are loaded
            if (_users == null || _userCount == 0)
            {
                MessageBox.Show("User data could not be loaded. Check login.txt.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool found = false;
            string fullName = "";

            // loop through all users
            for (int i = 0; i < _userCount; i++)
            {
                if (_users[i, 0] == username && _users[i, 1] == password)
                {
                    found = true;
                    fullName = _users[i, 2];
                    break;
                }
            }
            if (!found)
            {
                lblMessage.Text = "Invalid username or password.";
                return;
            }
            // successful login
            MessageBox.Show($"Welcome, {fullName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide(); //hides login form and opens interface form 
            Interface form1 = new Interface();
            //pauses until signing out or exited from interface form
            form1.ShowDialog();
            this.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

//Username login: First name (ex. Noah)
//Password login: First name + 1234 (ex. Noah1234)

// For Proffesor
// Username: Diba
// Password: Diba1234
