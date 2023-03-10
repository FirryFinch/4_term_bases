using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Макет
{
    public partial class Car_Client : Form
    {
        Thread thread;
        public Car_Client()
        {
            InitializeComponent();
        }

        private void Car_Client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "макет_v2DataSet.CarTypes". При необходимости она может быть перемещена или удалена.
            this.carTypesTableAdapter.Fill(this.макет_v2DataSet.CarTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "макет_v2DataSet.Car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.макет_v2DataSet.Car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "макет_v2DataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.макет_v2DataSet.Client);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clientTableAdapter.Update(макет_v2DataSet);
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.макет_v2DataSet);
            MessageBox.Show("Успешно сохранено!");
        }

        private void buttonboss_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenCall);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void OpenCall(object obj)
        {
            Application.Run(new SystemProfileCall());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.Remove(this.clientBindingSource.Current);
            this.clientTableAdapter.Update(this.макет_v2DataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.clientBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.clientCarBindingSource.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.clientCarBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientCarBindingSource.Remove(this.clientCarBindingSource.Current);
            this.carTableAdapter.Update(this.макет_v2DataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            carTableAdapter.Update(макет_v2DataSet);
            this.Validate();
            this.clientCarBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.макет_v2DataSet);
            MessageBox.Show("Успешно сохранено!");
        }
    }
}
