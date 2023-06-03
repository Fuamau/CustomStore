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
    public partial class Form3 : Form
    {
        DataBase dataBase = new DataBase();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Do you really want to leave?";
            String caption = "Out";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                this.Close();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customStoreDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "customStoreDataSet.Shaper". При необходимости она может быть перемещена или удалена.
            this.shaperTableAdapter.Fill(this.customStoreDataSet.Shaper);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "customStoreDataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.customStoreDataSet.Material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "customStoreDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.customStoreDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "customStoreDataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.customStoreDataSet.Material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "customStoreDataSet.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.customStoreDataSet.Customer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "customStoreDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.customStoreDataSet.Order);

        }
    }
}
