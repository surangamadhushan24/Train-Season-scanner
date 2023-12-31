using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanerProject
{
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            if(userName == "" &&  password == "")
            {
                MessageBox.Show("field cannot be Empty", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(userName == "")
            {
                MessageBox.Show("Enter User Name", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(password == "")
            {
                MessageBox.Show("Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(userName == "admin" && password == "admin")
            {
                MessageBox.Show("Login successfully","complete",MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormScanner formScanner = new FormScanner();
                formScanner.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Enter Correct user name and password","error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUserName.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxUserName.Focus();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close(); 

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }
    }
}
