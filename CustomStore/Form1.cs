using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CustomStore
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String login = loginField.Text;
            String password = passwordField.Text;
            
             SqlDataAdapter adapter = new SqlDataAdapter();
             DataTable table = new DataTable();

            string querystring = $"select ID, Login, Password from [User] where Login = '{login}' and Password = '{password}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Successfully!");
                if (login == "admin")
                {
                    Form2 f2 = new Form2();
                    this.Hide();
                    f2.ShowDialog();
                    this.Show();
                }
                else
                {
                    Form3 f3 = new Form3();
                    this.Hide();
                    f3.ShowDialog();
                    this.Show();
                }
            }
            else MessageBox.Show("Incorrect login or password.");

            loginField.Clear();
            passwordField.Clear();
        }
    }
}
