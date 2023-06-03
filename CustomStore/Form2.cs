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
using System.Data.Common;
using System.Reflection;

namespace CustomStore
{
    enum RowState { 
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form2 : Form
    {
        DataBase dataBase = new DataBase();

        int selectedRow;

        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private DataGridView dataGridView1 = new DataGridView();

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("PhoneNumber", "PhoneNumber");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record) 
        { 
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Update();

            string queryString = $"select * from Customer";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();
            
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            customerDataGridView.DataSource = dt;
            reader.Close();
        }

        private void deleteRow()
        {
            DataGridViewRow row = customerDataGridView.SelectedRows[0];
            customerDataGridView.CurrentCell=null;
            row.Visible = false;

            if (row.Cells[0].Value.ToString() == string.Empty)
            {
                row.Cells[5].Value = RowState.Deleted;
                return;
            }
        }

        private void update()
        {
            dataBase.openConnection();
            foreach (DataGridViewRow row in customerDataGridView.Rows) { 
                if (!row.Visible)
                {
                    var ID = Convert.ToInt32(row.Cells[0].Value);
                    var deleteQuery = $"delete from Customer where ID={ID}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();

                }
            }
            dataBase.closeConnection();
        
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Do you really want to leave?";
            String caption = "Out";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "customStoreDataSet.Shaper". При необходимости она может быть перемещена или удалена.
            this.shaperTableAdapter.Fill(this.customStoreDataSet.Shaper);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "customStoreDataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.customStoreDataSet.Material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "customStoreDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.customStoreDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "customStoreDataSet.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.customStoreDataSet.Customer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "customStoreDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.customStoreDataSet.Order);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0) 
            { 
                DataGridViewRow row = customerDataGridView.Rows[selectedRow];
                IDCustomer.Text = row.Cells[0].Value.ToString();
                customerCustomer.Text = row.Cells[1].Value.ToString();
                phoneNumber.Text = row.Cells[2].Value.ToString();

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(customerDataGridView);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Form4 add = new Form4();
            add.Show();
        }

        private void Deleted_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            update();
        }

        private void orderAdd_Click(object sender, EventArgs e)
        {
            Form5 add = new Form5();
            add.Show();
        }
        private void orderRefreshDataGrid(DataGridView dgw)
        {
            dgw.Update();

            string queryString = $"select * from [Order]";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            orderDataGridView.DataSource = dt;
            reader.Close();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            orderRefreshDataGrid(orderDataGridView);
        }
        private void orderDeleteRow()
        {
            DataGridViewRow row = orderDataGridView.SelectedRows[0];
            orderDataGridView.CurrentCell = null;
            row.Visible = false;

            if (row.Cells[0].Value.ToString() == string.Empty)
            {
                row.Cells[6].Value = RowState.Deleted;
                return;
            }
        }

        private void orderUpdate()
        {
            dataBase.openConnection();
            foreach (DataGridViewRow row in orderDataGridView.Rows)
            {
                if (!row.Visible)
                {
                    var ID = Convert.ToInt32(row.Cells[0].Value);
                    var deleteQuery = $"delete from [Order] where ID={ID}";

                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();

                }
            }
            dataBase.closeConnection();

        }
        private void orderDelete_Click(object sender, EventArgs e)
        {
            orderDeleteRow();
        }

        private void orderSave_Click(object sender, EventArgs e)
        {
            orderUpdate();
        }
    }
}
