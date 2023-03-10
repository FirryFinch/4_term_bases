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
    public partial class ChangeClient : Form
    {
        Thread thread;
        string par;
         
        public ChangeClient(string paramenter)
        {
            InitializeComponent();
            if (paramenter == "admin")
            {
                buttonadmin.Visible = true;
                buttonboss.Visible = false;
            }
            else
            if (paramenter == "boss")
            {
                buttonadmin.Visible = false;
                buttonboss.Visible = true;
            }
            par = paramenter;
        }

        private void ChangeClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "макет_v2DataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.макет_v2DataSet.Client);

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                findbut.PerformClick();
            }
        }
        private void buttonadmin_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenAdmin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void OpenAdmin(object obj)
        {
            Application.Run(new SystemProfileAdmin());
        }

        private void buttonboss_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenBoss);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void OpenBoss(object obj)
        {
            Application.Run(new SystemProfileBoss());
        }

        private void findbut_Click(object sender, EventArgs e)
        {
            string InsertedName = textBox1.Text;
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\Users\\antsi\\OneDrive\\Документы\\МГТУ\\4 семестр\\БД\\Лабораторные\\Макет\\Макет_v2.mdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM [Client] " + " WHERE ClientSurname LIKE \'" + InsertedName + "%\'", connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(NewFormAdd);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void NewFormAdd(object obj)
        {
            Application.Run(new AddClient(par));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\Users\\antsi\\OneDrive\\Документы\\МГТУ\\4 семестр\\БД\\Лабораторные\\Макет\\Макет_v2.mdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM [Client] ORDER BY [ClientSurname]", connection);
            connection.Close();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
            MessageBox.Show("Список успешно отсортирован по возрастанию по фамилиям клиентов!");
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                findbut.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clientTableAdapter.Update(макет_v2DataSet);
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.макет_v2DataSet);
            MessageBox.Show("Успешно сохранено!");
        }
    }
}
