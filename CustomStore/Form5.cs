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
    public partial class Form5 : Form
    {
        DataBase dataBase = new DataBase();
        public Form5()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var ID = id.Text;
            var Date = date.Text;
            var Customer = customer.Text;
            var Product = product.Text;
            var Material = material.Text;
            var Size = size.Text;
            var Shaper = shaper.Text;

            var addQuery = $"insert into [Order] (ID, Date, IDCustomer, IDProduct, IDMaterial, Size, IDShaper) values ('{ID}', '{Date}', '{Customer}', '{Product}', '{Material}', '{Size}', '{Shaper}')";
            var command = new SqlCommand(addQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Successfully!");

            dataBase.closeConnection();
        }
    }
}
