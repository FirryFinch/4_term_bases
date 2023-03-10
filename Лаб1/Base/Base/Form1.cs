using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИУ5_31Б_Анцифров_ЛП2000DataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this._ИУ5_31Б_Анцифров_ЛП2000DataSet.Order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_ИУ5_31Б_Анцифров_ЛП2000DataSet.Car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this._ИУ5_31Б_Анцифров_ЛП2000DataSet.Car);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carTableAdapter.Update(_ИУ5_31Б_Анцифров_ЛП2000DataSet);
            this.Validate();
            this.carBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._ИУ5_31Б_Анцифров_ЛП2000DataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
        }
    }
}
