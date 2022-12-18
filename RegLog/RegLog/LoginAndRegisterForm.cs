using Org.BouncyCastle.Bcpg.Sig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RegLog
{
    public partial class LoginAndRegisterForm : Form
    {
        public LoginAndRegisterForm()
        {
            InitializeComponent();
        }

        Color select_color= Color.RoyalBlue;

        private void button_GoToLogin_Click(object sender, EventArgs e)
        {
            panel_login.BringToFront();
            panel_login_bar.BackColor= Color.LightBlue;
            panel_register_bar.BackColor = select_color
;            button_GoToLogin.BackColor= select_color;
            panel_login.BackColor= select_color;
            button_GoToRegister.BackColor= Color.CornflowerBlue;
        }

        private void button_GoToRegister_Click(object sender, EventArgs e)
        {
            panel_register.BringToFront();
            panel_register_bar.BackColor= Color.LightBlue;
            panel_login_bar.BackColor= select_color;
            button_GoToRegister.BackColor = select_color;
            panel_register.BackColor = select_color;
            button_GoToLogin.BackColor = Color.CornflowerBlue;
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            string firstname = textBoxFirstname.Text;
            string lastname = textBoxLastname.Text;
            string username = textBoxUsernameRegister.Text;
            string password = textBoxPasswordRegister.Text;

             
            if (verifFields("register"))
            {
                USER user = new USER();
                if (user.usernameExist(username))
                {
                    MessageBox.Show("This Username Already Exists Try Another One", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (user.insertUser(firstname, lastname, username, password))
                    {
                        MessageBox.Show("Registration Completed Successfully! Now Login", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("* Required Fields - Username or Password", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool verifFields(string operation)
        {
            bool check = false;
            if(operation == "register")
            {
                if(textBoxUsernameRegister.Text.Trim().Equals("") || textBoxPasswordRegister.Text.Trim().Equals(""))
                {
                    check = false;
                }
                else
                {
                    check = true;
                }
            }
            else if(operation == "login")
            {
                if(textBoxUsername.Text.Trim().Equals("") || textBoxPassword.Text.Trim().Equals(""))
                {
                    check = false;
                }
                else
                {
                    check = true;
                }
            }
            return check;
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            USER user = new USER();
            MY_DB dB = new MY_DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users`.`users` WHERE `username`=@un AND `password`=@pass;", dB.getConnection);
            command.Parameters.Add("@un", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (verifFields("login"))
            {
                if (table.Rows.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
