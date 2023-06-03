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
    public partial class Form4 : Form
    {
        DataBase dataBase = new DataBase();
        public Form4()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var ID = IDCustomer.Text;
            var Name = customerCustomer.Text;
            var PhoneNumber = phoneNumber.Text;

            var addQuery = $"insert into Customer (ID, Name, PhoneNumber) values ('{ID}', '{Name}', '{PhoneNumber}')";
            var command = new SqlCommand(addQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Successfully!");

            dataBase.closeConnection();
        }
    }
}
